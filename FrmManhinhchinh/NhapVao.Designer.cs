using System.Windows.Forms;
namespace FrmManhinhchinh
{
    partial class NhapVao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnOK = new Button();
            txtTien = new TextBox();
            label4 = new Label();
            txtGhiChu = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            groupBox4 = new GroupBox();
            rbLuong = new RadioButton();
            rbTienPhong = new RadioButton();
            rbMuaSam = new RadioButton();
            rbBanBe = new RadioButton();
            rbAnUong = new RadioButton();
            rbDiLai = new RadioButton();
            groupBox3 = new GroupBox();
            rbChiTieu = new RadioButton();
            rbThuNhap = new RadioButton();
            txtVi = new TextBox();
            button1 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtVi);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(889, 673);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Vào";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOK);
            groupBox2.Controls.Add(txtTien);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtGhiChu);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(38, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(808, 489);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin";
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(695, 426);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 39);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtTien
            // 
            txtTien.Location = new Point(450, 76);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(189, 31);
            txtTien.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 80);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 6;
            label4.Text = "Số Tiền";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(450, 273);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(339, 31);
            txtGhiChu.TabIndex = 5;
            txtGhiChu.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 275);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 4;
            label3.Text = "Ghi Chú";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(450, 175);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(339, 31);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 180);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 2;
            label2.Text = "Thời Gian";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(rbLuong);
            groupBox4.Controls.Add(rbTienPhong);
            groupBox4.Controls.Add(rbMuaSam);
            groupBox4.Controls.Add(rbBanBe);
            groupBox4.Controls.Add(rbAnUong);
            groupBox4.Controls.Add(rbDiLai);
            groupBox4.Location = new Point(53, 203);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(198, 261);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh Mục";
            // 
            // rbLuong
            // 
            rbLuong.AutoSize = true;
            rbLuong.Location = new Point(40, 223);
            rbLuong.Name = "rbLuong";
            rbLuong.Size = new Size(87, 29);
            rbLuong.TabIndex = 4;
            rbLuong.TabStop = true;
            rbLuong.Tag = "6";
            rbLuong.Text = "Lương";
            rbLuong.UseVisualStyleBackColor = true;
            // 
            // rbTienPhong
            // 
            rbTienPhong.AutoSize = true;
            rbTienPhong.Location = new Point(40, 188);
            rbTienPhong.Name = "rbTienPhong";
            rbTienPhong.Size = new Size(130, 29);
            rbTienPhong.TabIndex = 1;
            rbTienPhong.TabStop = true;
            rbTienPhong.Tag = "5";
            rbTienPhong.Text = "Tiền Phòng";
            rbTienPhong.UseVisualStyleBackColor = true;
            // 
            // rbMuaSam
            // 
            rbMuaSam.AutoSize = true;
            rbMuaSam.Location = new Point(40, 153);
            rbMuaSam.Name = "rbMuaSam";
            rbMuaSam.Size = new Size(112, 29);
            rbMuaSam.TabIndex = 3;
            rbMuaSam.TabStop = true;
            rbMuaSam.Tag = "4";
            rbMuaSam.Text = "Mua Sắm";
            rbMuaSam.UseVisualStyleBackColor = true;
            // 
            // rbBanBe
            // 
            rbBanBe.AutoSize = true;
            rbBanBe.Location = new Point(40, 115);
            rbBanBe.Name = "rbBanBe";
            rbBanBe.Size = new Size(93, 29);
            rbBanBe.TabIndex = 2;
            rbBanBe.TabStop = true;
            rbBanBe.Tag = "3";
            rbBanBe.Text = "Bạn Bè";
            rbBanBe.UseVisualStyleBackColor = true;
            // 
            // rbAnUong
            // 
            rbAnUong.AutoSize = true;
            rbAnUong.Location = new Point(40, 77);
            rbAnUong.Name = "rbAnUong";
            rbAnUong.Size = new Size(108, 29);
            rbAnUong.TabIndex = 1;
            rbAnUong.TabStop = true;
            rbAnUong.Tag = "2";
            rbAnUong.Text = "Ăn Uống";
            rbAnUong.UseVisualStyleBackColor = true;
            // 
            // rbDiLai
            // 
            rbDiLai.AutoSize = true;
            rbDiLai.Location = new Point(40, 37);
            rbDiLai.Name = "rbDiLai";
            rbDiLai.Size = new Size(80, 29);
            rbDiLai.TabIndex = 0;
            rbDiLai.TabStop = true;
            rbDiLai.Tag = "1";
            rbDiLai.Text = "Đi Lại";
            rbDiLai.UseVisualStyleBackColor = true;
            rbDiLai.CheckedChanged += rbDiLai_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(rbChiTieu);
            groupBox3.Controls.Add(rbThuNhap);
            groupBox3.Location = new Point(53, 57);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(198, 125);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Loại ";
            // 
            // rbChiTieu
            // 
            rbChiTieu.AutoSize = true;
            rbChiTieu.Location = new Point(41, 87);
            rbChiTieu.Name = "rbChiTieu";
            rbChiTieu.Size = new Size(102, 29);
            rbChiTieu.TabIndex = 1;
            rbChiTieu.TabStop = true;
            rbChiTieu.Tag = "2";
            rbChiTieu.Text = "Chi Tiêu";
            rbChiTieu.UseVisualStyleBackColor = true;
            // 
            // rbThuNhap
            // 
            rbThuNhap.AutoSize = true;
            rbThuNhap.Location = new Point(41, 33);
            rbThuNhap.Name = "rbThuNhap";
            rbThuNhap.Size = new Size(117, 29);
            rbThuNhap.TabIndex = 0;
            rbThuNhap.TabStop = true;
            rbThuNhap.Tag = "1";
            rbThuNhap.Text = "Thu Nhập";
            rbThuNhap.UseVisualStyleBackColor = true;
            // 
            // txtVi
            // 
            txtVi.BorderStyle = BorderStyle.None;
            txtVi.Location = new Point(160, 67);
            txtVi.Name = "txtVi";
            txtVi.Size = new Size(174, 24);
            txtVi.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(154, 56);
            button1.Name = "button1";
            button1.Size = new Size(185, 51);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 67);
            label1.Name = "label1";
            label1.Size = new Size(29, 25);
            label1.TabIndex = 0;
            label1.Text = "Ví";
            label1.Click += label1_Click;
            // 
            // NhapVao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(902, 687);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "NhapVao";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtVi;
        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox txtGhiChu;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label4;
        private TextBox txtTien;
        private RadioButton rbTienPhong;
        private RadioButton rbMuaSam;
        private RadioButton rbBanBe;
        private RadioButton rbAnUong;
        private RadioButton rbDiLai;
        private RadioButton rbChiTieu;
        private RadioButton rbThuNhap;
        private Button btnOK;
        private RadioButton rbLuong;
    }
}
