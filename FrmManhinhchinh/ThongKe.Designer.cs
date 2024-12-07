namespace FrmManhinhchinh
{
    partial class ThongKe
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelhienthi = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(13, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 46);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.Turquoise;
            button4.Dock = DockStyle.Left;
            button4.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button4.Location = new Point(588, 0);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(196, 46);
            button4.TabIndex = 3;
            button4.Text = "Quay Lại ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.Dock = DockStyle.Left;
            button3.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button3.Location = new Point(392, 0);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(196, 46);
            button3.TabIndex = 2;
            button3.Text = "Báo cáo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Dock = DockStyle.Left;
            button2.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button2.Location = new Point(196, 0);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(196, 46);
            button2.TabIndex = 1;
            button2.Text = "Tổng quan tiền chi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.Dock = DockStyle.Left;
            button1.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(196, 46);
            button1.TabIndex = 0;
            button1.Text = "Tổng quan thu chi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelhienthi
            // 
            panelhienthi.BackColor = SystemColors.ButtonFace;
            panelhienthi.Location = new Point(14, 66);
            panelhienthi.Margin = new Padding(4, 3, 4, 3);
            panelhienthi.Name = "panelhienthi";
            panelhienthi.Size = new Size(789, 542);
            panelhienthi.TabIndex = 1;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(830, 620);
            Controls.Add(panelhienthi);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ThongKe";
            Text = "trangchu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelhienthi;
        private System.Windows.Forms.Button button4;
    }
}