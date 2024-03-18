using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_enrolled.forms.attendance
{
    public partial class attendancemain : Form
    {
        public DataTable attend;
        DataBase Base = new DataBase();
        bool alltime = true;
        private BindingSource bindingSource = new BindingSource();

        private string querry = @"SELECT
    a.id ,
    a.course_id,
    c.name,
    a.students,
    a.attended,
    a.absent,
    a.date

FROM
    attendance a
INNER JOIN
    courses c ON a.course_id = c.id;";
        public attendancemain()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource;
            attend = Base.ServerGetDataTable(querry, new System.Data.SqlClient.SqlParameter[0]);
            bindingSource.DataSource = attend;
            DataGridView_Buttons();
            fillcombobox();
        }
        private void openChildFormInPanel(int courseid, int att)
        {
            attendancefields field  = new attendancefields(courseid, att);
            field.customclose += customclose;
            this.panelmain.Visible = false;
            field.TopLevel = false;
            field.FormBorderStyle = FormBorderStyle.None;
            field.Dock = DockStyle.Fill;
            this.Controls.Add(field);
            field.BringToFront();
            field.Show();
            field.Focus();
        }

        private void customclose()
        {
            this.panelmain.Visible = true;

        }
        private void DataGridView_Buttons()
        {
            dataGridView1.Columns["date"].DefaultCellStyle.Format = "HH:mm tt dd/MM/yyyy";
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
            dataGridView1.Columns["course_id"].Visible = false;

        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Edit" or "Delete" button column
            if ((e.ColumnIndex == dataGridView1.Columns["EditButtonColumn"].Index || e.ColumnIndex == dataGridView1.Columns["DeleteButtonColumn"].Index) && e.RowIndex >= 0)
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
            // Edit logic goes here
            // Similar to the previous example, you can open an edit form or perform editing actions
            openChildFormInPanel((int)attend.Rows[rowIndex]["course_id"], (int)attend.Rows[rowIndex]["id"]);
        }

        private void HandleDeleteButtonClick(int rowIndex)
        {
            // Confirm if the user wants to delete the record
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Perform the delete action here
                int id = (int)attend.Rows[rowIndex]["id"];

                Base.ServerSendDataTable($"DELETE FROM attendance WHERE id = '{id}'",new SqlParameter[0]);
                // Remove the row from the DataGridView
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
        }


        bool SidebarExpand = true;
        private void timeradd_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                tableLayoutPanel1.Visible = true;
                btnadd.Text = "Cancel";
                paneladd.Width += 150;
                if (paneladd.Width >= paneladd.MaximumSize.Width)
                {
                    SidebarExpand = false;
                    timeradd.Stop();
                }

            }
            else
            {
                btnadd.Text = "Add";
                paneladd.Width -= 150;
                if (paneladd.Width <= paneladd.MinimumSize.Width)
                {
                    tableLayoutPanel1.Visible = false;
                    SidebarExpand = true;
                    timeradd.Stop();
                }

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            timeradd.Start();
            coursebox.SelectedIndex = -1;
        }
        private void fillcombobox()
        {
            DataTable coursename = Base.ServerGetDataTable("select id , name from courses", new System.Data.SqlClient.SqlParameter[0]);
            foreach (DataRow row in coursename.Rows)
            {
                if (row[0] != DBNull.Value && row[0] != null)
                {
                    string name = row[0].ToString() + " :   " + row[1].ToString();
                    coursebox.Items.Add(name);
                }
            }
        }

        private void btnmake_Click(object sender, EventArgs e)
        {
            if (coursebox.SelectedIndex == -1)
            {
                return;
            }
            new DataBase();
            int courseid = int.Parse(coursebox.GetItemText(coursebox.SelectedItem).Split(new string[] { " :   " }, StringSplitOptions.None)[0].Trim());
            DateTime attendanceDate = DateTime.Now;

            int students = int.Parse(Base.ServerGetDataTable($"SELECT COUNT(*) AS total_enrollments FROM [dbo].[stud_enroll] WHERE [course_id] =  '{courseid}'", new SqlParameter[0]).Rows[0][0].ToString());
            string query = "INSERT INTO attendance (course_id, date, students, attended, absent) OUTPUT INSERTED.ID VALUES (@course_id, @date, @total_students, @total_attended, @total_absent);";
           SqlParameter[]  parameters = new SqlParameter[]
            {
                new SqlParameter("@course_id", SqlDbType.Int) { Value = courseid },
                new SqlParameter("@date", SqlDbType.DateTime) { Value = attendanceDate },
                new SqlParameter("@total_students", SqlDbType.Int) { Value = students }, 
                new SqlParameter("@total_attended", SqlDbType.Int) { Value = 0 },
                new SqlParameter("@total_absent", SqlDbType.Int) { Value = 0 }      
            };
         int attid =  Base.Servergetid(query, parameters , "id");
            string procedureQuery = "EXEC InsertAttendanceForCourse @course_id, @attendid";
            SqlParameter[] procedureParameters = new SqlParameter[]
            {
            new SqlParameter("@course_id", SqlDbType.Int) { Value = courseid },
            new SqlParameter("@attendid", SqlDbType.Int) { Value = attid }
            };
            Base.ServerSendDataTable(procedureQuery, procedureParameters);
            coursebox.SelectedIndex = -1;
            openChildFormInPanel(courseid, attid);
            attend = Base.ServerGetDataTable(querry, new System.Data.SqlClient.SqlParameter[0]);
            bindingSource.DataSource = attend;
            dataGridView1.Refresh();
        }
        private void btnenter(object sender, EventArgs e)
        {
            Button btnadd = null;
            btnadd = (Button)sender;
            btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));

        }
        private void btngo(object sender, EventArgs e)
        {
            Button btnadd = null;

            btnadd = (Button)sender;
            btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));

        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (combosearch.SelectedIndex != -1 && txtsearch.Text == "") return;

            if (combosearch.SelectedIndex == -1)
            {
                if (alltime == true) btnrefresh.PerformClick();
                else
                {
                    DateTime startDate = DateStart.Value;
                    DateTime endDate = DateEnd.Value;

                    bindingSource.Filter = $"Date >= #{startDate}# AND Date <= #{endDate}#";
                }
            }

            if (combosearch.SelectedIndex == 0)
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

                        bindingSource.Filter = $"id = {id} AND (Date >= #{startDate}# AND Date <= #{endDate}#)";
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
                    bindingSource.Filter = $"name LIKE '%{courseName}%' AND Date >= #{startDate}# AND Date <= #{endDate}#";
                }
            }
        }

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

        private void btnlastmon_Click(object sender, EventArgs e)
        {
            DateTime endDate = DateTime.Today;
            DateTime startDate = endDate.AddMonths(-1).AddDays(1);

            DateStart.Value = startDate;
            DateEnd.Value = endDate;

            alltime = false;
            string s = txtsearch.Text ; txtsearch.Text = "1"; txtsearch.Text = s;

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
