using System.Windows.Forms;

namespace student_enrolled.forms.attendance
{
    partial class attendancemain
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
            this.panelbot = new System.Windows.Forms.Panel();
            this.paneladd = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.coursebox = new System.Windows.Forms.ComboBox();
            this.btnmake = new System.Windows.Forms.Button();
            this.panelmid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelmain = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.combosearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.panelbtns = new System.Windows.Forms.Panel();
            this.btncustom = new System.Windows.Forms.Button();
            this.btnthismon = new System.Windows.Forms.Button();
            this.btnlastmon = new System.Windows.Forms.Button();
            this.btnlast7 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.timeradd = new System.Windows.Forms.Timer(this.components);
            this.panelbot.SuspendLayout();
            this.paneladd.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelmid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelmain.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.panelbtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbot
            // 
            this.panelbot.Controls.Add(this.paneladd);
            this.panelbot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbot.Location = new System.Drawing.Point(0, 456);
            this.panelbot.Name = "panelbot";
            this.panelbot.Size = new System.Drawing.Size(1072, 100);
            this.panelbot.TabIndex = 1;
            // 
            // paneladd
            // 
            this.paneladd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.paneladd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.paneladd.Controls.Add(this.btnadd);
            this.paneladd.Controls.Add(this.tableLayoutPanel1);
            this.paneladd.Location = new System.Drawing.Point(163, 36);
            this.paneladd.MaximumSize = new System.Drawing.Size(750, 31);
            this.paneladd.MinimumSize = new System.Drawing.Size(117, 31);
            this.paneladd.Name = "paneladd";
            this.paneladd.Size = new System.Drawing.Size(692, 31);
            this.paneladd.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(578, 0);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(114, 31);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add";
            this.btnadd.UseCompatibleTextRendering = true;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            this.btnadd.MouseEnter += new System.EventHandler(this.btnenter);
            this.btnadd.MouseLeave += new System.EventHandler(this.btngo);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.41463F));
            this.tableLayoutPanel1.Controls.Add(this.coursebox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnmake, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(633, 31);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Visible = false;
            // 
            // coursebox
            // 
            this.coursebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coursebox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursebox.Location = new System.Drawing.Point(107, 3);
            this.coursebox.Name = "coursebox";
            this.coursebox.Size = new System.Drawing.Size(523, 28);
            this.coursebox.TabIndex = 2;
            this.coursebox.Text = "Course";
            // 
            // btnmake
            // 
            this.btnmake.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            this.btnmake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmake.Location = new System.Drawing.Point(3, 3);
            this.btnmake.Name = "btnmake";
            this.btnmake.Size = new System.Drawing.Size(94, 25);
            this.btnmake.TabIndex = 0;
            this.btnmake.Text = "submit";
            this.btnmake.UseCompatibleTextRendering = true;
            this.btnmake.UseVisualStyleBackColor = true;
            this.btnmake.Click += new System.EventHandler(this.btnmake_Click);
            this.btnmake.MouseEnter += new System.EventHandler(this.btnenter);
            this.btnmake.MouseLeave += new System.EventHandler(this.btngo);
            // 
            // panelmid
            // 
            this.panelmid.Controls.Add(this.dataGridView1);
            this.panelmid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmid.Location = new System.Drawing.Point(0, 183);
            this.panelmid.Name = "panelmid";
            this.panelmid.Size = new System.Drawing.Size(1072, 273);
            this.panelmid.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 273);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.panelmid);
            this.panelmain.Controls.Add(this.panelbot);
            this.panelmain.Controls.Add(this.paneltop);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1072, 556);
            this.panelmain.TabIndex = 3;
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.label3);
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Controls.Add(this.btnrefresh);
            this.paneltop.Controls.Add(this.txtsearch);
            this.paneltop.Controls.Add(this.combosearch);
            this.paneltop.Controls.Add(this.label4);
            this.paneltop.Controls.Add(this.label2);
            this.paneltop.Controls.Add(this.DateEnd);
            this.paneltop.Controls.Add(this.panelbtns);
            this.paneltop.Controls.Add(this.DateStart);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1072, 183);
            this.paneltop.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "search";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "colum:";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnrefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::student_enrolled.Properties.Resources.exchange;
            this.btnrefresh.Location = new System.Drawing.Point(929, 96);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(109, 65);
            this.btnrefresh.TabIndex = 13;
            this.btnrefresh.UseCompatibleTextRendering = true;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            this.btnrefresh.MouseEnter += new System.EventHandler(this.btnenter);
            this.btnrefresh.MouseLeave += new System.EventHandler(this.btngo);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsearch.Location = new System.Drawing.Point(502, 117);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(318, 22);
            this.txtsearch.TabIndex = 12;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // combosearch
            // 
            this.combosearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combosearch.FormattingEnabled = true;
            this.combosearch.Items.AddRange(new object[] {
            "id",
            "name"});
            this.combosearch.Location = new System.Drawing.Point(102, 117);
            this.combosearch.Name = "combosearch";
            this.combosearch.Size = new System.Drawing.Size(274, 24);
            this.combosearch.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "To";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "From";
            // 
            // DateEnd
            // 
            this.DateEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateEnd.CalendarForeColor = System.Drawing.Color.White;
            this.DateEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DateEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DateEnd.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEnd.Location = new System.Drawing.Point(341, 21);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(117, 22);
            this.DateEnd.TabIndex = 7;
            this.DateEnd.Value = new System.DateTime(2023, 7, 25, 0, 15, 6, 0);
            // 
            // panelbtns
            // 
            this.panelbtns.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelbtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelbtns.Controls.Add(this.btncustom);
            this.panelbtns.Controls.Add(this.btnthismon);
            this.panelbtns.Controls.Add(this.btnlastmon);
            this.panelbtns.Controls.Add(this.btnlast7);
            this.panelbtns.Controls.Add(this.btnAll);
            this.panelbtns.Location = new System.Drawing.Point(492, 18);
            this.panelbtns.Name = "panelbtns";
            this.panelbtns.Size = new System.Drawing.Size(546, 31);
            this.panelbtns.TabIndex = 8;
            // 
            // btncustom
            // 
            this.btncustom.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
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
            this.btncustom.MouseEnter += new System.EventHandler(this.btnenter);
            this.btncustom.MouseLeave += new System.EventHandler(this.btngo);
            // 
            // btnthismon
            // 
            this.btnthismon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnthismon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
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
            this.btnthismon.MouseEnter += new System.EventHandler(this.btnenter);
            this.btnthismon.MouseLeave += new System.EventHandler(this.btngo);
            // 
            // btnlastmon
            // 
            this.btnlastmon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnlastmon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
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
            this.btnlastmon.MouseEnter += new System.EventHandler(this.btnenter);
            this.btnlastmon.MouseLeave += new System.EventHandler(this.btngo);
            // 
            // btnlast7
            // 
            this.btnlast7.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnlast7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
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
            this.btnlast7.MouseEnter += new System.EventHandler(this.btnenter);
            this.btnlast7.MouseLeave += new System.EventHandler(this.btngo);
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
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
            this.btnAll.MouseEnter += new System.EventHandler(this.btnenter);
            this.btnAll.MouseLeave += new System.EventHandler(this.btngo);
            // 
            // DateStart
            // 
            this.DateStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DateStart.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DateStart.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateStart.Location = new System.Drawing.Point(184, 21);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(117, 22);
            this.DateStart.TabIndex = 6;
            this.DateStart.Value = new System.DateTime(2023, 7, 25, 0, 15, 20, 0);
            // 
            // timeradd
            // 
            this.timeradd.Tick += new System.EventHandler(this.timeradd_Tick);
            // 
            // attendancemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1072, 556);
            this.ControlBox = false;
            this.Controls.Add(this.panelmain);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "attendancemain";
            this.panelbot.ResumeLayout(false);
            this.paneladd.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelmid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelmain.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panelbtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelbot;
        private System.Windows.Forms.Panel panelmid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel paneladd;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox coursebox;
        private System.Windows.Forms.Button btnmake;
        private System.Windows.Forms.Timer timeradd;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker DateStart;
        private Panel panelbtns;
        private Button btncustom;
        private Button btnthismon;
        private Button btnlastmon;
        private Button btnlast7;
        private Button btnAll;
        private DateTimePicker DateEnd;
        private Label label2;
        private Label label4;
        private ComboBox combosearch;
        private TextBox txtsearch;
        private Panel paneltop;
        private Button btnrefresh;
        private Label label3;
        private Label label1;
        private Panel panelmain;
    }
}