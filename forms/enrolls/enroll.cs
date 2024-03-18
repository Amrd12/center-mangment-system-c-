using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace student_enrolled.forms
{
    public partial class enroll : Form
    {
        DataBase Base = new DataBase();
        DataTable dtenroll , dtcourse;
        int stud_id, course_id;
        public bool excel;
        private BindingSource bindingSource = new BindingSource();
        int exit;
        decimal Total_still , Total_paid;

        string view = @"SELECT se.id AS id, se.stud_id, s.name AS student, se.course_id, c.name AS course, c.price, se.paid_price AS paid, se.still, se.day
        FROM stud_enroll se
        JOIN students s ON se.stud_id = s.id
        JOIN courses c ON se.course_id = c.id";
        public enroll()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource;
            dtenroll = Base.ServerGetDataTable(view, new System.Data.SqlClient.SqlParameter[0]);
            dtcourse = Base.ServerGetDataTable("SELECT id,price from courses", new System.Data.SqlClient.SqlParameter[0]);
            dataGridView2.DataSource = Base.ServerGetDataTable($"SELECT * FROM payments ", new SqlParameter[0]);

            bindingSource.DataSource = dtenroll;
            dataGridView1.Columns["stud_id"].Visible = false;
            dataGridView1.Columns["course_id"].Visible = false;
            btnload.Visible = excel;
            btnsave.Visible = excel;
            DataGridView_Buttons();
            FillComboBox();
        }


        private void FillComboBox()
        {
            DataTable coursename = Base.ServerGetDataTable("select id , name from courses", new System.Data.SqlClient.SqlParameter[0]);
            DataTable studentname = Base.ServerGetDataTable("select id ,name from students", new System.Data.SqlClient.SqlParameter[0]);
            foreach (DataRow row in coursename.Rows)
            {
                if (row[0] != DBNull.Value && row[0] != null)
                {
                    string name = row[0].ToString() + " :   " + row[1].ToString();
                    combocource.Items.Add(name);
                }
            }

            foreach (DataRow row in studentname.Rows)
            {
                if (row[0] != DBNull.Value && row[0] != null)
                {
                    string name = row[0].ToString() + " :   " + row[1].ToString();
                    combostudent.Items.Add(name);
                }
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if ( e.RowIndex >= 0)
            {
                // Handle the button click for the selected row
                if (e.ColumnIndex == dataGridView1.Columns["EditButtonColumn"].Index)
                {
                    // Edit button clicked
                   // HandleEditButtonClick(e.RowIndex);
                }
                else if (e.ColumnIndex == dataGridView1.Columns["DeleteButtonColumn"].Index)
                {
                    // Delete button clicked
                    HandleDeleteButtonClick(e.RowIndex);
                    dataGridView2.DataSource = Base.ServerGetDataTable($"SELECT * FROM payments", new SqlParameter[0]);

                }
                if (e.ColumnIndex != dataGridView1.Columns["DeleteButtonColumn"].Index)
                {
                    // Delete button clicked
                    dataGridView2.DataSource = Base.ServerGetDataTable($"SELECT * FROM payments WHERE enroll_id ='{(int)dtenroll.Rows[e.RowIndex]["id"]}'", new SqlParameter[0]);
                }
            }
        }
        private void HandleDeleteButtonClick(int rowIndex)
        {
            // Confirm if the user wants to delete the record
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Perform the delete action here
                int id = (int)dtenroll.Rows[rowIndex]["id"];

                Base.ServerSendDataTable($"DELETE FROM stud_enroll WHERE id = '{id}'", new SqlParameter[0]);
                // Remove the row from the DataGridView
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
        }

        private void DataGridView_Buttons()
        {
            dataGridView1.Columns["day"].DefaultCellStyle.Format = "dd/MM/yyyy";
            DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
            editButtonColumn.Name = "EditButtonColumn";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Image = Properties.Resources.edit; // Set the icon for the edit button
            dataGridView1.Columns.Add(editButtonColumn);

            // Create a "Delete" button column with icons
            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.Name = "DeleteButtonColumn";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Image = Properties.Resources.delete; // Set the icon for the delete button
            dataGridView1.Columns.Add(deleteButtonColumn);

            // Create a "Delete" button column with icons
            DataGridViewImageColumn deletebtn2 = new DataGridViewImageColumn();
            deletebtn2.Name = "DeleteButtonColumn";
            deletebtn2.HeaderText = "Delete";
            deletebtn2.Image = Properties.Resources.delete; // Set the icon for the delete button
            dataGridView2.Columns.Add(deletebtn2);
            //  dataGridView1.Columns["course_id"].Visible = false;

        }


        



        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Where to save";
            sfd.FileName = "students";
            sfd.DefaultExt = ".xlsx";
            sfd.ShowDialog();
            var excelWriter = new ExcelWriter();
            excelWriter.WriteToExcel(sfd.FileName, dtenroll);
            MessageBox.Show("done");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;

            if (combocource.SelectedIndex == -1 || combostudent.SelectedIndex == -1 || txtpaid.Text == "" || txtstill.Text == "")
            {
                MessageBox.Show("Please Fill All fields");
                return;
            }

            if (exit == -1)
            {
                decimal paid = decimal.Parse(txtpaid.Text);
                decimal still = decimal.Parse(txtstill.Text);
                string enrollInsertQuery = "INSERT INTO stud_enroll (stud_id, course_id, paid_price, still, day) " +
                                           "OUTPUT INSERTED.id " +
                                           "VALUES (@student_id, @course_Id, @paid_price, @still, @day);";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@student_id", SqlDbType.Int) { Value = stud_id },
                new SqlParameter("@course_id", SqlDbType.Int) { Value = course_id },
                new SqlParameter("@paid_price", SqlDbType.Decimal) { Value = paid },
                new SqlParameter("@still", SqlDbType.Decimal) { Value = still },
                new SqlParameter("@day", SqlDbType.DateTime) { Value = date },
                };
                exit =  Base.Servergetid(enrollInsertQuery, parameters,"");
            }
            else
            {
                decimal paid = decimal.Parse(txtpaid.Text) + Total_paid;
                decimal still = decimal.Parse(txtstill.Text);
                string query = "UPDATE  stud_enroll SET  paid_price = @paid_price, still = @still  WHERE id = @id;";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@id", SqlDbType.Int) { Value = exit },
                new SqlParameter("@paid_price", SqlDbType.Decimal) { Value = paid },
                new SqlParameter("@still", SqlDbType.Decimal) { Value = still },
                };
                Base.ServerSendDataTable(query, parameters);
            }
            dtenroll = Base.ServerGetDataTable(view, new System.Data.SqlClient.SqlParameter[0]);
            bindingSource.DataSource = dtenroll;
            dataGridView1.Refresh();
            string paymentInsertQuery = "INSERT INTO payments (enroll_id, payment_date, payment_amount) " +
                        "VALUES (@enrollId, @paymentDate, @paymentAmount);";

            SqlParameter[] paymentParameters = new SqlParameter[]
            {
    new SqlParameter("@enrollId", SqlDbType.Int) { Value = exit }, // Use the exit value as enroll_id
    new SqlParameter("@paymentDate", SqlDbType.DateTime) { Value = date },
    new SqlParameter("@paymentAmount", SqlDbType.Decimal) { Value = decimal.Parse(txtpaid.Text) },
            };

            Base.ServerSendDataTable(paymentInsertQuery, paymentParameters);
            dataGridView2.DataSource = Base.ServerGetDataTable($"SELECT * FROM payments", new SqlParameter[0]);
            combocource.SelectedIndex = -1;
            combostudent.SelectedIndex = -1;
            lbtotal.Text = "";
            txtstill.Text = "";
            txtpaid.Text = "";
            lbpaid.Text = "course price : \n";
            
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            Exceltodb ex = new Exceltodb();
            ex.tablename = "students";
            ex.ShowDialog();

        }

        private void students_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.C) MessageBox.Show("Courses");
        }
        private bool addpanel = true;
        private void openadd_Tick(object sender, EventArgs e)
        {
            if (addpanel == true)
            {
                paneladd.Width += 100;
                this.btnopenadd.Image = global::student_enrolled.Properties.Resources.angle_left;
                if (paneladd.Width >= paneladd.MaximumSize.Width)
                {
                    addpanel = false;
                    openadd.Stop();
                }
            }else
            {
                paneladd.Width -= 100;
                this.btnopenadd.Image = global::student_enrolled.Properties.Resources.angle_right;
                if (paneladd.Width <= paneladd.MinimumSize.Width)
                {
                    addpanel = true;
                    openadd.Stop();
                }
            }
        }

        private void btnopenadd_Click(object sender, EventArgs e)
        {
            openadd.Start();
        }

 

        private void btnenter(object sender, EventArgs e)
        {

            btnadd = (Button)sender;
            btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));

        }
        private void btngo(object sender, EventArgs e)
        {

            btnadd = (Button)sender;
            btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));

        }
        private bool alltime = true;
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            // Reset the filter and display all records
            bindingSource.RemoveFilter();
            dataGridView2.DataSource = Base.ServerGetDataTable($"SELECT * FROM payments", new SqlParameter[0]);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {

            alltime = true;
            string s = txtsearch.Text; txtsearch.Text = "1"; txtsearch.Text = s;

        }

        private void btncustom_Click(object sender, EventArgs e)
        {
            if (DateStart == null || DateEnd == null)
            {
                MessageBox.Show("Please select both start and end dates.");

                return;
            }

            alltime = false;
            string s = txtsearch.Text; txtsearch.Text = "1"; txtsearch.Text = s;

        }

        private void btnlast7_Click(object sender, EventArgs e)
        {
            DateTime endDate = DateTime.Today;
            DateTime startDate = endDate.AddDays(-6);

            DateStart.Value = startDate;
            DateEnd.Value = endDate;

            alltime = false;
            string s = txtsearch.Text; txtsearch.Text = "1"; txtsearch.Text = s;

        }
 
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (combosearch.SelectedIndex != -1 && txtsearch.Text == "") return;
           
            else if (combosearch.SelectedIndex == -1)
            {
                if (alltime == true) btnrefresh.PerformClick();
                else
                {
                    DateTime startDate = DateStart.Value;
                    DateTime endDate = DateEnd.Value;

                    bindingSource.Filter = $"day >= #{startDate}# AND day <= #{endDate}#";
                }
            }
            else if (combosearch.SelectedIndex == 0)
            {
                try
                {
                    int id = Convert.ToInt32(txtsearch.Text);
                    if (alltime == true)
                        bindingSource.Filter = $"id = {id}";
                    else
                    {
                        DateTime startDate = DateStart.Value;
                        DateTime endDate = DateEnd.Value;

                        bindingSource.Filter = $"id = {id} AND (day >= #{startDate}# AND day <= #{endDate}#)";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter a number");
                }
            }
            else if (combosearch.SelectedIndex == 1)
            {
                string courseName = txtsearch.Text;
                if (alltime == true)
                    bindingSource.Filter = $"student LIKE '%{courseName}%'";
                else
                {
                    DateTime startDate = DateStart.Value;
                    DateTime endDate = DateEnd.Value;
                    bindingSource.Filter = $"student LIKE '%{courseName}%' AND day >= #{startDate}# AND day <= #{endDate}#";
                }
            }
            else if (combosearch.SelectedIndex == 2)
            {
                string courseName = txtsearch.Text;
                if (alltime == true)
                    bindingSource.Filter = $"course LIKE '%{courseName}%'";
                else
                {
                    DateTime startDate = DateStart.Value;
                    DateTime endDate = DateEnd.Value;
                    bindingSource.Filter = $"course LIKE '%{courseName}%' AND day >= #{startDate}# AND day <= #{endDate}#";
                }
            }
            else if (combosearch.SelectedIndex == 3)
            {
                try
                {

                    decimal id = Convert.ToDecimal(txtsearch.Text);   
                    if (alltime == true)
                        bindingSource.Filter = $"price = {id}";
                    else
                    {
                        DateTime startDate = DateStart.Value;
                        DateTime endDate = DateEnd.Value;

                        bindingSource.Filter = $"price = {id} AND (day >= #{startDate}# AND day <= #{endDate}#)";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter a number");
                }
            }
            else if (combosearch.SelectedIndex == 4)
            {
                try
                {
                    decimal id = Convert.ToDecimal(txtsearch.Text);
                    if (alltime == true)
                        bindingSource.Filter = $"paid = {id}";
                    else
                    {
                        DateTime startDate = DateStart.Value;
                        DateTime endDate = DateEnd.Value;

                        bindingSource.Filter = $"paid = {id} AND (day >= #{startDate}# AND day <= #{endDate}#)";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter a number");
                }
            }
            else if (combosearch.SelectedIndex == 5)
            {
                try
                {
                    decimal id = Convert.ToDecimal(txtsearch.Text);
                    if (alltime == true)
                        bindingSource.Filter = $"still = {id}";
                    else
                    {
                        DateTime startDate = DateStart.Value;
                        DateTime endDate = DateEnd.Value;

                        bindingSource.Filter = $"still = {id} AND (day >= #{startDate}# AND day <= #{endDate}#)";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter a number");
                }
            }
        }

        private void btnlastmon_Click(object sender, EventArgs e)
        {
            DateTime endDate = DateTime.Today;
            DateTime startDate = endDate.AddMonths(-1).AddDays(1);

            DateStart.Value = startDate;
            DateEnd.Value = endDate;

            alltime = false;
            string s = txtsearch.Text; txtsearch.Text = "1"; txtsearch.Text = s;

        }

        private void txtpaid_TextChanged(object sender, EventArgs e)
        {
            if (txtpaid.Text == "") {txtstill.Text = ""; return; }
            try {
                string x = "";
                if (exit == -1)
                 x = lbpaid.Text.Substring(16);
                else
                    x = lbtotal.Text.Substring(12);
                decimal pay = decimal.Parse(txtpaid.Text.ToString());
                decimal result = decimal.Parse(x) - pay ;
                if (result < 0 || pay <0) {
                    MessageBox.Show("alot of money");
                    txtstill.Text = ""; txtpaid.Text = "";
                    return;
                }

                txtstill.Text = result.ToString()    ;
            } catch (Exception ex) {
                MessageBox.Show("enter a number");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                 if (e.ColumnIndex == dataGridView2.Columns["DeleteButtonColumn"].Index)
                {
                    // Delete button clicked
                    HandleDeleteButton(e.RowIndex , e.ColumnIndex);
                }
            }
        }
        private void HandleDeleteButton(int row , int col)
        {
            // Confirm if the user wants to delete the record
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int id = -1;
                object cellValue = dataGridView2.Rows[row].Cells[dataGridView2.Columns["id"].Index].Value;
                if (cellValue != null)
                     id = (int)cellValue;

                Base.ServerSendDataTable($"DELETE FROM payments WHERE id = '{id}'", new SqlParameter[0]);
                // Remove the row from the DataGridView
                dataGridView2.Rows.RemoveAt(row);
            }
            dtenroll = Base.ServerGetDataTable(view, new System.Data.SqlClient.SqlParameter[0]);
            bindingSource.DataSource = dtenroll;
            dataGridView1.Refresh();
        }

        private void txtstill_TextChanged(object sender, EventArgs e)
        {

        }

        private void combocource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combocource.SelectedIndex != -1)
            {
                lbtotal.Text = "";
                txtstill.Text = "";
                txtpaid.Text = "";
                lbpaid.Text = "course price : \n";
                string selectedItemText = combocource.GetItemText(combocource.SelectedItem).Split(new string[] { " :   " }, StringSplitOptions.None)[0].Trim();
                foreach (DataRow Row in dtcourse.Rows)
                {
                    if (Row[0].ToString() == selectedItemText)
                    {
                        lbpaid.Text = "course price : \n" + Row[1].ToString();
                        course_id = int.Parse(Row[0].ToString());
                    }

                }
                if (combocource.SelectedIndex != -1)
                {
                    exit = Base.Servergetid($"SELECT id FROM stud_enroll WHERE stud_id = '{stud_id}' AND course_id = '{course_id}';", new SqlParameter[0], "");
                    if (exit != -1)
                    {
                        Total_paid = Base.Servergetdec($"SELECT paid_price FROM stud_enroll WHERE stud_id = '{stud_id}' AND course_id = '{course_id}';", new SqlParameter[0]);
                        Total_still = Base.Servergetdec($"SELECT still FROM stud_enroll WHERE stud_id = '{stud_id}' AND course_id = '{course_id}';", new SqlParameter[0]);
                        lbtotal.Text = $"Paid price : \n{Total_still}";
                    }
                }

            }
        }

        private void combostudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combostudent.SelectedIndex != -1)
            {
                lbtotal.Text = "";
                txtstill.Text = "";
                txtpaid.Text = "";
                lbpaid.Text = "course price : \n";
                stud_id = int.Parse(combostudent.GetItemText(combostudent.SelectedItem).Split(new string[] { " :   " }, StringSplitOptions.None)[0].Trim());
                if (combocource.SelectedIndex != -1)
                {
                    exit = Base.Servergetid($"SELECT id FROM stud_enroll WHERE stud_id = '{stud_id}' AND course_id = '{course_id}';", new SqlParameter[0], "");
                    if (exit != -1)
                    {
                        Total_paid = Base.Servergetdec($"SELECT paid_price FROM stud_enroll WHERE stud_id = '{stud_id}' AND course_id = '{course_id}';", new SqlParameter[0]);
                        Total_still = Base.Servergetdec($"SELECT still FROM stud_enroll WHERE stud_id = '{stud_id}' AND course_id = '{course_id}';", new SqlParameter[0]);
                        lbtotal.Text = $"Paid price:\n{Total_still}";
                    }
                }
            }

        }

        private void btnthismon_Click(object sender, EventArgs e)
        {
            int daysInMonth = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            DateTime startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime endDate = startDate.AddDays(daysInMonth - 1);

            DateStart.Value = startDate;
            DateEnd.Value = endDate;

            alltime = false;
            string s = txtsearch.Text; txtsearch.Text = "1"; txtsearch.Text = s;

        }

    }

}
