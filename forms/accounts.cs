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
    public partial class accounts : Form
    {
        DataBase Base = new DataBase();
        DataTable dtaccounts;
        string name, user , pass;
        int role;

        public accounts()
        {
            InitializeComponent();
            dtaccounts = Base.ServerGetDataTable("select * from accounts", new System.Data.SqlClient.SqlParameter[0]);
            dataGridView1.DataSource = dtaccounts;

            dataGridView1.Refresh();
            fillcombo();
        }

        private void fillcombo()
        {
           DataTable dt =  Base.ServerGetDataTable("select id,name From role",new SqlParameter[0]);
            foreach (DataRow dr in dt.Rows)
            {
                comborole.Items.Add(dr["id"].ToString()+" : " + dr["name"].ToString() );
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            if (selectedRow == null) return;

            // Access the row information using the Cells property
            txtID.Text  =   selectedRow.Cells[0].Value.ToString();
            txtname.Text = selectedRow.Cells[1].Value.ToString();
            txtuser.Text = selectedRow.Cells[2].Value.ToString();
            txtpass.Text = selectedRow.Cells[3].Value.ToString();
            role = int.Parse(selectedRow.Cells[4].Value.ToString());

            foreach (string item in comborole.Items)
            {
                if (item.Contains(role.ToString()))
                {
                    comborole.SelectedItem = item;
                    break;
                }
            }
        }
        private void comborole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comborole.SelectedIndex != -1)
            {
                role = int.Parse(comborole.GetItemText(comborole.SelectedItem).Split(new string[] { " : " }, StringSplitOptions.None)[0].Trim());
            }
        }
        private void btnup_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtuser.Text == "" || txtpass.Text == "" || txtID.Text == ""|| comborole.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select from the Table");
                return;
            }
            int id = int.Parse(txtID.Text);
            name = txtname.Text;
            user = txtuser.Text;
            pass = txtpass.Text;
            string query = "UPDATE accounts SET name = @name , username = @user, pass=@pass, role=@role WHERE id = @id;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int ) { Value = id },
                new SqlParameter("@role", SqlDbType.Int ) { Value = role },
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = name },
                new SqlParameter("@user", SqlDbType.VarChar) { Value = user },
                new SqlParameter("@pass", SqlDbType.VarChar) { Value = pass }

            };

            Base.ServerSendDataTable(query, parameters);
            dtaccounts = Base.ServerGetDataTable("select * from accounts", new System.Data.SqlClient.SqlParameter[0]);
            dataGridView1.DataSource = dtaccounts;
            dataGridView1.Refresh();
            txtname.Text = ""; txtuser.Text = ""; txtpass.Text = ""; txtID.Text = ""; comborole.SelectedIndex = -1;
        }




        private void courses_Load(object sender, EventArgs e)
        {

        }

        private void btnre_Click(object sender, EventArgs e)
        {
            txtname.Text = ""; txtuser.Text = ""; txtpass.Text = ""; txtID.Text = ""; comborole.SelectedIndex = 0;
            txtID.Text = "";
            dtaccounts = Base.ServerGetDataTable("select * from accounts", new System.Data.SqlClient.SqlParameter[0]);
            dataGridView1.DataSource = dtaccounts;
            dataGridView1.Refresh();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtuser.Text == "" || txtpass.Text == "" || txtID.Text == "" || comborole.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select from the Table");
                return;
            }
            int id = int.Parse(txtID.Text);
            name = txtname.Text;
            user = txtuser.Text;
            pass = txtpass.Text;
            string query = "Delete from accounts where name = @name and username = @user and pass=@pass and id = @id;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", SqlDbType.Int ) { Value = id },
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = name },
                new SqlParameter("@user", SqlDbType.VarChar) { Value = user },
                new SqlParameter("@pass", SqlDbType.VarChar) { Value = pass }


            };

            Base.ServerSendDataTable(query, parameters);
            dtaccounts = Base.ServerGetDataTable("select * from accounts", new System.Data.SqlClient.SqlParameter[0]);
            dataGridView1.DataSource = dtaccounts;
            dataGridView1.Refresh();
            txtname.Text = ""; txtuser.Text = ""; txtpass.Text = ""; txtID.Text = ""; comborole.SelectedIndex = -1;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Where to save";
            sfd.FileName = "accounts";
            sfd.DefaultExt = ".xlsx";
            sfd.ShowDialog();
            var excelWriter = new ExcelWriter();
            excelWriter.WriteToExcel(sfd.FileName, dtaccounts);
            MessageBox.Show("done");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                txtID.Text = "";
                return;
            }
            if (txtname.Text == "" || txtuser.Text == "" || txtpass.Text =="" || comborole.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill All fields");
                return;
            }

            name = txtname.Text;
             user = txtuser.Text;
             pass = txtpass.Text;
            
            string query = "INSERT INTO accounts (name, username , pass,role) VALUES (@name, @user , @pass,@role );";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = name },
                new SqlParameter("@user", SqlDbType.NVarChar) { Value = user },
                new SqlParameter("@pass", SqlDbType.VarChar) { Value = pass },
                new SqlParameter("@role", SqlDbType.Int) { Value = role }


            };

            Base.ServerSendDataTable(query, parameters);
            dtaccounts = Base.ServerGetDataTable("select * from accounts", new System.Data.SqlClient.SqlParameter[0]);
            dataGridView1.DataSource = dtaccounts;
            dataGridView1.Refresh();
            txtname.Text = ""; txtuser.Text = ""; txtpass.Text = ""; comborole.SelectedIndex = 0;
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" && txtname.Text == "" && txtuser.Text == "" && txtpass.Text == "" && comborole.SelectedIndex == -1)
            {
                MessageBox.Show("please any fields"); return;
            }
            if (txtID.Text != "")
            {
                int id = int.Parse(txtID.Text);
                string query = "select * from accounts where id like @id;";
                SqlParameter[] parameters = new SqlParameter[]
                {
                            new SqlParameter("@id", SqlDbType.Int ) { Value = id },
                    };
                    dtaccounts = Base.ServerGetDataTable(query, parameters);
                            dataGridView1.DataSource = dtaccounts;
                            dataGridView1.Refresh();
                            txtID.Text = "";
                return;

            }
            if (txtname.Text != "")
                        {
                            name = txtname.Text;
                            string query = "select * from acounts where name like @name;";
                SqlParameter[] parameters = new SqlParameter[]
                {
                            new SqlParameter("@name", SqlDbType.NVarChar) { Value = name },
                };
                dtaccounts = Base.ServerGetDataTable(query, parameters);
                            dataGridView1.DataSource = dtaccounts;
                            dataGridView1.Refresh();
                            txtname.Text = ""; return;

            }
            if (txtuser.Text != "" )
            {
                user = txtname.Text;
                string query = "select * from accounts where user like @user;";
                SqlParameter[] parameters = new SqlParameter[]
                {
        new SqlParameter("@user", SqlDbType.VarChar) { Value = user },
                };
                dtaccounts = Base.ServerGetDataTable(query, parameters);
                dataGridView1.DataSource = dtaccounts;
                dataGridView1.Refresh();
                txtuser.Text = ""; 
                return;

            }
            if (comborole.SelectedIndex != -1)
            {
                string query = "select * from accounts where role like @role;";
                SqlParameter[] parameters = new SqlParameter[]
                {
        new SqlParameter("@role", SqlDbType.VarChar) { Value = role },
                };
                dtaccounts = Base.ServerGetDataTable(query, parameters);
                dataGridView1.DataSource = dtaccounts;
                dataGridView1.Refresh();
                comborole.SelectedIndex= -1;
                return;

            }


        }

        private void btnload_Click(object sender, EventArgs e)
        {
            Exceltodb ex = new Exceltodb();
            ex.tablename = "students";
            ex.ShowDialog();
            btnre.PerformClick();

        }

        private void students_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.C) MessageBox.Show("students");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpass.UseSystemPasswordChar) { txtpass.UseSystemPasswordChar = false; }
            else txtpass.UseSystemPasswordChar = true;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
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


    }

}
