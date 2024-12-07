namespace FrmManhinhchinh
{
    partial class GYCTpopup
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            totalTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rentTextBox = new TextBox();
            experienceTextBox = new TextBox();
            expenseTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            savingTextBox = new TextBox();
            suggestButton = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 63);
            label1.Name = "label1";
            label1.Size = new Size(121, 19);
            label1.TabIndex = 0;
            label1.Text = "Tổng thu nhập";
            // 
            // totalTextBox
            // 
            totalTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalTextBox.Location = new Point(158, 58);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.Size = new Size(170, 29);
            totalTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 199);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(22, 121);
            label3.Name = "label3";
            label3.Size = new Size(109, 19);
            label3.TabIndex = 4;
            label3.Text = "Tiền tiết kiệm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(22, 177);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 5;
            label4.Text = "Tiền nhà";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(22, 227);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 6;
            label5.Text = "Qũy trải nghiệm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(22, 312);
            label6.Name = "label6";
            label6.Size = new Size(193, 19);
            label6.TabIndex = 7;
            label6.Text = "Mức chi tiêu hàng tháng";
            // 
            // rentTextBox
            // 
            rentTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rentTextBox.Location = new Point(158, 172);
            rentTextBox.Name = "rentTextBox";
            rentTextBox.Size = new Size(170, 29);
            rentTextBox.TabIndex = 8;
            // 
            // experienceTextBox
            // 
            experienceTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            experienceTextBox.Location = new Point(22, 262);
            experienceTextBox.Name = "experienceTextBox";
            experienceTextBox.Size = new Size(306, 29);
            experienceTextBox.TabIndex = 9;
            // 
            // expenseTextBox
            // 
            expenseTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expenseTextBox.Location = new Point(22, 355);
            expenseTextBox.Name = "expenseTextBox";
            expenseTextBox.Size = new Size(306, 29);
            expenseTextBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 192);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(188, 192);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 12;
            // 
            // savingTextBox
            // 
            savingTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            savingTextBox.Location = new Point(158, 116);
            savingTextBox.Name = "savingTextBox";
            savingTextBox.Size = new Size(170, 29);
            savingTextBox.TabIndex = 13;
            // 
            // suggestButton
            // 
            suggestButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suggestButton.Location = new Point(86, 420);
            suggestButton.Name = "suggestButton";
            suggestButton.Size = new Size(146, 50);
            suggestButton.TabIndex = 14;
            suggestButton.Text = "Gợi ý";
            suggestButton.UseVisualStyleBackColor = true;
            suggestButton.Click += suggestButton_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(346, 12);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "s1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(443, 491);
            chart1.TabIndex = 15;
            chart1.Text = "chart1";
            // 
            // GYCTpopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(823, 543);
            Controls.Add(chart1);
            Controls.Add(suggestButton);
            Controls.Add(savingTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(expenseTextBox);
            Controls.Add(experienceTextBox);
            Controls.Add(rentTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(totalTextBox);
            Controls.Add(label1);
            Name = "GYCTpopup";
            Text = "GYCTpopup";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox totalTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox rentTextBox;
        private TextBox experienceTextBox;
        private TextBox expenseTextBox;
        private Label label7;
        private Label label8;
        private TextBox savingTextBox;
        private Button suggestButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}