using System.Drawing;

namespace student_enrolled.forms
{
    partial class student
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
            Color miancolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            Color supcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            Color spcolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122))))); //System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.lbjoin = new System.Windows.Forms.Label();
            this.btnup = new System.Windows.Forms.Button();
            this.splitmain = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitsup = new System.Windows.Forms.SplitContainer();
            this.Gridmoney = new System.Windows.Forms.DataGridView();
            this.Gridabsent = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).BeginInit();
            this.splitmain.Panel1.SuspendLayout();
            this.splitmain.Panel2.SuspendLayout();
            this.splitmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitsup)).BeginInit();
            this.splitsup.Panel1.SuspendLayout();
            this.splitsup.Panel2.SuspendLayout();
            this.splitsup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridmoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridabsent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(105, 9);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(589, 30);
            this.txtname.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(105, 85);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(589, 30);
            this.txtemail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "email";
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(105, 49);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(301, 30);
            this.txtphone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "phone";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.lbjoin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtphone);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnup);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 139);
            this.panel1.TabIndex = 7;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::student_enrolled.Properties.Resources.Close;
            this.close.Location = new System.Drawing.Point(761, 3);
            this.close.MaximumSize = new System.Drawing.Size(27, 37);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 37);
            this.close.TabIndex = 16;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lbjoin
            // 
            this.lbjoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbjoin.Location = new System.Drawing.Point(432, 49);
            this.lbjoin.Name = "lbjoin";
            this.lbjoin.Size = new System.Drawing.Size(262, 29);
            this.lbjoin.TabIndex = 7;
            this.lbjoin.Text = "Join date :";
            // 
            // btnup
            // 
            this.btnup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.Image = global::student_enrolled.Properties.Resources.refresh;
            this.btnup.Location = new System.Drawing.Point(713, 49);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 74);
            this.btnup.TabIndex = 2;
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // splitmain
            // 
            this.splitmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitmain.Location = new System.Drawing.Point(0, 139);
            this.splitmain.Name = "splitmain";
            // 
            // splitmain.Panel1
            // 
            this.splitmain.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitmain.Panel2
            // 
            this.splitmain.Panel2.Controls.Add(this.splitsup);
            this.splitmain.Size = new System.Drawing.Size(800, 319);
            this.splitmain.SplitterDistance = 228;
            this.splitmain.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = supcolor;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = spcolor;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = spcolor;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = miancolor;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = spcolor;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = supcolor;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = miancolor;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = spcolor;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(228, 319);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // splitsup
            // 
            this.splitsup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitsup.Location = new System.Drawing.Point(0, 0);
            this.splitsup.Name = "splitsup";
            // 
            // splitsup.Panel1
            // 
            this.splitsup.Panel1.Controls.Add(this.Gridmoney);
            // 
            // splitsup.Panel2
            // 
            this.splitsup.Panel2.Controls.Add(this.Gridabsent);
            this.splitsup.Size = new System.Drawing.Size(568, 319);
            this.splitsup.SplitterDistance = 273;
            this.splitsup.TabIndex = 0;
            // 
            // Gridmoney
            // 
            this.Gridmoney.AllowUserToAddRows = false;
            this.Gridmoney.AllowUserToDeleteRows = false;
            this.Gridmoney.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridmoney.BackgroundColor = supcolor;
            this.Gridmoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gridmoney.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Gridmoney.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = spcolor;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = spcolor;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridmoney.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Gridmoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = miancolor;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = spcolor;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridmoney.DefaultCellStyle = dataGridViewCellStyle4;
            this.Gridmoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gridmoney.EnableHeadersVisualStyles = false;
            this.Gridmoney.GridColor = supcolor;
            this.Gridmoney.Location = new System.Drawing.Point(0, 0);
            this.Gridmoney.MultiSelect = false;
            this.Gridmoney.Name = "Gridmoney";
            this.Gridmoney.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Gridmoney.RowHeadersVisible = false;
            this.Gridmoney.RowHeadersWidth = 51;
            this.Gridmoney.RowTemplate.DefaultCellStyle.BackColor = miancolor;
            this.Gridmoney.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.Gridmoney.RowTemplate.DefaultCellStyle.SelectionBackColor = spcolor;
            this.Gridmoney.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Gridmoney.RowTemplate.Height = 30;
            this.Gridmoney.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridmoney.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridmoney.Size = new System.Drawing.Size(273, 319);
            this.Gridmoney.TabIndex = 10;
            this.Gridmoney.VirtualMode = true;
            this.Gridmoney.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridmoney_CellClick);
            // 
            // Gridabsent
            // 
            this.Gridabsent.AllowUserToAddRows = false;
            this.Gridabsent.AllowUserToDeleteRows = false;
            this.Gridabsent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridabsent.BackgroundColor = supcolor;
            this.Gridabsent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gridabsent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Gridabsent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = spcolor;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = spcolor;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridabsent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Gridabsent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = miancolor;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = spcolor;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridabsent.DefaultCellStyle = dataGridViewCellStyle6;
            this.Gridabsent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gridabsent.EnableHeadersVisualStyles = false;
            this.Gridabsent.GridColor = supcolor;
            this.Gridabsent.Location = new System.Drawing.Point(0, 0);
            this.Gridabsent.MultiSelect = false;
            this.Gridabsent.Name = "Gridabsent";
            this.Gridabsent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Gridabsent.RowHeadersVisible = false;
            this.Gridabsent.RowHeadersWidth = 51;
            this.Gridabsent.RowTemplate.DefaultCellStyle.BackColor = miancolor;
            this.Gridabsent.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.Gridabsent.RowTemplate.DefaultCellStyle.SelectionBackColor = spcolor;
            this.Gridabsent.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Gridabsent.RowTemplate.Height = 30;
            this.Gridabsent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridabsent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridabsent.Size = new System.Drawing.Size(291, 319);
            this.Gridabsent.TabIndex = 10;
            this.Gridabsent.VirtualMode = true;
            this.Gridabsent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridabsent_CellClick);
            this.Gridabsent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Gridabsent_CellFormatting);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = miancolor;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.splitmain);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitmain.Panel1.ResumeLayout(false);
            this.splitmain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).EndInit();
            this.splitmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitsup.Panel1.ResumeLayout(false);
            this.splitsup.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitsup)).EndInit();
            this.splitsup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gridmoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridabsent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbjoin;
        private System.Windows.Forms.SplitContainer splitmain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitsup;
        private System.Windows.Forms.DataGridView Gridmoney;
        private System.Windows.Forms.DataGridView Gridabsent;
        private System.Windows.Forms.Button close;
    }
}