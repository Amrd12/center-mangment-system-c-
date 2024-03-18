using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using student_enrolled.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace student_enrolled.forms
{
    public partial class roles : Form
    {
        DataBase Base = new DataBase();
        DataTable dtrole;
        string name, dashboard="no",courses= "no", corexcel = "no", enrolls = "no", enrolsexcel = "no", students = "no", studexcel = "no", accounts = "no", role = "no";
        int id;

        public roles()
        {
            InitializeComponent();
            dtrole = Base.ServerGetDataTable("select * from role", new System.Data.SqlClient.SqlParameter[0]);
            dataGridView1.DataSource = dtrole;
            dataGridView1.Refresh();
        }
        private void ActiveBtn(object btnsender)
        {
            Button activebtn = (Button)btnsender;
            activebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            activebtn.ForeColor = System.Drawing.Color.White;
        }
        private void closebtn(object btnsender)
        {
            Button activebtn = (Button)btnsender;
            activebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            activebtn.ForeColor = System.Drawing.Color.White;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells["Id"].Value);
                name = row.Cells["name"].Value.ToString();
                dashboard = row.Cells["dashboard"].Value.ToString();
                courses = row.Cells["courses"].Value.ToString().Split(' ')[0]; // Extract courses from "yes yes"
                corexcel = row.Cells["courses"].Value.ToString().Split(' ')[1]; // Extract corexcel from "yes yes"
                enrolls = row.Cells["enrolls"].Value.ToString().Split(' ')[0]; // Extract enrolls from "yes yes"
                enrolsexcel = row.Cells["enrolls"].Value.ToString().Split(' ')[1]; // Extract enrolsexcel from "yes yes"
                students = row.Cells["students"].Value.ToString().Split(' ')[0]; // Extract students from "yes yes"
                studexcel = row.Cells["students"].Value.ToString().Split(' ')[1]; // Extract studexcel from "yes yes"
                accounts = row.Cells["accounts"].Value.ToString();
                role = row.Cells["roles"].Value.ToString();

                UpdateFormFields();
            }
        }
     








        private void btnup_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtID.Text== "")
            {
                MessageBox.Show("Please write a name or id");
                return;
            }
            id = int.Parse(txtID.Text);
            name = txtname.Text;
            string query = "UPDATE role SET name=@name ,dashboard=@dashboard , courses=@courses , enrolls=@enrolls,students=@students , accounts=@accounts , roles=@roles where Id=@id ;";
           SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = id },
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = name },
                new SqlParameter("@dashboard", SqlDbType.VarChar) { Value = dashboard },
                new SqlParameter("@courses", SqlDbType.VarChar) { Value = courses+" "+corexcel },
                new SqlParameter("@enrolls", SqlDbType.VarChar) { Value = enrolls+" "+enrolsexcel },
                new SqlParameter("@students", SqlDbType.VarChar) { Value = students+" "+studexcel },
                new SqlParameter("@accounts", SqlDbType.VarChar) { Value = accounts },
                new SqlParameter("@roles", SqlDbType.VarChar) { Value = role }


            };

            Base.ServerSendDataTable(query, parameters);
            dtrole = Base.ServerGetDataTable("select * from role", new System.Data.SqlClient.SqlParameter[0]);
            dataGridView1.DataSource = dtrole;
            txtname.Text = "";
        }



        //private void courses_Load(object sender, EventArgs e)
        //{

        //}



        private void btnre_Click(object sender, EventArgs e)
        {
            dashboard = "no"; courses = "no"; corexcel = "no"; enrolls = "no"; enrolsexcel = "no"; students = "no"; studexcel = "no"; accounts = "no"; role = "no";
            UpdateFormFields();
            dtrole = Base.ServerGetDataTable("select * from role", new System.Data.SqlClient.SqlParameter[0]);
            dataGridView1.DataSource = dtrole;
            dataGridView1.Refresh();

        }



        private void btndelete_Click(object sender, EventArgs e)
        {     
        if (txtname.Text == "" || txtID.Text== "")
            {
                MessageBox.Show("Please write a name or id");
                return;
            }
    id = int.Parse(txtID.Text);
    name = txtname.Text;
            string query = "DELETE FROM role WHERE name=@name AND Id=@id ;";
    SqlParameter[] parameters = new SqlParameter[]
    {
                new SqlParameter("@id", SqlDbType.Int) { Value = id },
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = name }
     };

    Base.ServerSendDataTable(query, parameters);
            dtrole = Base.ServerGetDataTable("select * from role", new System.Data.SqlClient.SqlParameter[0]);
            dataGridView1.DataSource = dtrole;
            txtname.Text = "";
        }



