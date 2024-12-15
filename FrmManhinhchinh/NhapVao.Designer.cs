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
            rbNuoc = new RadioButton();
            rbDien = new RadioButton();
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
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtVi);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1086, 670);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập liệu";
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
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(17, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(950, 564);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(752, 397);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(187, 69);
            btnOK.TabIndex = 1;
            btnOK.Text = "Xác nhận";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtTien
            // 
            txtTien.Location = new Point(505, 101);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(434, 34);
            txtTien.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(355, 107);
            label4.Name = "label4";
            label4.Size = new Size(93, 32);
            label4.TabIndex = 6;
            label4.Text = "Số tiền";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(505, 297);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(434, 85);
            txtGhiChu.TabIndex = 5;
            txtGhiChu.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(355, 297);
            label3.Name = "label3";
            label3.Size = new Size(103, 32);
            label3.TabIndex = 4;
            label3.Text = "Ghi Chú";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(505, 197);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(434, 34);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(355, 197);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 2;
            label2.Text = "Thời gian";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(rbNuoc);
            groupBox4.Controls.Add(rbDien);
            groupBox4.Controls.Add(rbLuong);
            groupBox4.Controls.Add(rbTienPhong);
            groupBox4.Controls.Add(rbMuaSam);
            groupBox4.Controls.Add(rbBanBe);
            groupBox4.Controls.Add(rbAnUong);
            groupBox4.Controls.Add(rbDiLai);
            groupBox4.Location = new Point(53, 197);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(219, 395);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh Mục";
            // 
            // rbNuoc
            // 
            rbNuoc.AutoSize = true;
            rbNuoc.Location = new Point(41, 325);
            rbNuoc.Name = "rbNuoc";
            rbNuoc.Size = new Size(128, 32);
            rbNuoc.TabIndex = 6;
            rbNuoc.TabStop = true;
            rbNuoc.Tag = "7";
            rbNuoc.Text = "Tiền nước";
            rbNuoc.UseVisualStyleBackColor = true;
            // 
            // rbDien
            // 
            rbDien.AutoSize = true;
            rbDien.Location = new Point(40, 287);
            rbDien.Name = "rbDien";
            rbDien.Size = new Size(122, 32);
            rbDien.TabIndex = 5;
            rbDien.TabStop = true;
            rbDien.Tag = "6";
            rbDien.Text = "Tiền điện";
            rbDien.UseVisualStyleBackColor = true;
            // 
            // rbLuong
            // 
            rbLuong.AutoSize = true;
            rbLuong.Location = new Point(40, 192);
            rbLuong.Name = "rbLuong";
            rbLuong.Size = new Size(93, 32);
            rbLuong.TabIndex = 4;
            rbLuong.TabStop = true;
            rbLuong.Tag = "8";
            rbLuong.Text = "Lương";
            rbLuong.UseVisualStyleBackColor = true;
            // 
            // rbTienPhong
            // 
            rbTienPhong.AutoSize = true;
            rbTienPhong.Location = new Point(41, 153);
            rbTienPhong.Name = "rbTienPhong";
            rbTienPhong.Size = new Size(184, 32);
            rbTienPhong.TabIndex = 1;
            rbTienPhong.TabStop = true;
            rbTienPhong.Tag = "5";
            rbTienPhong.Text = "Tiền nhà/phòng";
            rbTienPhong.UseVisualStyleBackColor = true;
            // 
            // rbMuaSam
            // 
            rbMuaSam.AutoSize = true;
            rbMuaSam.Location = new Point(40, 39);
            rbMuaSam.Name = "rbMuaSam";
            rbMuaSam.Size = new Size(121, 32);
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
            rbBanBe.Size = new Size(99, 32);
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
            rbAnUong.Size = new Size(139, 32);
            rbAnUong.TabIndex = 1;
            rbAnUong.TabStop = true;
            rbAnUong.Tag = "2";
            rbAnUong.Text = "Thực phẩm";
            rbAnUong.UseVisualStyleBackColor = true;
            // 
            // rbDiLai
            // 
            rbDiLai.AutoSize = true;
            rbDiLai.Location = new Point(40, 237);
            rbDiLai.Name = "rbDiLai";
            rbDiLai.Size = new Size(150, 32);
            rbDiLai.TabIndex = 0;
            rbDiLai.TabStop = true;
            rbDiLai.Tag = "1";
            rbDiLai.Text = "Phương tiện";
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
            groupBox3.Size = new Size(219, 125);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Loại ";
            // 
            // rbChiTieu
            // 
            rbChiTieu.AutoSize = true;
            rbChiTieu.Location = new Point(40, 87);
            rbChiTieu.Name = "rbChiTieu";
            rbChiTieu.Size = new Size(110, 32);
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
            rbThuNhap.Size = new Size(126, 32);
            rbThuNhap.TabIndex = 0;
            rbThuNhap.TabStop = true;
            rbThuNhap.Tag = "1";
            rbThuNhap.Text = "Thu Nhập";
            rbThuNhap.UseVisualStyleBackColor = true;
            // 
            // txtVi
            // 
            txtVi.BorderStyle = BorderStyle.None;
            txtVi.Enabled = false;
            txtVi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVi.Location = new Point(198, 36);
            txtVi.Multiline = true;
            txtVi.Name = "txtVi";
            txtVi.Size = new Size(384, 43);
            txtVi.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(186, 19);
            button1.Name = "button1";
            button1.Size = new Size(414, 76);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 36);
            label1.Name = "label1";
            label1.Size = new Size(121, 37);
            label1.TabIndex = 0;
            label1.Text = "Số dư ví";
            label1.Click += label1_Click;
            // 
            // NhapVao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1101, 676);
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
        private RadioButton rbNuoc;
        private RadioButton rbDien;
    }
}
