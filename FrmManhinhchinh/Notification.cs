using FrmManhinhchinh.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FrmManhinhchinh
{
    public partial class Notification : Form
    {
        private QLCTDAO con;
      
        private int currentUserId = 1;
        public Notification()
        {
            InitializeComponent();
            con = new QLCTDAO();
        }
        private void Notification_Load(object sender, EventArgs e)
        {
            InitializeDgvNotifications();
            LoadNotifications();
        }
        private void InitializeDgvNotifications()
        {
            dgvNotifications.Columns.Clear();
            dgvNotifications.Columns.Add("NotificationId", "ID");
            dgvNotifications.Columns.Add("Message", "Nội dung");
            dgvNotifications.Columns.Add("CreatedAt", "Thời gian");
            dgvNotifications.Columns.Add("IsRead", "Trạng thái");
        }

        private void LoadNotifications()
        {
            var notifications = con.GetNotifications(1);  

            dgvNotifications.Rows.Clear(); 

            foreach (var notification in notifications)
            {
                // Kiểm tra dữ liệu trước khi thêm
                if (notification != null)
                {
                    dgvNotifications.Rows.Add(
                        notification.NotificationId,                          
                        notification.Message,                                
                        notification.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"), 
                        notification.IsRead ? "Đã xong" : "Chưa xong"           
                    );
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var notification = new ModelTB.DTO.Notification
            {
                UserId = 1,  // ID của người dùng, bạn có thể thay đổi nếu cần
                Message = txtMessage.Text,
                IsRead = false,
                CreatedAt = DateTime.Now
            };

            con.AddNotification(notification);  // Thêm thông báo vào cơ sở dữ liệu
            LoadNotifications();  // Tải lại danh sách thông báo vào DataGridView
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNotifications.SelectedRows.Count > 0)
            {
                // Lấy ID của thông báo từ dòng được chọn
                var notificationId = (int)dgvNotifications.SelectedRows[0].Cells[0].Value;

                con.DeleteNotification(notificationId);  // Xóa thông báo khỏi cơ sở dữ liệu
                LoadNotifications();  // Tải lại danh sách thông báo vào DataGridView
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNotifications.SelectedRows.Count > 0)
            {
                // Lấy ID của thông báo được chọn
                int selectedNotificationId = (int)dgvNotifications.SelectedRows[0].Cells[0].Value;

                // Tạo đối tượng Notification mới với thông tin đã sửa từ TextBox
                var updatedNotification = new ModelTB.DTO.Notification
                {
                    NotificationId = selectedNotificationId,
                    Message = txtMessage.Text,
                    IsRead = false,  // Bạn có thể điều chỉnh lại giá trị này nếu cần
                    CreatedAt = DateTime.Now  // Hoặc bạn có thể giữ nguyên thời gian cũ nếu cần
                };

                // Gọi phương thức để cập nhật thông báo vào cơ sở dữ liệu
                con.UpdateNotification(updatedNotification);

                // Làm mới danh sách thông báo trong DataGridView
                LoadNotifications();

                // Hiển thị thông báo thành công
                MessageBox.Show("Cập nhật thông báo thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông báo để cập nhật.");
            }
        }
        // Đánh dấu thông báo đã đọc
        private void btnMarkAsRead_Click(object sender, EventArgs e)
        {
            if (dgvNotifications.SelectedRows.Count > 0)
            {
                // Lấy ID của thông báo từ dòng được chọn
                var notificationId = (int)dgvNotifications.SelectedRows[0].Cells[0].Value;

                con.MarkAsRead(notificationId);  // Đánh dấu thông báo là đã đọc trong cơ sở dữ liệu
                LoadNotifications();  // Tải lại danh sách thông báo vào DataGridView
            }
        }
    }
}
