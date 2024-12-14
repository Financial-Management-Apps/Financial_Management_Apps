namespace FrmManhinhchinh
{
    partial class MTTK
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
            txtMucTieu = new TextBox();
            txtTienTietKiem = new TextBox();
            txtTienDangCo = new TextBox();
            txtNgayHH = new TextBox();
            dgvMT = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMT).BeginInit();
            SuspendLayout();
            // 
            // txtMucTieu
            // 
            txtMucTieu.Location = new Point(139, 88);
            txtMucTieu.Multiline = true;
            txtMucTieu.Name = "txtMucTieu";
            txtMucTieu.Size = new Size(257, 30);
            txtMucTieu.TabIndex = 0;
            // 
            // txtTienTietKiem
            // 
            txtTienTietKiem.Location = new Point(139, 161);
            txtTienTietKiem.Multiline = true;
            txtTienTietKiem.Name = "txtTienTietKiem";
            txtTienTietKiem.Size = new Size(257, 31);
            txtTienTietKiem.TabIndex = 1;
            // 
            // txtTienDangCo
            // 
            txtTienDangCo.Location = new Point(139, 230);
            txtTienDangCo.Multiline = true;
            txtTienDangCo.Name = "txtTienDangCo";
            txtTienDangCo.Size = new Size(257, 32);
            txtTienDangCo.TabIndex = 2;
            // 
            // txtNgayHH
            // 
            txtNgayHH.Location = new Point(139, 293);
            txtNgayHH.Multiline = true;
            txtNgayHH.Name = "txtNgayHH";
            txtNgayHH.Size = new Size(257, 33);
            txtNgayHH.TabIndex = 3;
            // 
            // dgvMT
            // 
            dgvMT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMT.Location = new Point(412, 65);
            dgvMT.Name = "dgvMT";
            dgvMT.Size = new Size(529, 261);
            dgvMT.TabIndex = 4;
            dgvMT.SelectionChanged += dgvMT_SelectionChanged;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnThem.Location = new Point(53, 357);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(171, 52);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm mục tiêu";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnXoa.Location = new Point(350, 358);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(172, 51);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa mục tiêu";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnSua.Location = new Point(614, 360);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(184, 47);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa mục tiêu";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(364, 9);
            label3.Name = "label3";
            label3.Size = new Size(241, 33);
            label3.TabIndex = 49;
            label3.Text = "Mục tiêu tiết kiệm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 50;
            label4.Text = "Mục tiêu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 161);
            label5.Name = "label5";
            label5.Size = new Size(121, 22);
            label5.TabIndex = 51;
            label5.Text = "Tiền tiết kiệm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 230);
            label6.Name = "label6";
            label6.Size = new Size(122, 22);
            label6.TabIndex = 52;
            label6.Text = "Tiền mục tiêu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 293);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 59;
            label2.Text = "Ngày hết hạn";
            // 
            // MTTK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 450);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dgvMT);
            Controls.Add(txtNgayHH);
            Controls.Add(txtTienDangCo);
            Controls.Add(txtTienTietKiem);
            Controls.Add(txtMucTieu);
            Name = "MTTK";
            Text = "MTTK";
            Load += MTTK_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMucTieu;
        private TextBox txtTienTietKiem;
        private TextBox txtTienDangCo;
        private TextBox txtNgayHH;
        private DataGridView dgvMT;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
    }
}