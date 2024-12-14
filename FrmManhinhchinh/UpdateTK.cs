using FrmManhinhchinh.Connection;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmManhinhchinh
{
    public partial class UpdateTK : Form
    {
        public static string con = @"Data Source=DESKTOP-6DJ3LQS\VINHPHU;Initial Catalog=QLCT03;Integrated Security=True;Encrypt=False";

        private int currentUserId = -1;
        public UpdateTK(int id)
        {
            InitializeComponent();
            currentUserId = id;
        }
        private void LoadUserData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    string query = "SELECT HoTen, GioiTinh, NgaySinh, Email, DiaChi, Password, Vi FROM NguoiDung WHERE ID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", currentUserId);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtTen.Text = reader.GetString(reader.GetOrdinal("HoTen"));
                                txtGender.Text = reader.GetString(reader.GetOrdinal("GioiTinh"));
                                txtNgaySinh.Text = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? "" : reader.GetDateTime(reader.GetOrdinal("NgaySinh")).ToString("yyyy-MM-dd");
                                txtEmail.Text = reader.GetString(reader.GetOrdinal("Email"));
                                txtDiaChi.Text = reader.IsDBNull(reader.GetOrdinal("DiaChi")) ? "" : reader.GetString(reader.GetOrdinal("DiaChi"));
                                txtMK.Text = reader.GetString(reader.GetOrdinal("Password"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu người dùng: {ex.Message}");
            }
        }
        public void UpdateAccount(int userId, string hoTen, string gioiTinh, DateTime? ngaySinh, string email, string diaChi, string password)
        {
            string query = "UPDATE NguoiDung SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, Email = @Email, DiaChi = @DiaChi, Password = @Password WHERE ID = @UserID";
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@NgaySinh", (object)ngaySinh ?? DBNull.Value); 
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@DiaChi", (object)diaChi ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Password", password);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Kiểm tra kết quả
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật tài khoản thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản để cập nhật.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật tài khoản: {ex.Message}");
            }
        }

        // Xác thực email
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hoTen = txtTen.Text;
            string gioiTinh = txtGender.Text;
            DateTime? ngaySinh = string.IsNullOrWhiteSpace(txtNgaySinh.Text) ? (DateTime?)null : DateTime.Parse(txtNgaySinh.Text);
            string email = txtEmail.Text;
            string diaChi = txtDiaChi.Text;
            string password = txtMK.Text;
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                return;
            }
            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ.");
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                return;
            }
            UpdateAccount(currentUserId, hoTen, gioiTinh, ngaySinh, email, diaChi, password);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
