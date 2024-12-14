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

        private int currentUserId = -1;
        public Notification(int currentUserId)
        {
            InitializeComponent();
            this.currentUserId = currentUserId;
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
            var notifications = con.GetNotifications(currentUserId);
            dgvNotifications.Rows.Clear();
            foreach (var notification in notifications)
            {
                if (notification != null)
                {
                    dgvNotifications.Rows.Add(
                        notification.NotificationId,
                        notification.Message,
                        notification.CreatedAt.ToString("dd-MM-yyyy HH:mm:ss"),
                        notification.IsRead ? "Đã xong" : "Chưa xong"
                    );
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvNotifications.SelectedRows.Count > 0)
            {
                var notificationId = (int)dgvNotifications.SelectedRows[0].Cells[0].Value;
                con.MarkAsRead(notificationId);
                LoadNotifications();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvNotifications.SelectedRows.Count > 0)
            {
                var notificationId = (int)dgvNotifications.SelectedRows[0].Cells[0].Value;
                con.DeleteNotification(notificationId);
                LoadNotifications();
            }
        }

        private void dgvNotifications_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNotifications.SelectedRows.Count > 0)
            {
                var selectedRow = dgvNotifications.SelectedRows[0];
                var notificationContent = selectedRow.Cells["message"].Value?.ToString(); 
                txtMessage.Text = notificationContent;
            }
            else
            {
                txtMessage.Text = string.Empty; 
            }
        }
    }
}
