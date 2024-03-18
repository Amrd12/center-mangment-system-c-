using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace student_enrolled.forms
{
    public partial class login : Form
    {
        public int role;
        public string name;
        DataBase DataBase = new DataBase();
        public login()
        {
            InitializeComponent();
                  

          }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpass.UseSystemPasswordChar) { txtpass.UseSystemPasswordChar = false; }
            else txtpass.UseSystemPasswordChar = true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            SqlParameter[] parameters = new SqlParameter[]
 {
                new SqlParameter("@user", SqlDbType.NVarChar) { Value = user },
                new SqlParameter("@pass", SqlDbType.NVarChar) { Value = pass },

 };
         DataTable usertable =    DataBase.ServerGetDataTable("SELECT role,name From Accounts where username=@user And pass = @pass;", parameters);
            if (usertable.Rows.Count== 1)
            {
               DataRow rowuser = usertable.Rows[0];
                name = rowuser["name"].ToString();
                role = int.Parse(rowuser["role"].ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Wroung user or password");
                return;
            }


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void btnface_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100092763707845");

        }

        private void btnmail_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("futureacademy104@gmail.com");
            MessageBox.Show("mail coppied");

        }


        private void btnphone_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("+201020476642");
            System.Diagnostics.Process.Start("https://wa.me/+201020476642");

        }

        private void btngit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Amrd12");

        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            this.close.BackColor = Color.Transparent;


        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

        }

        private void login_Load(object sender, EventArgs e)
        {
            if (!File.Exists("studentEnroll.mdf") )
            {
                if (File.Exists("CreateDataBase.exe"))
                {
                    MessageBox.Show("wait");
                    Process start = new Process();
                    start.StartInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "CreateDataBase.exe");
                    start.StartInfo.Verb = "runas"; // This will run the process as an administrator
                    start.Start();
                    start.WaitForExit();
                    File.Delete("CreateDataBase.exe");
                }
                else
                {
                    MessageBox.Show("Please Contant Future Agency For registion");
                    Environment.Exit(0);
                }
            }
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            signup sign = new signup();
            this.Hide();
            sign.ShowDialog();
            this.Show();
        }
    }
}
