namespace FrmManhinhchinh
{
    partial class Dangnhap
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtMK = new TextBox();
            txtTK = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            btnDangnhap = new Button();
            button2 = new Button();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            btnExit = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(863, 517);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Turquoise;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 22);
            label1.Name = "label1";
            label1.Size = new Size(215, 41);
            label1.TabIndex = 2;
            label1.Text = "PHẦN MỀM ";
            // 
            // txtMK
            // 
            txtMK.BackColor = Color.LightGray;
            txtMK.BorderStyle = BorderStyle.None;
            txtMK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMK.Location = new Point(13, 12);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(203, 22);
            txtMK.TabIndex = 3;
            txtMK.UseSystemPasswordChar = true;
            // 
            // txtTK
            // 
            txtTK.BackColor = Color.LightGray;
            txtTK.BorderStyle = BorderStyle.None;
            txtTK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTK.Location = new Point(13, 9);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(203, 22);
            txtTK.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(53, 45, 125);
            label2.Location = new Point(483, 45);
            label2.Name = "label2";
            label2.Size = new Size(204, 45);
            label2.TabIndex = 5;
            label2.Text = "ĐĂNG NHẬP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(txtTK);
            panel1.Location = new Point(497, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 47);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(txtMK);
            panel2.Location = new Point(497, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 47);
            panel2.TabIndex = 7;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 35;
            bunifuElipse1.TargetControl = panel1;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 35;
            bunifuElipse2.TargetControl = panel2;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = Color.Turquoise;
            btnDangnhap.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDangnhap.ForeColor = Color.Black;
            btnDangnhap.Location = new Point(400, 288);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(146, 51);
            btnDangnhap.TabIndex = 8;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(579, 381);
            button2.Name = "button2";
            button2.Size = new Size(149, 47);
            button2.TabIndex = 9;
            button2.Text = "Đăng ký";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Turquoise;
            label4.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(39, 80);
            label4.Name = "label4";
            label4.Size = new Size(299, 37);
            label4.TabIndex = 16;
            label4.Text = "QUẢN LÝ CHI TIÊU";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Turquoise;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 129);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(310, 299);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(419, 140);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 18;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(400, 200);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 19;
            label6.Text = "Mật khẩu";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Turquoise;
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(580, 288);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(148, 51);
            btnExit.TabIndex = 20;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(400, 395);
            label7.Name = "label7";
            label7.Size = new Size(172, 21);
            label7.TabIndex = 22;
            label7.Text = "Bạn chưa có tài khoản ?";
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(756, 452);
            Controls.Add(label7);
            Controls.Add(btnExit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(btnDangnhap);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtMK;
        private TextBox txtTK;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Button btnDangnhap;
        private Button button2;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private Button btnExit;
        private Label label7;
    }
}