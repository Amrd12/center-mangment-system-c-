namespace student_enrolled.forms.attendance
{
    partial class attendancefields
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
            this.btnatt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.snum = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnab = new System.Windows.Forms.Button();
            this.btntotal = new System.Windows.Forms.Button();
            this.txtcourse = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.Label();
            this.btnCamQR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.attlist = new System.Windows.Forms.ListBox();
            this.ablist = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bannedlist = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnatt
            // 
            this.btnatt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnatt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatt.ForeColor = System.Drawing.Color.White;
            this.btnatt.Location = new System.Drawing.Point(547, 119);
            this.btnatt.Name = "btnatt";
            this.btnatt.Size = new System.Drawing.Size(120, 55);
            this.btnatt.TabIndex = 4;
            this.btnatt.Text = "attended : \r\n";
            this.btnatt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(748, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "attendance";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "absent";
            // 
            // snum
            // 
            this.snum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.snum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.snum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.snum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snum.ForeColor = System.Drawing.Color.White;
            this.snum.Location = new System.Drawing.Point(254, 72);
            this.snum.Name = "snum";
            this.snum.Size = new System.Drawing.Size(147, 31);
            this.snum.TabIndex = 7;
            this.snum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.snum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snum_KeyDown);
            // 
            // sname
            // 
            this.sname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sname.ForeColor = System.Drawing.Color.White;
            this.sname.Location = new System.Drawing.Point(543, 72);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(320, 31);
            this.sname.TabIndex = 8;
            this.sname.TextChanged += new System.EventHandler(this.sname_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "name";
            // 
            // btnab
            // 
            this.btnab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnab.ForeColor = System.Drawing.Color.White;
            this.btnab.Location = new System.Drawing.Point(377, 119);
            this.btnab.Name = "btnab";
            this.btnab.Size = new System.Drawing.Size(120, 55);
            this.btnab.TabIndex = 11;
            this.btnab.Text = "absent : \r\n";
            this.btnab.UseVisualStyleBackColor = false;
            // 
            // btntotal
            // 
            this.btntotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btntotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntotal.ForeColor = System.Drawing.Color.White;
            this.btntotal.Location = new System.Drawing.Point(187, 119);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(120, 55);
            this.btntotal.TabIndex = 12;
            this.btntotal.Text = "total : \r\n";
            this.btntotal.UseVisualStyleBackColor = false;
            // 
            // txtcourse
            // 
            this.txtcourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcourse.AutoSize = true;
            this.txtcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcourse.Location = new System.Drawing.Point(141, 12);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcourse.Size = new System.Drawing.Size(96, 25);
            this.txtcourse.TabIndex = 16;
            this.txtcourse.Text = "course : ";
            this.txtcourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdate
            // 
            this.txtdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdate.AutoSize = true;
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(542, 12);
            this.txtdate.Name = "txtdate";
            this.txtdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdate.Size = new System.Drawing.Size(76, 25);
            this.txtdate.TabIndex = 17;
            this.txtdate.Text = "Date : ";
            this.txtdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCamQR
            // 
            this.btnCamQR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCamQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCamQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamQR.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCamQR.Location = new System.Drawing.Point(870, 119);
            this.btnCamQR.Name = "btnCamQR";
            this.btnCamQR.Size = new System.Drawing.Size(120, 55);
            this.btnCamQR.TabIndex = 18;
            this.btnCamQR.Text = "Camera";
            this.btnCamQR.UseVisualStyleBackColor = false;
            this.btnCamQR.Click += new System.EventHandler(this.btnCamQR_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::student_enrolled.Properties.Resources.maxmize;
            this.button1.Location = new System.Drawing.Point(1072, 0);
            this.button1.MaximumSize = new System.Drawing.Size(27, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 37);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // convert
            // 
            this.convert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.ForeColor = System.Drawing.Color.White;
            this.convert.Image = global::student_enrolled.Properties.Resources.exchange;
            this.convert.Location = new System.Drawing.Point(716, 119);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(120, 55);
            this.convert.TabIndex = 13;
            this.convert.UseVisualStyleBackColor = false;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::student_enrolled.Properties.Resources.Close;
            this.close.Location = new System.Drawing.Point(1105, 0);
            this.close.MaximumSize = new System.Drawing.Size(27, 37);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 37);
            this.close.TabIndex = 15;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // attlist
            // 
            this.attlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.attlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attlist.ForeColor = System.Drawing.Color.White;
            this.attlist.FormattingEnabled = true;
            this.attlist.ItemHeight = 20;
            this.attlist.Location = new System.Drawing.Point(0, 0);
            this.attlist.Name = "attlist";
            this.attlist.Size = new System.Drawing.Size(728, 251);
            this.attlist.TabIndex = 3;
            this.attlist.SelectedIndexChanged += new System.EventHandler(this.attlist_SelectedIndexChanged);
            // 
            // ablist
            // 
            this.ablist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ablist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ablist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ablist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ablist.ForeColor = System.Drawing.Color.White;
            this.ablist.FormattingEnabled = true;
            this.ablist.ItemHeight = 20;
            this.ablist.Location = new System.Drawing.Point(0, 0);
            this.ablist.Name = "ablist";
            this.ablist.Size = new System.Drawing.Size(375, 251);
            this.ablist.TabIndex = 2;
            this.ablist.SelectedIndexChanged += new System.EventHandler(this.ablist_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ablist);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.attlist);
            this.splitContainer1.Size = new System.Drawing.Size(1108, 251);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.bannedlist);
            this.splitContainer2.Size = new System.Drawing.Size(1108, 432);
            this.splitContainer2.SplitterDistance = 251;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 21;
            // 
            // bannedlist
            // 
            this.bannedlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bannedlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bannedlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bannedlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannedlist.ForeColor = System.Drawing.Color.White;
            this.bannedlist.FormattingEnabled = true;
            this.bannedlist.ItemHeight = 20;
            this.bannedlist.Location = new System.Drawing.Point(0, 0);
            this.bannedlist.Name = "bannedlist";
            this.bannedlist.Size = new System.Drawing.Size(1108, 176);
            this.bannedlist.TabIndex = 3;
            this.bannedlist.SelectedIndexChanged += new System.EventHandler(this.bannedlist_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 668);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(303, 24);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(411, 55);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Location = new System.Drawing.Point(12, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 432);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnCamQR);
            this.panel3.Controls.Add(this.txtdate);
            this.panel3.Controls.Add(this.convert);
            this.panel3.Controls.Add(this.txtcourse);
            this.panel3.Controls.Add(this.close);
            this.panel3.Controls.Add(this.btntotal);
            this.panel3.Controls.Add(this.btnab);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.sname);
            this.panel3.Controls.Add(this.snum);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnatt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 768);
            this.panel3.TabIndex = 23;
            // 
            // attendancefields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1132, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "attendancefields";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.attendancefields_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnatt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox snum;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnab;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label txtcourse;
        private System.Windows.Forms.Label txtdate;
        private System.Windows.Forms.Button btnCamQR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox attlist;
        private System.Windows.Forms.ListBox ablist;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox bannedlist;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel3;
    }
}