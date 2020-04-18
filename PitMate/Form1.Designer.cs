﻿namespace PitMate
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(12D, 14D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(16D, 20D);
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
            this.udTrackTemp.DecimalPlaces = 1;
            this.udTrackTemp.Location = new System.Drawing.Point(131, 18);
            this.udTrackTemp.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.udTrackTemp.Minimum = new decimal(new int[] {
            21,
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
            chartArea2.AxisX.Interval = 2D;
            chartArea2.AxisX.Maximum = 42D;
            chartArea2.AxisX.Minimum = 20D;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.Title = "Track Temp";
            chartArea2.AxisY.Interval = 1D;
            chartArea2.AxisY.Maximum = 28D;
            chartArea2.AxisY.Minimum = 24D;
            chartArea2.AxisY.Title = "Cold Pressure";
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 100F;
            this.chtPressures.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtPressures.Legends.Add(legend2);
            this.chtPressures.Location = new System.Drawing.Point(-1, 214);
            this.chtPressures.Name = "chtPressures";
            series2.BackSecondaryColor = System.Drawing.Color.Red;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.LabelBackColor = System.Drawing.Color.Gray;
            series2.LabelBorderColor = System.Drawing.Color.Gray;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.SystemColors.ControlDark;
            series2.Name = "Series1";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.chtPressures.Series.Add(series2);
            this.chtPressures.Size = new System.Drawing.Size(935, 345);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(928, 558);
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
    }
}

