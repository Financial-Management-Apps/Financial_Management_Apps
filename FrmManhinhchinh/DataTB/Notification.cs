using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmManhinhchinh.DataTB
{
        public class Notification
        {
            public int NotificationId { get; set; }
            public int UserId { get; set; }
            public string Message { get; set; }
            public bool IsRead { get; set; }
            public DateTime CreatedAt { get; set; }

            public Notification()
            {

            }
            public Notification(int userId, string message, bool isRead, DateTime createdAt)
            {
                UserId = userId;
                Message = message;
                IsRead = isRead;
                CreatedAt = createdAt;
            }
        }
}