private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                txtID.Text = "";
                return;
            }
            if (txtname.Text == "")
            {
                MessageBox.Show("Please write a name");
                return;
            }

            name = txtname.Text;
            string query = "INSERT INTO role (name, dashboard , courses,enrolls,students,accounts,roles) " +
                "VALUES (@name, @dashboard , @courses,@enrolls,@students,@accounts,@roles );";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = name },
                new SqlParameter("@dashboard", SqlDbType.VarChar) { Value = dashboard },
                new SqlParameter("@courses", SqlDbType.VarChar) { Value = courses+" "+corexcel },
                new SqlParameter("@enrolls", SqlDbType.VarChar) { Value = enrolls+" "+enrolsexcel },
                new SqlParameter("@students", SqlDbType.VarChar) { Value = students+" "+studexcel },
                new SqlParameter("@accounts", SqlDbType.VarChar) { Value = accounts },
                new SqlParameter("@roles", SqlDbType.VarChar) { Value = role }


            };

            Base.ServerSendDataTable(query, parameters);
            dtrole = Base.ServerGetDataTable("select * from role", new System.Data.SqlClient.SqlParameter[0]);
            dataGridView1.DataSource = dtrole;
            txtname.Text = "";
        }



        //private void btnsearch_Click(object sender, EventArgs e)
        //{
        //    if (txtID.Text == "" && txtname.Text == "" && txtuser.Text == "" && txtpass.Text == "" && comborole.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("please any fields"); return;
        //    }
        //    if (txtID.Text != "")
        //    {
        //        int id = int.Parse(txtID.Text);
        //        string query = "select * from role where id like @id;";
        //        SqlParameter[] parameters = new SqlParameter[]
        //        {
        //                    new SqlParameter("@id", SqlDbType.Int ) { Value = id },
        //            };
        //            dtrole = Base.ServerGetDataTable(query, parameters);
        //                    dataGridView1.DataSource = dtrole;
        //                    dataGridView1.Refresh();
        //                    txtID.Text = "";
        //        return;

        //    }
        //    if (txtname.Text != "")
        //                {
        //                    name = txtname.Text;
        //                    string query = "select * from acounts where name like @name;";
        //        SqlParameter[] parameters = new SqlParameter[]
        //        {
        //                    new SqlParameter("@name", SqlDbType.NVarChar) { Value = name },
        //        };
        //        dtrole = Base.ServerGetDataTable(query, parameters);
        //                    dataGridView1.DataSource = dtrole;
        //                    dataGridView1.Refresh();
        //                    txtname.Text = ""; return;

        //    }
        //    if (txtuser.Text != "" )
        //    {
        //        user = txtname.Text;
        //        string query = "select * from accounts where user like @user;";
        //        SqlParameter[] parameters = new SqlParameter[]
        //        {
        //new SqlParameter("@user", SqlDbType.VarChar) { Value = user },
        //        };
        //        dtrole = Base.ServerGetDataTable(query, parameters);
        //        dataGridView1.DataSource = dtrole;
        //        dataGridView1.Refresh();
        //        txtuser.Text = ""; 
        //        return;

        //    }
        //    if (comborole.SelectedIndex != -1)
        //    {
        //        string query = "select * from accounts where role like @role;";
        //        SqlParameter[] parameters = new SqlParameter[]
        //        {
        //new SqlParameter("@role", SqlDbType.VarChar) { Value = role },
        //        };
        //        dtrole = Base.ServerGetDataTable(query, parameters);
        //        dataGridView1.DataSource = dtrole;
        //        dataGridView1.Refresh();
        //        comborole.SelectedIndex= -1;
        //        return;

        //    }


        //}








        private void students_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.C) MessageBox.Show("students");
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
        private void UpdateFormFields()
        {
            txtID.Text = id.ToString();
            txtname.Text = name;
            UpdateButtonColor(btndashboard, dashboard);
            UpdateButtonColor(btncourses, courses);
            UpdateButtonColor(btncourseexcel, corexcel);
            UpdateButtonColor(btnenroles, enrolls);
            UpdateButtonColor(btnenrollexcel, enrolsexcel);
            UpdateButtonColor(btnstudents, students);
            UpdateButtonColor(btnstudentsexcel, studexcel);
            UpdateButtonColor(btnaccounts, accounts);
            UpdateButtonColor(btnroles, role);

            btnenrollexcel.Visible = enrolls == "yes";
            if (!btnenrollexcel.Visible) enrolsexcel = "no";

            btnstudentsexcel.Visible = students == "yes";
            if (!btnstudentsexcel.Visible) studexcel = "no";

            btncourseexcel.Visible = courses == "yes";
            if (!btncourseexcel.Visible) corexcel = "no";

        }

        private void UpdateButtonColor(Button button, string value)
        {
            button.BackColor = value == "yes" ? System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16))))) : System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
        }

        private void ToggleValue(ref string value)
        {
            value = value == "yes" ? "no" : "yes";
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            ToggleValue(ref dashboard);
            UpdateButtonColor(btndashboard, dashboard);
        }

        private void btnaccounts_Click(object sender, EventArgs e)
        {
            ToggleValue(ref accounts);
            UpdateButtonColor(btnaccounts, accounts);
        }

        private void btnroles_Click(object sender, EventArgs e)
        {
            ToggleValue(ref role);
            UpdateButtonColor(btnroles, role);
        }

        private void btncourses_Click(object sender, EventArgs e)
        {
            ToggleValue(ref courses);
            UpdateButtonColor(btncourses, courses);
            btncourseexcel.Visible = courses == "yes";
            if (!btncourseexcel.Visible) corexcel = "no";
            UpdateButtonColor(btncourseexcel, corexcel);

        }

        private void btncourseexcel_Click(object sender, EventArgs e)
        {
            ToggleValue(ref corexcel);
            UpdateButtonColor(btncourseexcel, corexcel);
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            ToggleValue(ref students);
            UpdateButtonColor(btnstudents, students);
            btnstudentsexcel.Visible = students == "yes";
            if (!btnstudentsexcel.Visible) studexcel = "no";
            UpdateButtonColor(btnstudentsexcel, studexcel);

        }

        private void btnstudentsexcel_Click(object sender, EventArgs e)
        {
            ToggleValue(ref studexcel);
            UpdateButtonColor(btnstudentsexcel, studexcel);
        }

        private void btnenroles_Click(object sender, EventArgs e)
        {
            ToggleValue(ref enrolls);
            UpdateButtonColor(btnenroles, enrolls);
            btnenrollexcel.Visible = enrolls == "yes";
            if (!btnenrollexcel.Visible) enrolsexcel = "no";
            UpdateButtonColor(btnenrollexcel, enrolsexcel);

        }

        private void btnenrollexcel_Click(object sender, EventArgs e)
        {
            ToggleValue(ref enrolsexcel);
            UpdateButtonColor(btnenrollexcel, enrolsexcel);
        }
    }
}


