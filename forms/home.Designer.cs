using System.Windows.Forms;

namespace student_enrolled.forms
{
    partial class home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbenrolls = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbcourses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbstudents = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartmoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelmain = new System.Windows.Forms.Panel();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.chartdays = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panellabels = new System.Windows.Forms.Panel();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbtotal = new System.Windows.Forms.Button();
            this.lbpaid = new System.Windows.Forms.Button();
            this.lbstill = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartmoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartdays)).BeginInit();
            this.panellabels.SuspendLayout();
            this.panelbtns.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lbenrolls);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(595, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 70);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = global::student_enrolled.Properties.Resources.add_user;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lbenrolls
            // 
            this.lbenrolls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbenrolls.AutoSize = true;
            this.lbenrolls.Location = new System.Drawing.Point(92, 42);
            this.lbenrolls.Name = "lbenrolls";
            this.lbenrolls.Size = new System.Drawing.Size(44, 16);
            this.lbenrolls.TabIndex = 1;
            this.lbenrolls.Text = "label2";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enrolls\' Number";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbcourses);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(310, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 70);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::student_enrolled.Properties.Resources.online_course;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbcourses
            // 
            this.lbcourses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcourses.AutoSize = true;
            this.lbcourses.Location = new System.Drawing.Point(92, 42);
            this.lbcourses.Name = "lbcourses";
            this.lbcourses.Size = new System.Drawing.Size(44, 16);
            this.lbcourses.TabIndex = 1;
            this.lbcourses.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "courses\' Number";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbstudents);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 70);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::student_enrolled.Properties.Resources.group;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbstudents
            // 
            this.lbstudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbstudents.AutoSize = true;
            this.lbstudents.Location = new System.Drawing.Point(92, 42);
            this.lbstudents.Name = "lbstudents";
            this.lbstudents.Size = new System.Drawing.Size(44, 16);
            this.lbstudents.TabIndex = 1;
            this.lbstudents.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students\' Number";
            // 
            // chartmoney
            // 
            this.chartmoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartmoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            chartArea5.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            chartArea5.BorderWidth = 0;
            chartArea5.Name = "ChartArea1";
            this.chartmoney.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            legend5.BorderWidth = 0;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.ForeColor = System.Drawing.Color.White;
            legend5.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend5.Name = "Legend1";
            this.chartmoney.Legends.Add(legend5);
            this.chartmoney.Location = new System.Drawing.Point(736, 15);
            this.chartmoney.Name = "chartmoney";
            this.chartmoney.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartmoney.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(5)))))};
            this.chartmoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series7.IsValueShownAsLabel = true;
            series7.LabelForeColor = System.Drawing.Color.White;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series7.ShadowColor = System.Drawing.Color.Empty;
            series7.YValuesPerPoint = 4;
            this.chartmoney.Series.Add(series7);
            this.chartmoney.Size = new System.Drawing.Size(190, 203);
            this.chartmoney.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(711, 184);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.panel4);
            this.panelmain.Controls.Add(this.btnrefresh);
            this.panelmain.Controls.Add(this.chartmoney);
            this.panelmain.Controls.Add(this.dataGridView1);
            this.panelmain.Controls.Add(this.chartdays);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 133);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(938, 433);
            this.panelmain.TabIndex = 0;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnrefresh.FlatAppearance.BorderSize = 0;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            this.btnrefresh.Location = new System.Drawing.Point(599, 69);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(108, 32);
            this.btnrefresh.TabIndex = 2;
            this.btnrefresh.Text = "refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Visible = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // chartdays
            // 
            this.chartdays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartdays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chartdays.BackSecondaryColor = System.Drawing.Color.White;
            chartArea6.AxisX.IsMarginVisible = false;
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.MajorGrid.LineWidth = 0;
            chartArea6.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.MajorTickMark.LineWidth = 5;
            chartArea6.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea6.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea6.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            chartArea6.BorderWidth = 0;
            chartArea6.Name = "ChartArea1";
            this.chartdays.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            legend6.ForeColor = System.Drawing.Color.White;
            legend6.Name = "Legend1";
            this.chartdays.Legends.Add(legend6);
            this.chartdays.Location = new System.Drawing.Point(12, 15);
            this.chartdays.Name = "chartdays";
            this.chartdays.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(5)))))};
            series8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            series8.LabelForeColor = System.Drawing.Color.White;
            series8.Legend = "Legend1";
            series8.Name = "paid";
            series9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(5)))));
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(5)))));
            series9.LabelForeColor = System.Drawing.Color.White;
            series9.Legend = "Legend1";
            series9.Name = "still";
            this.chartdays.Series.Add(series8);
            this.chartdays.Series.Add(series9);
            this.chartdays.Size = new System.Drawing.Size(711, 203);
            this.chartdays.TabIndex = 0;
            this.chartdays.Text = "chart1";
            // 
            // panellabels
            // 
            this.panellabels.Controls.Add(this.label4);
            this.panellabels.Controls.Add(this.label2);
            this.panellabels.Controls.Add(this.DateEnd);
            this.panellabels.Controls.Add(this.panelbtns);
            this.panellabels.Controls.Add(this.DateStart);
            this.panellabels.Controls.Add(this.panel3);
            this.panellabels.Controls.Add(this.panel2);
            this.panellabels.Controls.Add(this.panel1);
            this.panellabels.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellabels.Location = new System.Drawing.Point(0, 0);
            this.panellabels.Name = "panellabels";
            this.panellabels.Size = new System.Drawing.Size(938, 133);
            this.panellabels.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "To";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
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
            this.DateEnd.Location = new System.Drawing.Point(229, 10);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(117, 22);
            this.DateEnd.TabIndex = 3;
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
            this.panelbtns.Location = new System.Drawing.Point(380, 7);
            this.panelbtns.Name = "panelbtns";
            this.panelbtns.Size = new System.Drawing.Size(546, 31);
            this.panelbtns.TabIndex = 3;
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
            this.btncustom.Enter += new System.EventHandler(this.btnenter);
            this.btncustom.Leave += new System.EventHandler(this.btngo);
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
            this.btnthismon.Enter += new System.EventHandler(this.btnenter);
            this.btnthismon.Leave += new System.EventHandler(this.btngo);
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
            this.btnlastmon.Enter += new System.EventHandler(this.btnenter);
            this.btnlastmon.Leave += new System.EventHandler(this.btngo);
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
            this.btnlast7.Enter += new System.EventHandler(this.btnenter);
            this.btnlast7.Leave += new System.EventHandler(this.btngo);
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
            this.btnAll.Enter += new System.EventHandler(this.btnenter);
            this.btnAll.Leave += new System.EventHandler(this.btngo);
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
            this.DateStart.Location = new System.Drawing.Point(72, 10);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(117, 22);
            this.DateStart.TabIndex = 2;
            this.DateStart.Value = new System.DateTime(2023, 7, 25, 0, 15, 20, 0);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.lbstill);
            this.panel4.Controls.Add(this.lbpaid);
            this.panel4.Controls.Add(this.lbtotal);
            this.panel4.Location = new System.Drawing.Point(735, 237);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 184);
            this.panel4.TabIndex = 9;
            // 
            // lbtotal
            // 
            this.lbtotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbtotal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            this.lbtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.Location = new System.Drawing.Point(0, 0);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(191, 60);
            this.lbtotal.TabIndex = 1;
            this.lbtotal.Text = "totall:";
            this.lbtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbtotal.UseCompatibleTextRendering = true;
            this.lbtotal.UseVisualStyleBackColor = true;
            // 
            // lbpaid
            // 
            this.lbpaid.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbpaid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            this.lbpaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpaid.Location = new System.Drawing.Point(0, 60);
            this.lbpaid.Name = "lbpaid";
            this.lbpaid.Size = new System.Drawing.Size(191, 60);
            this.lbpaid.TabIndex = 2;
            this.lbpaid.Text = "paid:";
            this.lbpaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbpaid.UseCompatibleTextRendering = true;
            this.lbpaid.UseVisualStyleBackColor = true;
            // 
            // lbstill
            // 
            this.lbstill.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbstill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));
            this.lbstill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbstill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstill.Location = new System.Drawing.Point(0, 120);
            this.lbstill.Name = "lbstill";
            this.lbstill.Size = new System.Drawing.Size(191, 60);
            this.lbstill.TabIndex = 3;
            this.lbstill.Text = "still:";
            this.lbstill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbstill.UseCompatibleTextRendering = true;
            this.lbstill.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(938, 566);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panellabels);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "home";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartmoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartdays)).EndInit();
            this.panellabels.ResumeLayout(false);
            this.panellabels.PerformLayout();
            this.panelbtns.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartmoney;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbenrolls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbcourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbstudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Panel panelmain;
        private Panel panellabels;
        private Panel panelbtns;
        private Button btnAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartdays;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DateTimePicker DateEnd;
        private DateTimePicker DateStart;
        private Label label4;
        private Label label2;
        private Button btnlast7;
        private Button btncustom;
        private Button btnthismon;
        private Button btnlastmon;
        private Button btnrefresh;
        private Panel panel4;
        private Button lbstill;
        private Button lbpaid;
        private Button lbtotal;
    }
}