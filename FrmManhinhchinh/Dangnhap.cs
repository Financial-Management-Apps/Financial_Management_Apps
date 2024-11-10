using FrmManhinhchinh.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using FrmManhinhchinh.PWSHA256;
using FrmManhinhchinh.Utils;

namespace FrmManhinhchinh
{
    public partial class Dangnhap : Form
    {
        private List<NguoiDung> nguoidunglist;
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Length == 0 && txtMK.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống", "Thông Báo !");
            }
            else
            {
                string emailInput = txtTK.Text;
                string passwordInput = txtMK.Text;
                string hashedPassword = PasswordHasher.HashPassword(passwordInput);
                string query = "SELECT * FROM NguoiDung WHERE Email = '" + emailInput + "' AND Password = '" + passwordInput + "'";

                Connect connect = new Connect();
                List<NguoiDung> nguoidungList = connect.NguoiDung(query);

                if (nguoidungList != null && nguoidungList.Any())
                {
                    // Đăng nhập thành công
                    NguoiDung currentUser = nguoidungList.FirstOrDefault() ?? new NguoiDung();
                    Constants.UserID = currentUser.ID;
                    Trangchu trangchu = new Trangchu(currentUser);
                    trangchu.Show();
                    this.Hide();
                }
                else
                {
                    // Hiển thị thông báo lỗi nếu không tìm thấy tài khoản
                    MessageBox.Show("Email hoặc mật khẩu không chính xác !", "Thông Báo");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dangky dangky = new Dangky();
            dangky.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
