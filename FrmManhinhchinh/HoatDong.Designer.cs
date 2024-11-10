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
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
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
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 7);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "BIẾN ĐỘNG SỐ DƯ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtSoTien);
            groupBox1.Controls.Add(txtDanhMuc);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(dpTime);
            groupBox1.Controls.Add(txtLoai);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 63);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(360, 350);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiêt";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(30, 274);
            lblID.Name = "lblID";
            lblID.Size = new Size(23, 19);
            lblID.TabIndex = 15;
            lblID.Text = "ID";
            // 
            // txtGhiChu
            // 
            txtGhiChu.BorderStyle = BorderStyle.None;
            txtGhiChu.Location = new Point(127, 132);
            txtGhiChu.Margin = new Padding(3, 2, 3, 2);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(201, 19);
            txtGhiChu.TabIndex = 4;
            // 
            // txtSoTien
            // 
            txtSoTien.BorderStyle = BorderStyle.None;
            txtSoTien.Location = new Point(125, 186);
            txtSoTien.Margin = new Padding(3, 2, 3, 2);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(203, 19);
            txtSoTien.TabIndex = 5;
            // 
            // txtDanhMuc
            // 
            txtDanhMuc.BorderStyle = BorderStyle.None;
            txtDanhMuc.Enabled = false;
            txtDanhMuc.Location = new Point(117, 236);
            txtDanhMuc.Margin = new Padding(3, 2, 3, 2);
            txtDanhMuc.Name = "txtDanhMuc";
            txtDanhMuc.Size = new Size(203, 19);
            txtDanhMuc.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(246, 304);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 14;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(138, 304);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(25, 304);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dpTime
            // 
            dpTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dpTime.Location = new Point(117, 74);
            dpTime.Margin = new Padding(3, 2, 3, 2);
            dpTime.Name = "dpTime";
            dpTime.Size = new Size(238, 23);
            dpTime.TabIndex = 11;
            // 
            // txtLoai
            // 
            txtLoai.BorderStyle = BorderStyle.None;
            txtLoai.Enabled = false;
            txtLoai.Location = new Point(117, 33);
            txtLoai.Margin = new Padding(3, 2, 3, 2);
            txtLoai.Name = "txtLoai";
            txtLoai.Size = new Size(203, 19);
            txtLoai.TabIndex = 7;
            // 
            // button6
            // 
            button6.Location = new Point(117, 127);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(217, 28);
            button6.TabIndex = 10;
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(117, 236);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(217, 28);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(117, 181);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(217, 28);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 80);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 6;
            label6.Text = "Thời Gian";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 134);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 5;
            label5.Text = "Ghi Chú ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 188);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Số Tiền ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 244);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Danh Mục";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(117, 28);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(217, 28);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 37);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 0;
            label2.Text = "Loại";
            label2.Click += label2_Click;
            // 
            // btnHoatDong
            // 
            btnHoatDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHoatDong.Location = new Point(375, 44);
            btnHoatDong.Margin = new Padding(3, 2, 3, 2);
            btnHoatDong.Name = "btnHoatDong";
            btnHoatDong.Size = new Size(82, 22);
            btnHoatDong.TabIndex = 2;
            btnHoatDong.Text = "Hoạt động";
            btnHoatDong.UseVisualStyleBackColor = true;
            btnHoatDong.Click += btnHoatDong_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.HighlightText;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = SystemColors.GradientInactiveCaption;
            dataGridView.Location = new Point(375, 78);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(650, 335);
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // HoatDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1036, 458);
            Controls.Add(dataGridView);
            Controls.Add(btnHoatDong);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button button2;
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
        private Button button6;
        private Button button4;
        private Button button3;
        private Label lblID;
    }
}