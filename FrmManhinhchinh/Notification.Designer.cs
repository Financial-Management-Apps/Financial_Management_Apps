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
            dgvNotifications = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(28, 137);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(382, 200);
            txtMessage.TabIndex = 0;
            // 
            // dgvNotifications
            // 
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotifications.Location = new Point(455, 137);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.Size = new Size(513, 200);
            dgvNotifications.TabIndex = 5;
            dgvNotifications.SelectionChanged += dgvNotifications_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(395, 29);
            label1.Name = "label1";
            label1.Size = new Size(180, 40);
            label1.TabIndex = 6;
            label1.Text = "Thông báo";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            button1.Location = new Point(201, 384);
            button1.Name = "button1";
            button1.Size = new Size(196, 52);
            button1.TabIndex = 64;
            button1.Text = "Đánh dấu đã đọc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            button2.Location = new Point(571, 384);
            button2.Name = "button2";
            button2.Size = new Size(188, 52);
            button2.TabIndex = 65;
            button2.Text = "Xóa thông báo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Notification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 480);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgvNotifications);
            Controls.Add(txtMessage);
            Name = "Notification";
            Text = "Quản lý thông báo";
            Load += Notification_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}