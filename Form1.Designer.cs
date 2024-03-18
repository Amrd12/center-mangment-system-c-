using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;
using System.Drawing;
using System.Windows.Forms;

namespace student_enrolled
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclosepanel = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.Maxmize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelattend = new System.Windows.Forms.Panel();
            this.btnaddent = new System.Windows.Forms.Button();
            this.panelroles = new System.Windows.Forms.Panel();
            this.btnrole = new System.Windows.Forms.Button();
            this.panelaccounts = new System.Windows.Forms.Panel();
            this.btnaccounts = new System.Windows.Forms.Button();
            this.lbcontcat = new System.Windows.Forms.Label();
            this.panelcon = new System.Windows.Forms.Panel();
            this.btngit = new System.Windows.Forms.Button();
            this.btnphone = new System.Windows.Forms.Button();
            this.btnmail = new System.Windows.Forms.Button();
            this.btnface = new System.Windows.Forms.Button();
            this.panelenrolling = new System.Windows.Forms.Panel();
            this.btnenroll = new System.Windows.Forms.Button();
            this.panelcourse = new System.Windows.Forms.Panel();
            this.btncourses = new System.Windows.Forms.Button();
            this.panelstudents = new System.Windows.Forms.Panel();
            this.btnstudents = new System.Windows.Forms.Button();
            this.panelhome = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelmain = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.slidetimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelattend.SuspendLayout();
            this.panelroles.SuspendLayout();
            this.panelaccounts.SuspendLayout();
            this.panelcon.SuspendLayout();
            this.panelenrolling.SuspendLayout();
            this.panelcourse.SuspendLayout();
            this.panelstudents.SuspendLayout();
            this.panelhome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnclosepanel);
            this.panel1.Controls.Add(this.lbname);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.Maxmize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 37);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Maxmize_Click);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnclosepanel
            // 
            this.btnclosepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnclosepanel.FlatAppearance.BorderSize = 0;
            this.btnclosepanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosepanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosepanel.ForeColor = System.Drawing.Color.White;
            this.btnclosepanel.Image = global::student_enrolled.Properties.Resources.Close;
            this.btnclosepanel.Location = new System.Drawing.Point(185, 0);
            this.btnclosepanel.Name = "btnclosepanel";
            this.btnclosepanel.Size = new System.Drawing.Size(42, 37);
            this.btnclosepanel.TabIndex = 14;
            this.btnclosepanel.UseVisualStyleBackColor = true;
            this.btnclosepanel.Visible = false;
            this.btnclosepanel.Click += new System.EventHandler(this.btnclosepanel_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbname.FlatAppearance.BorderSize = 0;
            this.lbname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.White;
            this.lbname.Location = new System.Drawing.Point(92, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(93, 37);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "label1";
            // 
            // btnlogout
            // 
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlogout.Location = new System.Drawing.Point(0, 0);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(92, 37);
            this.btnlogout.TabIndex = 10;
            this.btnlogout.Text = "logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // minimize
            // 
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Image = global::student_enrolled.Properties.Resources.MInmize;
            this.minimize.Location = new System.Drawing.Point(1123, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(27, 37);
            this.minimize.TabIndex = 11;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // Maxmize
            // 
            this.Maxmize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maxmize.FlatAppearance.BorderSize = 0;
            this.Maxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maxmize.Image = global::student_enrolled.Properties.Resources.maxmize;
            this.Maxmize.Location = new System.Drawing.Point(1150, 0);
            this.Maxmize.Name = "Maxmize";
            this.Maxmize.Size = new System.Drawing.Size(33, 37);
            this.Maxmize.TabIndex = 12;
            this.Maxmize.UseVisualStyleBackColor = false;
            this.Maxmize.Click += new System.EventHandler(this.Maxmize_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::student_enrolled.Properties.Resources.Close;
            this.close.Location = new System.Drawing.Point(1183, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 37);
            this.close.TabIndex = 13;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.panelattend);
            this.panel2.Controls.Add(this.panelroles);
            this.panel2.Controls.Add(this.panelaccounts);
            this.panel2.Controls.Add(this.lbcontcat);
            this.panel2.Controls.Add(this.panelcon);
            this.panel2.Controls.Add(this.panelenrolling);
            this.panel2.Controls.Add(this.panelcourse);
            this.panel2.Controls.Add(this.panelstudents);
            this.panel2.Controls.Add(this.panelhome);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.MaximumSize = new System.Drawing.Size(150, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(44, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 711);
            this.panel2.TabIndex = 0;
            // 
            // panelattend
            // 
            this.panelattend.Controls.Add(this.btnaddent);
            this.panelattend.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelattend.Location = new System.Drawing.Point(0, 535);
            this.panelattend.Name = "panelattend";
            this.panelattend.Size = new System.Drawing.Size(150, 75);
            this.panelattend.TabIndex = 11;
            // 
            // btnaddent
            // 
            this.btnaddent.FlatAppearance.BorderSize = 0;
            this.btnaddent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnaddent.Image = global::student_enrolled.Properties.Resources.attendance;
            this.btnaddent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddent.Location = new System.Drawing.Point(-3, 0);
            this.btnaddent.Margin = new System.Windows.Forms.Padding(5);
            this.btnaddent.Name = "btnaddent";
            this.btnaddent.Size = new System.Drawing.Size(153, 75);
            this.btnaddent.TabIndex = 5;
            this.btnaddent.Text = "       attendance";
            this.btnaddent.UseVisualStyleBackColor = true;
            this.btnaddent.Click += new System.EventHandler(this.btnaddent_Click);
            // 
            // panelroles
            // 
            this.panelroles.Controls.Add(this.btnrole);
            this.panelroles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelroles.Location = new System.Drawing.Point(0, 460);
            this.panelroles.Name = "panelroles";
            this.panelroles.Size = new System.Drawing.Size(150, 75);
            this.panelroles.TabIndex = 10;
            // 
            // btnrole
            // 
            this.btnrole.FlatAppearance.BorderSize = 0;
            this.btnrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrole.ForeColor = System.Drawing.SystemColors.Control;
            this.btnrole.Image = global::student_enrolled.Properties.Resources.roles;
            this.btnrole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrole.Location = new System.Drawing.Point(-3, 0);
            this.btnrole.Name = "btnrole";
            this.btnrole.Size = new System.Drawing.Size(153, 75);
            this.btnrole.TabIndex = 5;
            this.btnrole.Text = "roles";
            this.btnrole.UseVisualStyleBackColor = true;
            this.btnrole.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelaccounts
            // 
            this.panelaccounts.Controls.Add(this.btnaccounts);
            this.panelaccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelaccounts.Location = new System.Drawing.Point(0, 385);
            this.panelaccounts.Name = "panelaccounts";
            this.panelaccounts.Size = new System.Drawing.Size(150, 75);
            this.panelaccounts.TabIndex = 9;
            // 
            // btnaccounts
            // 
            this.btnaccounts.FlatAppearance.BorderSize = 0;
            this.btnaccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccounts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnaccounts.Image = global::student_enrolled.Properties.Resources.user_samall;
            this.btnaccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaccounts.Location = new System.Drawing.Point(-3, 0);
            this.btnaccounts.Name = "btnaccounts";
            this.btnaccounts.Size = new System.Drawing.Size(153, 75);
            this.btnaccounts.TabIndex = 4;
            this.btnaccounts.Text = " Accounts";
            this.btnaccounts.UseVisualStyleBackColor = true;
            this.btnaccounts.Click += new System.EventHandler(this.btnaccounts_Click);
            // 
            // lbcontcat
            // 
            this.lbcontcat.AutoSize = true;
            this.lbcontcat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbcontcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontcat.ForeColor = System.Drawing.Color.White;
            this.lbcontcat.Location = new System.Drawing.Point(0, 651);
            this.lbcontcat.Name = "lbcontcat";
            this.lbcontcat.Size = new System.Drawing.Size(92, 20);
            this.lbcontcat.TabIndex = 2;
            this.lbcontcat.Text = "contact us:";
            // 
            // panelcon
            // 
            this.panelcon.Controls.Add(this.btngit);
            this.panelcon.Controls.Add(this.btnphone);
            this.panelcon.Controls.Add(this.btnmail);
            this.panelcon.Controls.Add(this.btnface);
            this.panelcon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcon.Location = new System.Drawing.Point(0, 671);
            this.panelcon.MaximumSize = new System.Drawing.Size(0, 140);
            this.panelcon.MinimumSize = new System.Drawing.Size(0, 35);
            this.panelcon.Name = "panelcon";
            this.panelcon.Size = new System.Drawing.Size(150, 40);
            this.panelcon.TabIndex = 8;
            // 
            // btngit
            // 
            this.btngit.BackColor = System.Drawing.Color.Transparent;
            this.btngit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btngit.FlatAppearance.BorderSize = 0;
            this.btngit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngit.ForeColor = System.Drawing.Color.White;
            this.btngit.Image = global::student_enrolled.Properties.Resources.github;
            this.btngit.Location = new System.Drawing.Point(108, 0);
            this.btngit.Name = "btngit";
            this.btngit.Size = new System.Drawing.Size(36, 40);
            this.btngit.TabIndex = 9;
            this.btngit.UseVisualStyleBackColor = false;
            this.btngit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnphone
            // 
            this.btnphone.BackColor = System.Drawing.Color.Transparent;
            this.btnphone.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnphone.FlatAppearance.BorderSize = 0;
            this.btnphone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnphone.ForeColor = System.Drawing.Color.White;
            this.btnphone.Image = global::student_enrolled.Properties.Resources.phone;
            this.btnphone.Location = new System.Drawing.Point(72, 0);
            this.btnphone.Name = "btnphone";
            this.btnphone.Size = new System.Drawing.Size(36, 40);
            this.btnphone.TabIndex = 8;
            this.btnphone.UseVisualStyleBackColor = false;
            this.btnphone.Click += new System.EventHandler(this.btnphone_Click);
            // 
            // btnmail
            // 
            this.btnmail.BackColor = System.Drawing.Color.Transparent;
            this.btnmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnmail.FlatAppearance.BorderSize = 0;
            this.btnmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmail.ForeColor = System.Drawing.Color.White;
            this.btnmail.Image = global::student_enrolled.Properties.Resources.mail;
            this.btnmail.Location = new System.Drawing.Point(36, 0);
            this.btnmail.Name = "btnmail";
            this.btnmail.Size = new System.Drawing.Size(36, 40);
            this.btnmail.TabIndex = 7;
            this.btnmail.UseVisualStyleBackColor = false;
            this.btnmail.Click += new System.EventHandler(this.btnmail_Click);
            // 
            // btnface
            // 
            this.btnface.BackColor = System.Drawing.Color.Transparent;
            this.btnface.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnface.FlatAppearance.BorderSize = 0;
            this.btnface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnface.ForeColor = System.Drawing.Color.White;
            this.btnface.Image = global::student_enrolled.Properties.Resources.Facebook;
            this.btnface.Location = new System.Drawing.Point(0, 0);
            this.btnface.Name = "btnface";
            this.btnface.Size = new System.Drawing.Size(36, 40);
            this.btnface.TabIndex = 6;
            this.btnface.UseVisualStyleBackColor = false;
            this.btnface.Click += new System.EventHandler(this.btnface_Click);
            // 
            // panelenrolling
            // 
            this.panelenrolling.Controls.Add(this.btnenroll);
            this.panelenrolling.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelenrolling.Location = new System.Drawing.Point(0, 310);
            this.panelenrolling.Name = "panelenrolling";
            this.panelenrolling.Size = new System.Drawing.Size(150, 75);
            this.panelenrolling.TabIndex = 7;
            // 
            // btnenroll
            // 
            this.btnenroll.FlatAppearance.BorderSize = 0;
            this.btnenroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenroll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnenroll.Image = global::student_enrolled.Properties.Resources.ADD_Acounts;
            this.btnenroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenroll.Location = new System.Drawing.Point(-3, 0);
            this.btnenroll.Name = "btnenroll";
            this.btnenroll.Size = new System.Drawing.Size(153, 75);
            this.btnenroll.TabIndex = 3;
            this.btnenroll.Text = "Enrolling";
            this.btnenroll.UseVisualStyleBackColor = true;
            this.btnenroll.Click += new System.EventHandler(this.btnenroll_Click);
            // 
            // panelcourse
            // 
            this.panelcourse.Controls.Add(this.btncourses);
            this.panelcourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcourse.Location = new System.Drawing.Point(0, 235);
            this.panelcourse.Name = "panelcourse";
            this.panelcourse.Size = new System.Drawing.Size(150, 75);
            this.panelcourse.TabIndex = 6;
            // 
            // btncourses
            // 
            this.btncourses.FlatAppearance.BorderSize = 0;
            this.btncourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncourses.ForeColor = System.Drawing.SystemColors.Control;
            this.btncourses.Image = ((System.Drawing.Image)(resources.GetObject("btncourses.Image")));
            this.btncourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncourses.Location = new System.Drawing.Point(0, 0);
            this.btncourses.Name = "btncourses";
            this.btncourses.Size = new System.Drawing.Size(150, 75);
            this.btncourses.TabIndex = 2;
            this.btncourses.Text = "courses";
            this.btncourses.UseVisualStyleBackColor = true;
            this.btncourses.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelstudents
            // 
            this.panelstudents.Controls.Add(this.btnstudents);
            this.panelstudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelstudents.Location = new System.Drawing.Point(0, 160);
            this.panelstudents.Name = "panelstudents";
            this.panelstudents.Size = new System.Drawing.Size(150, 75);
            this.panelstudents.TabIndex = 5;
            // 
            // btnstudents
            // 
            this.btnstudents.FlatAppearance.BorderSize = 0;
            this.btnstudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstudents.ForeColor = System.Drawing.SystemColors.Control;
            this.btnstudents.Image = global::student_enrolled.Properties.Resources.profile;
            this.btnstudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstudents.Location = new System.Drawing.Point(0, 0);
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.Size = new System.Drawing.Size(150, 75);
            this.btnstudents.TabIndex = 1;
            this.btnstudents.Text = "students";
            this.btnstudents.UseVisualStyleBackColor = true;
            this.btnstudents.Click += new System.EventHandler(this.btnstudents_Click);
            // 
            // panelhome
            // 
            this.panelhome.Controls.Add(this.btnhome);
            this.panelhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelhome.Location = new System.Drawing.Point(0, 85);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(150, 75);
            this.panelhome.TabIndex = 4;
            // 
            // btnhome
            // 
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnhome.Image = global::student_enrolled.Properties.Resources.Home;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 0);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(150, 75);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::student_enrolled.Properties.Resources.Layer_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(150, 85);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(47, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 15);
            this.pictureBox1.Size = new System.Drawing.Size(150, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelmain.Controls.Add(this.pictureBox3);
            this.panelmain.Controls.Add(this.pictureBox2);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(150, 37);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1060, 711);
            this.panelmain.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::student_enrolled.Properties.Resources.whats;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1060, 711);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::student_enrolled.Properties.Resources.Color_Fill_1;
            this.pictureBox2.Location = new System.Drawing.Point(148, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(630, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // slidetimer
            // 
            this.slidetimer.Interval = 20;
            this.slidetimer.Tick += new System.EventHandler(this.slidetimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1210, 748);
            this.ControlBox = false;
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelattend.ResumeLayout(false);
            this.panelroles.ResumeLayout(false);
            this.panelaccounts.ResumeLayout(false);
            this.panelcon.ResumeLayout(false);
            this.panelenrolling.ResumeLayout(false);
            this.panelcourse.ResumeLayout(false);
            this.panelstudents.ResumeLayout(false);
            this.panelhome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnenroll;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Button btncourses;
        private PictureBox pictureBox1;
        private Button close;
        private Button Maxmize;
        private Button minimize;
        private Panel panelenrolling;
        private Panel panelcourse;
        private Panel panelstudents;
        private Panel panelhome;
        private Timer slidetimer;
        private Button btnface;
        private Panel panelcon;
        private Button btnmail;
        private Label lbcontcat;
        private Button btnphone;
        private PictureBox pictureBox2;
        private Panel panelaccounts;
        private Button btnaccounts;
        private Panel panelroles;
        private Button btnrole;
        //        private Button btnstudents;
        private Button btngit;
        private Button btnlogout;
        private Button lbname;
        private Button btnclosepanel;
        private Button btnstudents;
        private PictureBox pictureBox3;
        private Panel panelattend;
        private Button btnaddent;
    }
}

