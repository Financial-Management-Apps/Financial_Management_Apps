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
            pictureBox2 = new PictureBox();
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
            label3 = new Label();
            btnExit = new Button();
            button1 = new Button();
            button3 = new Button();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-16, -56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(590, 524);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(495, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(53, 45, 125);
            label1.Font = new Font("Microsoft JhengHei", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 72);
            label1.Name = "label1";
            label1.Size = new Size(241, 45);
            label1.TabIndex = 2;
            label1.Text = "PHẦN MỀM ";
            // 
            // txtMK
            // 
            txtMK.BackColor = Color.LightGray;
            txtMK.BorderStyle = BorderStyle.None;
            txtMK.Location = new Point(22, 18);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(184, 16);
            txtMK.TabIndex = 3;
            txtMK.UseSystemPasswordChar = true;
            // 
            // txtTK
            // 
            txtTK.BackColor = Color.LightGray;
            txtTK.BorderStyle = BorderStyle.None;
            txtTK.Location = new Point(22, 17);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(184, 16);
            txtTK.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(53, 45, 125);
            label2.Location = new Point(473, 134);
            label2.Name = "label2";
            label2.Size = new Size(204, 45);
            label2.TabIndex = 5;
            label2.Text = "ĐĂNG NHẬP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(txtTK);
            panel1.Location = new Point(461, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 47);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(txtMK);
            panel2.Location = new Point(461, 287);
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
            btnDangnhap.BackColor = Color.FromArgb(224, 224, 224);
            btnDangnhap.ForeColor = Color.Black;
            btnDangnhap.Location = new Point(461, 369);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(75, 23);
            btnDangnhap.TabIndex = 8;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(615, 417);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Đăng ký";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 421);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 10;
            label3.Text = "Bạn không có tài khoản ?";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(53, 45, 125);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Transparent;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(49, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(31, 19);
            btnExit.TabIndex = 15;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(53, 45, 125);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(25, 1);
            button1.Name = "button1";
            button1.Size = new Size(27, 19);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(53, 45, 125);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 1);
            button3.Name = "button3";
            button3.Size = new Size(31, 19);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(53, 45, 125);
            label4.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 134);
            label4.Name = "label4";
            label4.Size = new Size(305, 40);
            label4.TabIndex = 16;
            label4.Text = "QUẢN LÝ CHI TIÊU";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(53, 45, 125);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(49, 187);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(187, 163);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(756, 452);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnDangnhap);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
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
        private Label label3;
        private Button btnExit;
        private Button button1;
        private Button button3;
        private Label label4;
        private PictureBox pictureBox3;
    }
}