using System.Drawing;

namespace student_enrolled.forms
{
    partial class students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneladd = new System.Windows.Forms.Panel();
            this.btnopenadd = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtstudent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnload = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.combosearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.panelbtns = new System.Windows.Forms.Panel();
            this.btncustom = new System.Windows.Forms.Button();
            this.btnthismon = new System.Windows.Forms.Button();
            this.btnlastmon = new System.Windows.Forms.Button();
            this.btnlast7 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.openadd = new System.Windows.Forms.Timer(this.components);
            this.panelmain = new System.Windows.Forms.Panel();
            this.paneladd.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelbtns.SuspendLayout();
            this.panelmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneladd
            // 
            this.paneladd.Controls.Add(this.btnopenadd);
            this.paneladd.Controls.Add(this.txtemail);
            this.paneladd.Controls.Add(this.label3);
            this.paneladd.Controls.Add(this.btnadd);
            this.paneladd.Controls.Add(this.txtphone);
            this.paneladd.Controls.Add(this.txtstudent);
            this.paneladd.Controls.Add(this.label2);
            this.paneladd.Controls.Add(this.label1);
            this.paneladd.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneladd.Location = new System.Drawing.Point(0, 0);
            this.paneladd.MaximumSize = new System.Drawing.Size(264, 0);
            this.paneladd.MinimumSize = new System.Drawing.Size(29, 0);
            this.paneladd.Name = "paneladd";
            this.paneladd.Size = new System.Drawing.Size(264, 675);
            this.paneladd.TabIndex = 0;
            // 
            // btnopenadd
            // 
            this.btnopenadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnopenadd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnopenadd.FlatAppearance.BorderSize = 0;
            this.btnopenadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopenadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopenadd.Image = global::student_enrolled.Properties.Resources.angle_right;
            this.btnopenadd.Location = new System.Drawing.Point(233, 0);
            this.btnopenadd.Name = "btnopenadd";
            this.btnopenadd.Size = new System.Drawing.Size(31, 675);
            this.btnopenadd.TabIndex = 7;
            this.btnopenadd.UseVisualStyleBackColor = false;
            this.btnopenadd.Click += new System.EventHandler(this.btnopenadd_Click);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.White;
            this.txtemail.Location = new System.Drawing.Point(35, 218);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(155, 26);
            this.txtemail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(35, 421);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(155, 39);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            this.btnadd.Enter += new System.EventHandler(this.btnenter);
            this.btnadd.Leave += new System.EventHandler(this.btngo);
            this.btnadd.MouseEnter += new System.EventHandler(this.btnenter);
            this.btnadd.MouseLeave += new System.EventHandler(this.btngo);
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.White;
            this.txtphone.Location = new System.Drawing.Point(35, 131);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(155, 26);
            this.txtphone.TabIndex = 2;
            // 
            // txtstudent
            // 
            this.txtstudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtstudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudent.ForeColor = System.Drawing.Color.White;
            this.txtstudent.Location = new System.Drawing.Point(35, 50);
            this.txtstudent.Name = "txtstudent";
            this.txtstudent.Size = new System.Drawing.Size(155, 26);
            this.txtstudent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "student name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(264, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 531);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(795, 441);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnload);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 441);
            this.panel3.MaximumSize = new System.Drawing.Size(0, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 90);
            this.panel3.TabIndex = 3;
            // 
            // btnload
            // 
            this.btnload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnload.FlatAppearance.BorderSize = 0;
            this.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(3964, 23);
            this.btnload.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(207, 39);
            this.btnload.TabIndex = 11;
            this.btnload.Text = "Load Excel";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            this.btnload.Enter += new System.EventHandler(this.btnenter);
            this.btnload.Leave += new System.EventHandler(this.btngo);
            this.btnload.MouseEnter += new System.EventHandler(this.btnenter);
            this.btnload.MouseLeave += new System.EventHandler(this.btngo);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(3695, 23);
            this.btnsave.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(207, 39);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save Excel";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.Enter += new System.EventHandler(this.btnenter);
            this.btnsave.Leave += new System.EventHandler(this.btngo);
            this.btnsave.MouseEnter += new System.EventHandler(this.btnenter);
            this.btnsave.MouseLeave += new System.EventHandler(this.btngo);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnrefresh);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtsearch);
            this.panel4.Controls.Add(this.combosearch);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.DateEnd);
            this.panel4.Controls.Add(this.DateStart);
            this.panel4.Controls.Add(this.panelbtns);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(264, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(795, 144);
            this.panel4.TabIndex = 4;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnrefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::student_enrolled.Properties.Resources.exchange;
            this.btnrefresh.Location = new System.Drawing.Point(674, 49);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(109, 65);
            this.btnrefresh.TabIndex = 20;
            this.btnrefresh.UseCompatibleTextRendering = true;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "search";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "colum:";
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsearch.Location = new System.Drawing.Point(313, 110);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(278, 22);
            this.txtsearch.TabIndex = 17;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // combosearch
            // 
            this.combosearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combosearch.FormattingEnabled = true;
            this.combosearch.Items.AddRange(new object[] {
            "id",
            "name",
            "phone",
            "email"});
            this.combosearch.Location = new System.Drawing.Point(99, 110);
            this.combosearch.Name = "combosearch";
            this.combosearch.Size = new System.Drawing.Size(134, 24);
            this.combosearch.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "From";
            // 
            // DateEnd
            // 
            this.DateEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateEnd.CalendarForeColor = System.Drawing.Color.White;
            this.DateEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DateEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DateEnd.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEnd.Location = new System.Drawing.Point(358, 70);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(117, 22);
            this.DateEnd.TabIndex = 12;
            this.DateEnd.Value = new System.DateTime(2023, 7, 25, 0, 15, 6, 0);
            // 
            // DateStart
            // 
            this.DateStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DateStart.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DateStart.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateStart.Location = new System.Drawing.Point(201, 70);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(117, 22);
            this.DateStart.TabIndex = 11;
            this.DateStart.Value = new System.DateTime(2023, 7, 25, 0, 15, 20, 0);
            // 
            // panelbtns
            // 
            this.panelbtns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelbtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelbtns.Controls.Add(this.btncustom);
            this.panelbtns.Controls.Add(this.btnthismon);
            this.panelbtns.Controls.Add(this.btnlastmon);
            this.panelbtns.Controls.Add(this.btnlast7);
            this.panelbtns.Controls.Add(this.btnAll);
            this.panelbtns.Location = new System.Drawing.Point(41, 24);
            this.panelbtns.Name = "panelbtns";
            this.panelbtns.Size = new System.Drawing.Size(546, 31);
            this.panelbtns.TabIndex = 9;
            // 
            // btncustom
            // 
            this.btncustom.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            this.btncustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustom.Location = new System.Drawing.Point(1, 0);
            this.btncustom.Name = "btncustom";
            this.btncustom.Size = new System.Drawing.Size(109, 31);
            this.btncustom.TabIndex = 8;
            this.btncustom.Text = "custom";
            this.btncustom.UseCompatibleTextRendering = true;
            this.btncustom.UseVisualStyleBackColor = true;
            this.btncustom.Click += new System.EventHandler(this.btncustom_Click);
            // 
            // btnthismon
            // 
            this.btnthismon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnthismon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            this.btnthismon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthismon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthismon.Location = new System.Drawing.Point(110, 0);
            this.btnthismon.Name = "btnthismon";
            this.btnthismon.Size = new System.Drawing.Size(109, 31);
            this.btnthismon.TabIndex = 6;
            this.btnthismon.Text = "this month";
            this.btnthismon.UseCompatibleTextRendering = true;
            this.btnthismon.UseVisualStyleBackColor = true;
            this.btnthismon.Click += new System.EventHandler(this.btnthismon_Click);
            // 
            // btnlastmon
            // 
            this.btnlastmon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnlastmon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            this.btnlastmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlastmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlastmon.Location = new System.Drawing.Point(219, 0);
            this.btnlastmon.Name = "btnlastmon";
            this.btnlastmon.Size = new System.Drawing.Size(109, 31);
            this.btnlastmon.TabIndex = 4;
            this.btnlastmon.Text = "last month";
            this.btnlastmon.UseCompatibleTextRendering = true;
            this.btnlastmon.UseVisualStyleBackColor = true;
            this.btnlastmon.Click += new System.EventHandler(this.btnlastmon_Click);
            // 
            // btnlast7
            // 
            this.btnlast7.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnlast7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            this.btnlast7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlast7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast7.Location = new System.Drawing.Point(328, 0);
            this.btnlast7.Name = "btnlast7";
            this.btnlast7.Size = new System.Drawing.Size(109, 31);
            this.btnlast7.TabIndex = 2;
            this.btnlast7.Text = "last 7 day";
            this.btnlast7.UseCompatibleTextRendering = true;
            this.btnlast7.UseVisualStyleBackColor = true;
            this.btnlast7.Click += new System.EventHandler(this.btnlast7_Click);
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(437, 0);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(109, 31);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All Time";
            this.btnAll.UseCompatibleTextRendering = true;
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // openadd
            // 
            this.openadd.Tick += new System.EventHandler(this.openadd_Tick);
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.panel2);
            this.panelmain.Controls.Add(this.panel4);
            this.panelmain.Controls.Add(this.paneladd);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1059, 675);
            this.panelmain.TabIndex = 21;
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1059, 675);
            this.ControlBox = false;
            this.Controls.Add(this.panelmain);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "students";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.students_KeyDown);
            this.paneladd.ResumeLayout(false);
            this.paneladd.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelbtns.ResumeLayout(false);
            this.panelmain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneladd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtstudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnopenadd;
        private System.Windows.Forms.Timer openadd;
        private System.Windows.Forms.Panel panelbtns;
        private System.Windows.Forms.Button btncustom;
        private System.Windows.Forms.Button btnthismon;
        private System.Windows.Forms.Button btnlastmon;
        private System.Windows.Forms.Button btnlast7;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox combosearch;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Panel panelmain;
    }
}