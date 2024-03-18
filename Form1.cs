using student_enrolled.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Security.Policy;
using System.Data.SqlClient;
using student_enrolled.forms.attendance;

namespace student_enrolled
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        private Button activebtn = null;
        public int role;
        public string name;
        DataTable dtrole;

        bool courseexcel, studentexcel, enrollexcel;

        public Form1()
        {
            login log = new login();
            log.ShowDialog();
            this.name = log.name;
            this.role= log.role;// the id of the accounts table (role id)
            if(this.name==null || this.role ==null)
            {
                Environment.Exit(0 );
            }
            Thread trd = new Thread(new ThreadStart(formrun));
            trd.Start();
            InitializeComponent();
           // new DatabaseManager().Main();
            formlogin();
            trd.Abort();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void formlogin()
        {
             dtrole = new DataBase().ServerGetDataTable("SELECT * FROM role WHERE Id = @id",
    new System.Data.SqlClient.SqlParameter[] {
                new SqlParameter("@id", SqlDbType.Int ) { Value = role },
    });//gets the table 

            if (dtrole.Rows.Count > 0)
            {
                DataRow row = dtrole.Rows[0];

                string coursesAccess = row["courses"].ToString();
                string enrollsAccess = row["enrolls"].ToString();
                string studentsAccess = row["students"].ToString();

                // Assuming you have buttons btnDashboard, btnCourses, etc. on the form
                panelhome.Visible = row["dashboard"].ToString() == "yes";
                panelcourse.Visible = coursesAccess.Split(' ')[0] == "yes";
                panelenrolling.Visible = enrollsAccess.Split(' ')[0] == "yes";
                panelstudents.Visible = studentsAccess.Split(' ')[0] == "yes";
                panelaccounts.Visible = row["accounts"].ToString() == "yes";
                panelroles.Visible = row["roles"].ToString() == "yes";
                // this.Text = "Welcome, " + row["name"].ToString() + "!";
                courseexcel = coursesAccess.Split(' ')[1] == "yes";
                enrollexcel = enrollsAccess.Split(' ')[1] == "yes";
                studentexcel = studentsAccess.Split(' ')[1] == "yes";
                lbname.Text = "welcome:     " + name;
            }
            else
            {
                MessageBox.Show("Role ID not found.");
                close.PerformClick();
            }

        }
    
        private void formrun()
        {
           
                Application.Run(new splash());//run a splash screen

        }

        private void openChildFormInPanel(Form childForm, Panel panelform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelform.Controls.Add(childForm);
            panelform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.Focus();
        }
        private void ActiveBtn(object btnsender)
        {
            CloseBtn();
            activebtn = (Button)btnsender;
            activebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));// System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            activebtn.ForeColor = System.Drawing.SystemColors.Control;
            btnclosepanel.Visible = true;

        }
        private void CloseBtn()
        {
            if (activebtn != null)
            {
                foreach (Control panel in panel2.Controls)
                {
                    if (panel.GetType() == typeof(Panel))
                    {
                        foreach (Control btn1 in ((Panel)panel).Controls)
                        {
                            btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
                            btn1.ForeColor = System.Drawing.SystemColors.Control;
                        }
                    }
                }
                activebtn = null;
                btnclosepanel.Visible = false;

            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnhome_Click(object sender, EventArgs e)
        {

            CloseBtn();
            home home = new home();
            openChildFormInPanel(home, panelmain);
            ActiveBtn(btnhome);


        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            students st = new students();
            st.excel = studentexcel;
            openChildFormInPanel(st, panelmain);
            ActiveBtn(sender);
        }

        private void btnenroll_Click(object sender, EventArgs e)
        {
            enroll enroll = new enroll();
            enroll.excel = enrollexcel;
            openChildFormInPanel(enroll, panelmain); ActiveBtn(sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            coursse courses = new coursse();
            courses.excel = courseexcel;
            openChildFormInPanel(courses, panelmain); ActiveBtn(sender);

        }
        private void btnaccounts_Click(object sender, EventArgs e)
        {
            accounts acc = new accounts();
            openChildFormInPanel(acc, panelmain); ActiveBtn(sender);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            roles rol = new roles();
            openChildFormInPanel(rol, panelmain); ActiveBtn(sender);

        }
        private void btnaddent_Click(object sender, EventArgs e)
        {
            attendancemain attendancemain = new attendancemain();
            openChildFormInPanel(attendancemain, panelmain); ActiveBtn(sender);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); 
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void Maxmize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //  Activate();
            this.Show();
           

        }
   


        private void close_MouseLeave(object sender, EventArgs e)
        {
            this.close.BackColor = Color.Transparent;


        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor =Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Escape) { CloseBtn(); if (activeForm != null)
                    activeForm.Close();
            }
            if (e.Control && e.KeyCode == Keys.H) btnhome.PerformClick();
            if (e.Control && e.KeyCode == Keys.S) btnstudents.PerformClick();
            if (e.Control && e.KeyCode == Keys.C ) btncourses.PerformClick();
            if (e.Control && e.KeyCode == Keys.E) btnenroll.PerformClick();
            if (e.Control && e.KeyCode == Keys.A) btnaccounts.PerformClick();
            if (e.Control && e.KeyCode == Keys.R) btnrole.PerformClick();
        }

        bool SidebarExpand = true;

        private void slidetimer_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                panel2.Width -= 30;
                pictureBox1.Height -= 30;
                panelcon.Height += 30;
                lbcontcat.Visible = false;

                if (panel2.Width <= panel2.MinimumSize.Width && pictureBox1.Height <= pictureBox1.MinimumSize.Height && panelcon.Height<=panelcon.MaximumSize.Height)
                {
                    foreach (Button btn in panelcon.Controls.OfType<Button>()) { 
                        btn.Dock= DockStyle.Top; btn.Height = 29;
                    }
  

                    SidebarExpand = false;
                    slidetimer.Stop();
                }

            }
            else
            {
                panel2.Width += 30;
                pictureBox1.Height += 30;
                panelcon.Height-= 30;
                lbcontcat.Visible = true;

                if (panel2.Width >= panel2.MaximumSize.Width && pictureBox1.Height >= pictureBox1.MaximumSize.Height && panelcon.Height <= panelcon.MinimumSize.Height)
                {
                    foreach (Button btn in panelcon.Controls.OfType<Button>()) {
                        btn.Dock = DockStyle.Left; btn.Width = 25;
                    }

               
                    SidebarExpand = true;
                    slidetimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            slidetimer.Start();
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

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.ShowDialog();
            this.name = log.name;
            this.role = log.role;// the id of the accounts table (role id)
            formlogin();
            CloseBtn();
            if (activeForm != null)
                activeForm.Close();
            this.Show();
        }

        private void btnclosepanel_Click(object sender, EventArgs e)
        {
            CloseBtn();
            if (activeForm != null)
                activeForm.Close();
        }



        private void btnphone_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("+201020476642");
            System.Diagnostics.Process.Start("https://wa.me/+201020476642");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Amrd12");

        }
    }
}
