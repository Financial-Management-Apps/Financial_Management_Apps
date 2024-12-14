﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FrmManhinhchinh.Utils; 


namespace FrmManhinhchinh.Data
{
    public enum IncomeType
    {
        Thu,
        Chi
    }
    
    public class Connect
    {
        private string connectionString = "Data Source=DESKTOP-6DJ3LQS\\VINHPHU;Initial Catalog=QLCT03;"
             + "Integrated Security=True;Encrypt=False";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        //phương thức
        
        public List<NguoiDung> NguoiDung(string querry)
        {
            List<NguoiDung> nguoidunglist = new List<NguoiDung>();
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(querry, connection);
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    nguoidunglist.Add(new NguoiDung(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetDateTime(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6)));
                }
                
            }
            return nguoidunglist;
        }
        public void RegisterUser(string HoTen, string GioiTinh, DateTime NgaySinh, string Email, string DiaChi, string Password, string confirmPassword)
        {
            if (Password != confirmPassword)
            {
                // Mật khẩu và xác nhận mật khẩu không khớp
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Thông Báo !");
                
            }

            using (SqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO NguoiDung (HoTen, GioiTinh, NgaySinh,Email,DiaChi,Password) " +
                    "VALUES (@HoTen, @GioiTinh, @NgaySinh,@Email,@DiaChi,@Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HoTen",HoTen);
                    command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@DiaChi", DiaChi);
                    command.Parameters.AddWithValue("@Password", Password);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Đăng ký thành công, tiến hành mở trang đăng nhập
                        Dangnhap dangnhap = new Dangnhap();
                        dangnhap.Show();
                        
                    }
                }
            }
        }
        public int GetTotalIncomeForCategory(int category, IncomeType incomeType)
            {
                int totalIncome = 0;
                using (SqlConnection connection = GetConnection())
                {
                    string query = "SELECT SUM(SoTien) FROM ChiTieu WHERE LoaiID = @Category AND NDID = @UserID ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                    if (incomeType == IncomeType.Thu)
                    {
                        command.Parameters.AddWithValue("@Category", 1);
                    }
                    else if (incomeType == IncomeType.Chi)
                    {
                        command.Parameters.AddWithValue("@Category", 2);
                    }
                    command.Parameters.AddWithValue("@UserID", Constants.UserID);
                    connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalIncome = Convert.ToInt32(result);
                            
                        }
                        
                    }
                }
                return totalIncome;
            }
        public class CategoryExpense
        {
            public int Category { get; set; }
            public int TotalExpense { get; set; }
            public CategoryExpense(int category, int totalExpense)
            {
                Category = category;
                TotalExpense = totalExpense;
            }
        }

        public List<CategoryExpense> GetTotalExpenseByCategory()
        {
            List<CategoryExpense> expensesByCategory = new List<CategoryExpense>();
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT DanhMucID, SUM(SoTien) AS TotalExpense FROM ChiTieu WHERE NDID = @UserID GROUP BY DanhMucID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", Constants.UserID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int category = reader.GetInt32(reader.GetOrdinal("DanhMucID"));
                            int totalExpense = reader.GetInt32(reader.GetOrdinal("TotalExpense"));
                            expensesByCategory.Add(new CategoryExpense(category, totalExpense));
                        }
                    }
                }
            }

            return expensesByCategory;
        }
    }
}