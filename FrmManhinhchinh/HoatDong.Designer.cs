using System.Windows.Forms;
namespace FrmManhinhchinh
{
    partial class HoatDong
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblID = new Label();
            txtGhiChu = new TextBox();
            txtSoTien = new TextBox();
            txtDanhMuc = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dpTime = new DateTimePicker();
            txtLoai = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnHoatDong = new Button();
            dataGridView = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 12);
            label1.Name = "label1";
            label1.Size = new Size(410, 50);
            label1.TabIndex = 0;
            label1.Text = "CẬP NHẬT GIAO DỊCH";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtSoTien);
            groupBox1.Controls.Add(txtDanhMuc);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(dpTime);
            groupBox1.Controls.Add(txtLoai);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 783);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết giao dịch";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(326, 49);
            lblID.Name = "lblID";
            lblID.Size = new Size(32, 25);
            lblID.TabIndex = 15;
            lblID.Text = "ID";
            // 
            // txtGhiChu
            // 
            txtGhiChu.BorderStyle = BorderStyle.None;
            txtGhiChu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGhiChu.Location = new Point(10, 221);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(406, 109);
            txtGhiChu.TabIndex = 4;
            // 
            // txtSoTien
            // 
            txtSoTien.BorderStyle = BorderStyle.None;
            txtSoTien.Enabled = false;
            txtSoTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoTien.Location = new Point(15, 375);
            txtSoTien.Multiline = true;
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(406, 37);
            txtSoTien.TabIndex = 5;
            // 
            // txtDanhMuc
            // 
            txtDanhMuc.BorderStyle = BorderStyle.None;
            txtDanhMuc.Enabled = false;
            txtDanhMuc.Location = new Point(14, 446);
            txtDanhMuc.Multiline = true;
            txtDanhMuc.Name = "txtDanhMuc";
            txtDanhMuc.Size = new Size(406, 39);
            txtDanhMuc.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(128, 556);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(182, 61);
            btnClear.TabIndex = 14;
            btnClear.Text = "LÀM TRỐNG";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(265, 488);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 59);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(15, 491);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(173, 59);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "CẬP NHẬT";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dpTime
            // 
            dpTime.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dpTime.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dpTime.Location = new Point(11, 152);
            dpTime.Name = "dpTime";
            dpTime.Size = new Size(405, 35);
            dpTime.TabIndex = 11;
            // 
            // txtLoai
            // 
            txtLoai.BorderStyle = BorderStyle.None;
            txtLoai.Enabled = false;
            txtLoai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLoai.Location = new Point(15, 79);
            txtLoai.Multiline = true;
            txtLoai.Name = "txtLoai";
            txtLoai.Size = new Size(246, 39);
            txtLoai.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 121);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 6;
            label6.Text = "Thời Gian";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 190);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 5;
            label5.Text = "Ghi Chú ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 344);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 4;
            label4.Text = "Số tiền giao dịch";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 415);
            label3.Name = "label3";
            label3.Size = new Size(201, 28);
            label3.TabIndex = 3;
            label3.Text = "Danh mục giao dịch";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 48);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 0;
            label2.Text = "Loại giao dịch";
            label2.Click += label2_Click;
            // 
            // btnHoatDong
            // 
            btnHoatDong.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHoatDong.Location = new Point(458, 556);
            btnHoatDong.Name = "btnHoatDong";
            btnHoatDong.Size = new Size(619, 99);
            btnHoatDong.TabIndex = 2;
            btnHoatDong.Text = "Load dữ liệu";
            btnHoatDong.UseVisualStyleBackColor = true;
            btnHoatDong.Click += btnHoatDong_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.HighlightText;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = SystemColors.GradientInactiveCaption;
            dataGridView.Location = new Point(459, 83);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(619, 446);
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // HoatDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1093, 863);
            Controls.Add(dataGridView);
            Controls.Add(btnHoatDong);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "HoatDong";
            Text = "HoatDong";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnHoatDong;
        private DataGridView dataGridView;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtGhiChu;
        private TextBox txtSoTien;
        private TextBox txtDanhMuc;
        private TextBox txtLoai;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private DateTimePicker dpTime;
        private Label lblID;
    }
}