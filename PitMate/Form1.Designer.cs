namespace PitMate
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(12D, 14D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(16D, 20D);
            this.CarSelect = new System.Windows.Forms.Button();
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblSetupName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.udLf = new System.Windows.Forms.NumericUpDown();
            this.udRf = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.udLr = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.udRr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.udTrackTemp = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddReading = new System.Windows.Forms.Button();
            this.chtPressures = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnUpdateGraph = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveReading = new System.Windows.Forms.Button();
            this.lbxReadings = new System.Windows.Forms.ListBox();
            this.btnEditReading = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.udEditLF = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.udEditRF = new System.Windows.Forms.NumericUpDown();
            this.udEditTT = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.udEditLR = new System.Windows.Forms.NumericUpDown();
            this.udEditRR = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSetStrats = new System.Windows.Forms.Button();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudFuel = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.cbxSetTyre = new System.Windows.Forms.CheckBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.udLf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTrackTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPressures)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udEditLF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEditRF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEditTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEditLR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEditRR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // CarSelect
            // 
            this.CarSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CarSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarSelect.ForeColor = System.Drawing.Color.White;
            this.CarSelect.Location = new System.Drawing.Point(688, 17);
            this.CarSelect.Name = "CarSelect";
            this.CarSelect.Size = new System.Drawing.Size(228, 42);
            this.CarSelect.TabIndex = 0;
            this.CarSelect.Text = "Open Setup";
            this.CarSelect.UseVisualStyleBackColor = false;
            this.CarSelect.Click += new System.EventHandler(this.CarSelect_Click);
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.Location = new System.Drawing.Point(688, 113);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(95, 24);
            this.lblCarName.TabIndex = 2;
            this.lblCarName.Text = "Car Name";
            // 
            // lblSetupName
            // 
            this.lblSetupName.AutoSize = true;
            this.lblSetupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetupName.Location = new System.Drawing.Point(688, 137);
            this.lblSetupName.Name = "lblSetupName";
            this.lblSetupName.Size = new System.Drawing.Size(115, 24);
            this.lblSetupName.TabIndex = 3;
            this.lblSetupName.Text = "Setup Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Left Front";
            // 
            // udLf
            // 
            this.udLf.DecimalPlaces = 1;
            this.udLf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udLf.Location = new System.Drawing.Point(131, 42);
            this.udLf.Name = "udLf";
            this.udLf.Size = new System.Drawing.Size(120, 20);
            this.udLf.TabIndex = 5;
            this.udLf.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.udLf.ValueChanged += new System.EventHandler(this.udLf_ValueChanged);
            // 
            // udRf
            // 
            this.udRf.DecimalPlaces = 1;
            this.udRf.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udRf.Location = new System.Drawing.Point(131, 68);
            this.udRf.Name = "udRf";
            this.udRf.Size = new System.Drawing.Size(120, 20);
            this.udRf.TabIndex = 7;
            this.udRf.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.udRf.ValueChanged += new System.EventHandler(this.udRf_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Right Front";
            // 
            // udLr
            // 
            this.udLr.DecimalPlaces = 1;
            this.udLr.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udLr.Location = new System.Drawing.Point(131, 94);
            this.udLr.Name = "udLr";
            this.udLr.Size = new System.Drawing.Size(120, 20);
            this.udLr.TabIndex = 9;
            this.udLr.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.udLr.ValueChanged += new System.EventHandler(this.udLr_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Left Rear";
            // 
            // udRr
            // 
            this.udRr.DecimalPlaces = 1;
            this.udRr.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udRr.Location = new System.Drawing.Point(131, 120);
            this.udRr.Name = "udRr";
            this.udRr.Size = new System.Drawing.Size(120, 20);
            this.udRr.TabIndex = 11;
            this.udRr.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.udRr.ValueChanged += new System.EventHandler(this.udRr_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Right Rear";
            // 
            // udTrackTemp
            // 
            this.udTrackTemp.Location = new System.Drawing.Point(131, 18);
            this.udTrackTemp.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.udTrackTemp.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.udTrackTemp.Name = "udTrackTemp";
            this.udTrackTemp.Size = new System.Drawing.Size(120, 20);
            this.udTrackTemp.TabIndex = 13;
            this.udTrackTemp.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.udTrackTemp.ValueChanged += new System.EventHandler(this.udTrackTemp_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Track temp(c)";
            // 
            // btnAddReading
            // 
            this.btnAddReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReading.ForeColor = System.Drawing.Color.White;
            this.btnAddReading.Location = new System.Drawing.Point(10, 146);
            this.btnAddReading.Name = "btnAddReading";
            this.btnAddReading.Size = new System.Drawing.Size(241, 38);
            this.btnAddReading.TabIndex = 14;
            this.btnAddReading.Text = "Add Reading";
            this.btnAddReading.UseVisualStyleBackColor = false;
            this.btnAddReading.Click += new System.EventHandler(this.btnAddReading_Click);
            // 
            // chtPressures
            // 
            this.chtPressures.BackColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.Interval = 2D;
            chartArea1.AxisX.Maximum = 45D;
            chartArea1.AxisX.Minimum = 15D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.Title = "Track Temp";
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.Maximum = 28D;
            chartArea1.AxisY.Minimum = 24D;
            chartArea1.AxisY.Title = "Cold Pressure";
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chtPressures.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtPressures.Legends.Add(legend1);
            this.chtPressures.Location = new System.Drawing.Point(-1, 214);
            this.chtPressures.Name = "chtPressures";
            series1.BackSecondaryColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelBackColor = System.Drawing.Color.Gray;
            series1.LabelBorderColor = System.Drawing.Color.Gray;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.SystemColors.ControlDark;
            series1.Name = "Series1";
            dataPoint1.LabelBackColor = System.Drawing.Color.Gray;
            dataPoint1.LabelBorderColor = System.Drawing.Color.Gray;
            dataPoint2.LabelBackColor = System.Drawing.Color.Gray;
            dataPoint2.LabelBorderColor = System.Drawing.Color.Gray;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chtPressures.Series.Add(series1);
            this.chtPressures.Size = new System.Drawing.Size(917, 345);
            this.chtPressures.TabIndex = 15;
            this.chtPressures.Text = "chart1";
            // 
            // btnUpdateGraph
            // 
            this.btnUpdateGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGraph.ForeColor = System.Drawing.Color.White;
            this.btnUpdateGraph.Location = new System.Drawing.Point(688, 65);
            this.btnUpdateGraph.Name = "btnUpdateGraph";
            this.btnUpdateGraph.Size = new System.Drawing.Size(228, 42);
            this.btnUpdateGraph.TabIndex = 16;
            this.btnUpdateGraph.Text = "Clear Readings";
            this.btnUpdateGraph.UseVisualStyleBackColor = false;
            this.btnUpdateGraph.Click += new System.EventHandler(this.btnUpdateGraph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddReading);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.udLf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.udRf);
            this.groupBox1.Controls.Add(this.udTrackTemp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.udLr);
            this.groupBox1.Controls.Add(this.udRr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 196);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Reading";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveReading);
            this.groupBox2.Controls.Add(this.lbxReadings);
            this.groupBox2.Controls.Add(this.btnEditReading);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.udEditLF);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.udEditRF);
            this.groupBox2.Controls.Add(this.udEditTT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.udEditLR);
            this.groupBox2.Controls.Add(this.udEditRR);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(281, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 196);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Reading";
            // 
            // btnRemoveReading
            // 
            this.btnRemoveReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoveReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveReading.ForeColor = System.Drawing.Color.White;
            this.btnRemoveReading.Location = new System.Drawing.Point(272, 146);
            this.btnRemoveReading.Name = "btnRemoveReading";
            this.btnRemoveReading.Size = new System.Drawing.Size(121, 38);
            this.btnRemoveReading.TabIndex = 16;
            this.btnRemoveReading.Text = "Remove";
            this.btnRemoveReading.UseVisualStyleBackColor = false;
            this.btnRemoveReading.Click += new System.EventHandler(this.btnRemoveReading_Click);
            // 
            // lbxReadings
            // 
            this.lbxReadings.FormattingEnabled = true;
            this.lbxReadings.Location = new System.Drawing.Point(12, 17);
            this.lbxReadings.Name = "lbxReadings";
            this.lbxReadings.Size = new System.Drawing.Size(124, 160);
            this.lbxReadings.TabIndex = 15;
            this.lbxReadings.SelectedIndexChanged += new System.EventHandler(this.lbxReadings_SelectedIndexChanged);
            // 
            // btnEditReading
            // 
            this.btnEditReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReading.ForeColor = System.Drawing.Color.White;
            this.btnEditReading.Location = new System.Drawing.Point(150, 146);
            this.btnEditReading.Name = "btnEditReading";
            this.btnEditReading.Size = new System.Drawing.Size(121, 38);
            this.btnEditReading.TabIndex = 14;
            this.btnEditReading.Text = "Edit";
            this.btnEditReading.UseVisualStyleBackColor = false;
            this.btnEditReading.Click += new System.EventHandler(this.btnEditReading_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Left Front";
            // 
            // udEditLF
            // 
            this.udEditLF.DecimalPlaces = 1;
            this.udEditLF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udEditLF.Location = new System.Drawing.Point(271, 40);
            this.udEditLF.Name = "udEditLF";
            this.udEditLF.Size = new System.Drawing.Size(120, 20);
            this.udEditLF.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Right Front";
            // 
            // udEditRF
            // 
            this.udEditRF.DecimalPlaces = 1;
            this.udEditRF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udEditRF.Location = new System.Drawing.Point(271, 66);
            this.udEditRF.Name = "udEditRF";
            this.udEditRF.Size = new System.Drawing.Size(120, 20);
            this.udEditRF.TabIndex = 7;
            // 
            // udEditTT
            // 
            this.udEditTT.DecimalPlaces = 1;
            this.udEditTT.Location = new System.Drawing.Point(271, 16);
            this.udEditTT.Name = "udEditTT";
            this.udEditTT.Size = new System.Drawing.Size(120, 20);
            this.udEditTT.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(146, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Left Rear";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(146, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Track temp(c)";
            // 
            // udEditLR
            // 
            this.udEditLR.DecimalPlaces = 1;
            this.udEditLR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udEditLR.Location = new System.Drawing.Point(271, 92);
            this.udEditLR.Name = "udEditLR";
            this.udEditLR.Size = new System.Drawing.Size(120, 20);
            this.udEditLR.TabIndex = 9;
            // 
            // udEditRR
            // 
            this.udEditRR.DecimalPlaces = 1;
            this.udEditRR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udEditRR.Location = new System.Drawing.Point(271, 118);
            this.udEditRR.Name = "udEditRR";
            this.udEditRR.Size = new System.Drawing.Size(120, 20);
            this.udEditRR.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(146, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Right Rear";
            // 
            // btnSetStrats
            // 
            this.btnSetStrats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetStrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetStrats.ForeColor = System.Drawing.Color.White;
            this.btnSetStrats.Location = new System.Drawing.Point(688, 166);
            this.btnSetStrats.Name = "btnSetStrats";
            this.btnSetStrats.Size = new System.Drawing.Size(228, 42);
            this.btnSetStrats.TabIndex = 20;
            this.btnSetStrats.Text = "Set Pit Strats";
            this.btnSetStrats.UseVisualStyleBackColor = false;
            this.btnSetStrats.Click += new System.EventHandler(this.btnSetStrats_Click);
            // 
            // nudOffset
            // 
            this.nudOffset.Location = new System.Drawing.Point(1109, 17);
            this.nudOffset.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(69, 20);
            this.nudOffset.TabIndex = 15;
            this.nudOffset.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(953, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Strat Offset";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(953, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Fuel to add";
            // 
            // nudFuel
            // 
            this.nudFuel.Location = new System.Drawing.Point(1109, 95);
            this.nudFuel.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudFuel.Name = "nudFuel";
            this.nudFuel.Size = new System.Drawing.Size(69, 20);
            this.nudFuel.TabIndex = 22;
            this.nudFuel.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(953, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Front pad";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1109, 121);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(953, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 24);
            this.label14.TabIndex = 27;
            this.label14.Text = "Rear pad";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(1109, 147);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown2.TabIndex = 26;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxSetTyre
            // 
            this.cbxSetTyre.AutoSize = true;
            this.cbxSetTyre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbxSetTyre.Location = new System.Drawing.Point(957, 169);
            this.cbxSetTyre.Name = "cbxSetTyre";
            this.cbxSetTyre.Size = new System.Drawing.Size(120, 28);
            this.cbxSetTyre.TabIndex = 28;
            this.cbxSetTyre.Text = "Set tyre set";
            this.cbxSetTyre.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(1109, 173);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown3.TabIndex = 29;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.checkBox1.Location = new System.Drawing.Point(957, 192);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 28);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Increment tyre set ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(953, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 24);
            this.label15.TabIndex = 32;
            this.label15.Text = "Increment step";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(1109, 220);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown4.TabIndex = 31;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(953, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 24);
            this.label16.TabIndex = 34;
            this.label16.Text = "Strat min temp";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(1109, 43);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown5.TabIndex = 33;
            this.numericUpDown5.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(953, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 24);
            this.label17.TabIndex = 36;
            this.label17.Text = "Strat max temp";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(1109, 69);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown6.TabIndex = 35;
            this.numericUpDown6.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1190, 558);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.cbxSetTyre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nudFuel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudOffset);
            this.Controls.Add(this.btnSetStrats);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdateGraph);
            this.Controls.Add(this.chtPressures);
            this.Controls.Add(this.lblSetupName);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.CarSelect);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "PitMate";
            ((System.ComponentModel.ISupportInitialize)(this.udLf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTrackTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPressures)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udEditLF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEditRF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEditTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEditLR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEditRR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CarSelect;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblSetupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udLf;
        private System.Windows.Forms.NumericUpDown udRf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udLr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown udRr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown udTrackTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddReading;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPressures;
        private System.Windows.Forms.Button btnUpdateGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveReading;
        private System.Windows.Forms.ListBox lbxReadings;
        private System.Windows.Forms.Button btnEditReading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown udEditLF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown udEditRF;
        private System.Windows.Forms.NumericUpDown udEditTT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown udEditLR;
        private System.Windows.Forms.NumericUpDown udEditRR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSetStrats;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudFuel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox cbxSetTyre;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
    }
}

