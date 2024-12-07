namespace FrmManhinhchinh
{
    partial class Notification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // Các thành phần giao diện
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnMarkAsRead;
        private System.Windows.Forms.DataGridView dgvNotifications;
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
            txtMessage = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnMarkAsRead = new Button();
            dgvNotifications = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(28, 113);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(359, 184);
            txtMessage.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(28, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 43);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu ghi chú";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(28, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 51);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa ghi chú";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(219, 331);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(197, 43);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa ghi chú";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnMarkAsRead
            // 
            btnMarkAsRead.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMarkAsRead.Location = new Point(219, 395);
            btnMarkAsRead.Name = "btnMarkAsRead";
            btnMarkAsRead.Size = new Size(197, 51);
            btnMarkAsRead.TabIndex = 4;
            btnMarkAsRead.Text = "Đánh dấu đã xong ";
            btnMarkAsRead.UseVisualStyleBackColor = true;
            btnMarkAsRead.Click += btnMarkAsRead_Click;
            // 
            // dgvNotifications
            // 
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotifications.Location = new Point(445, 69);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.Size = new Size(530, 386);
            dgvNotifications.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 69);
            label1.Name = "label1";
            label1.Size = new Size(158, 33);
            label1.TabIndex = 6;
            label1.Text = "Tin ghi chú";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(408, 18);
            label2.Name = "label2";
            label2.Size = new Size(137, 33);
            label2.TabIndex = 7;
            label2.Text = "GHI CHÚ";
            // 
            // Notification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 556);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvNotifications);
            Controls.Add(btnMarkAsRead);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtMessage);
            Name = "Notification";
            Text = "Quản lý ghi chú";
            Load += Notification_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private Label label2;
    }
}