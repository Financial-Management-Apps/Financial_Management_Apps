﻿namespace FrmManhinhchinh
{
    partial class tongquantienchi
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
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnhienthi = new Button();
            btnthoat = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = Color.AntiqueWhite;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(5, 19);
            chart1.Margin = new Padding(5, 4, 5, 4);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(661, 458);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // btnhienthi
            // 
            btnhienthi.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnhienthi.Location = new Point(735, 150);
            btnhienthi.Margin = new Padding(5, 4, 5, 4);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(155, 88);
            btnhienthi.TabIndex = 1;
            btnhienthi.Text = "Thống kê";
            btnhienthi.UseVisualStyleBackColor = true;
            btnhienthi.Click += button1_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnthoat.Location = new Point(735, 266);
            btnthoat.Margin = new Padding(5, 4, 5, 4);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(155, 87);
            btnthoat.TabIndex = 2;
            btnthoat.Text = "Thoát mục";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // tongquantienchi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(963, 554);
            Controls.Add(btnthoat);
            Controls.Add(btnhienthi);
            Controls.Add(chart1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "tongquantienchi";
            Text = "tongquantienchi";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btnthoat;
    }
}