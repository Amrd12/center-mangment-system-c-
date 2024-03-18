using DocumentFormat.OpenXml.Spreadsheet;
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
using student_enrolled;
namespace student_enrolled.forms
{
    public partial class students : Form
    {
        DataBase Base = new DataBase();
        DataTable dtstudent;
        string name, phone , email;
        int stud_id;
        public bool excel;
        private BindingSource bindingSource = new BindingSource();

        public students()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource;
            dtstudent = Base.ServerGetDataTable("select * from students", new System.Data.SqlClient.SqlParameter[0]);
            bindingSource.DataSource = dtstudent;
            btnload.Visible = excel;
            btnsave.Visible = excel;
            DataGridView_Buttons();
        }
        private void openChildFormInPanel(int id)
        {
            student field = new student(id);
          
            field.cusomclose += customclosein;
            this.panelmain.Visible = false;
            field.TopLevel = false;
            field.FormBorderStyle = FormBorderStyle.None;
            field.Dock = DockStyle.Fill;
            this.Controls.Add(field);
            field.BringToFront();
            field.Show();
            field.Focus();
        }

        private void customclosein()  
        {
            this.panelmain.Visible = true;
            dtstudent = Base.ServerGetDataTable("select * from students", new System.Data.SqlClient.SqlParameter[0]);
            bindingSource.DataSource = dtstudent;
            dataGridView1.Refresh();

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if ( e.RowIndex >= 0)
            {
                // Handle the button click for the selected row
                if (e.ColumnIndex == dataGridView1.Columns["EditButtonColumn"].Index)
                {
                    // Edit button clicked
                    HandleEditButtonClick(e.RowIndex);
                }
                else if (e.ColumnIndex == dataGridView1.Columns["DeleteButtonColumn"].Index)
                {
                    // Delete button clicked
                    HandleDeleteButtonClick(e.RowIndex);
                }
            }
        }
        private void HandleEditButtonClick(int rowIndex)
        {
            // Confirm if the user wants to delete the record

  
                // Perform the delete action here
                int id = (int)dtstudent.Rows[rowIndex]["id"];
            openChildFormInPanel(id);

        }
        private void HandleDeleteButtonClick(int rowIndex)
        {
            // Confirm if the user wants to delete the record
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Perform the delete action here
                int id = (int)dtstudent.Rows[rowIndex]["id"];

                Base.ServerSendDataTable($"DELETE FROM students WHERE id = '{id}'", new SqlParameter[0]);
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
            excelWriter.WriteToExcel(sfd.FileName, dtstudent);
            MessageBox.Show("done");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txtstudent.Text == "" || txtphone.Text == "" || txtemail.Text =="")
            {
                MessageBox.Show("Please Fill All fields");
                return;
            }
                
            name = txtstudent.Text;
             phone = txtphone.Text;
             email= txtemail.Text;
            
            string query = "INSERT INTO students (name, phone , email,day) VALUES (@name, @phone , @email,@day );";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = name },
                new SqlParameter("@phone", SqlDbType.VarChar) { Value = phone },
                new SqlParameter("@email", SqlDbType.VarChar) { Value = email },
                new SqlParameter("@day", SqlDbType.DateTime) { Value = DateTime.Now }


            };

            Base.ServerSendDataTable(query, parameters);
            dtstudent = Base.ServerGetDataTable("select * from students", new System.Data.SqlClient.SqlParameter[0]);
            bindingSource.DataSource = dtstudent;
            dataGridView1.Refresh();
            txtstudent.Text = ""; txtphone.Text = ""; txtemail.Text = "";
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            Exceltodb ex = new Exceltodb();
            ex.tablename = "students";
            ex.ShowDialog();

        }

        private void students_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.C) MessageBox.Show("students");
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
            btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));

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
                    bindingSource.Filter = $"name LIKE '%{courseName}%'";
                else
                {
                    DateTime startDate = DateStart.Value;
                    DateTime endDate = DateEnd.Value;
                    bindingSource.Filter = $"name LIKE '%{courseName}%' AND day >= #{startDate}# AND day <= #{endDate}#";
                }
            }
            else if (combosearch.SelectedIndex == 1)
            {
                string courseName = txtsearch.Text;
                if (alltime == true)
                    bindingSource.Filter = $"phone LIKE '%{courseName}%'";
                else
                {
                    DateTime startDate = DateStart.Value;
                    DateTime endDate = DateEnd.Value;
                    bindingSource.Filter = $"phone LIKE '%{courseName}%' AND day >= #{startDate}# day day <= #{endDate}#";
                }
            }
            else if (combosearch.SelectedIndex == 1)
            {
                string courseName = txtsearch.Text;
                if (alltime == true)
                    bindingSource.Filter = $"email LIKE '%{courseName}%'";
                else
                {
                    DateTime startDate = DateStart.Value;
                    DateTime endDate = DateEnd.Value;
                    bindingSource.Filter = $"email LIKE '%{courseName}%' AND day >= #{startDate}# AND day <= #{endDate}#";
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
