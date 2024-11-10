using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FrmManhinhchinh.Model.Command;
using FrmManhinhchinh.Model.DTO;
using FrmManhinhchinh.Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FrmManhinhchinh.Connection
{
    public class QLCTDAO
    {
        public static string connectionString = @"Data Source=LAPTOP-H2SUB5OD\SQLEXPRESS;Initial Catalog=QLCT03;Integrated Security=True;Encrypt=False";

        public QLCTDAO()
        {

        }
        public static List<ChiTieu> GetAllQLCTDAO()
        {
            List<ChiTieu> listChiTieu = new List<ChiTieu>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("select ct.ID, l.Name TenLoai, ct.ThoiGian, ct.GhiChu, ct.SoTien, " +
                "dm.Name TenDanhMuc " +
                "from ChiTieu ct " +
                "   left join Loai l on l.ID = ct.LoaiID " +
                "   left join DanhMuc dm on dm.ID = ct.DanhMucID " +
                "where ct.NDID = @UserID " + 
                "ORDER BY ct.ThoiGian ASC, ct.ID ASC ", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@UserID", Constants.UserID);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    ChiTieu chiTieu = new ChiTieu();
                    chiTieu.ID = (int)reader.GetInt32(0);
                    chiTieu.Loai = (string)reader.GetString(1);
                    DateTime fullDate = reader.GetDateTime(2);
                    chiTieu.ThoiGian = new DateOnly(fullDate.Year, fullDate.Month, fullDate.Day);
                    chiTieu.GhiChu = (string)reader.GetString(3);
                    chiTieu.SoTien = (int)reader.GetInt32(4);
                    chiTieu.DanhMuc = (string)reader.GetString(5);

                    listChiTieu .Add(chiTieu);
                }
            }
            return listChiTieu;
        }
        

        public static void AddQLCT(ChiTieuCreate chiTieuCreate)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            //string sqlQuerry = "insert into ChiTieu(NDID, ThoiGian, GhiChu, SoTien, LoaiID, DanhMucID, Loai, DanhMuc) Values" +
            //    " (@NDID, @ThoiGian, @GhiChu, @SoTien, @LoaiID, @DanhMucID, @Loai, @DanhMuc)";
            
            string sqlQuerry = "insert into ChiTieu(NDID, ThoiGian, GhiChu, SoTien, LoaiID, DanhMucID) Values" +
                " (@NDID, @ThoiGian, @GhiChu, @SoTien, @LoaiID, @DanhMucID)";
            using (SqlCommand command = new SqlCommand(sqlQuerry, sqlConnection))
            {
                // Thay đổi giá trị @Value1, @Value2, @Value3 thành giá trị thực tế bạn muốn chèn vào cơ sở dữ liệu
                command.Parameters.AddWithValue("@NDID", chiTieuCreate.NDID);
                command.Parameters.AddWithValue("@ThoiGian", chiTieuCreate.ThoiGian.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@GhiChu", chiTieuCreate.GhiChu);
                command.Parameters.AddWithValue("@SoTien", chiTieuCreate.SoTien);
                command.Parameters.AddWithValue("@LoaiID", chiTieuCreate.LoaiID);
                command.Parameters.AddWithValue("@DanhMucID", chiTieuCreate.DanhMucID);
                //command.Parameters.AddWithValue("@Loai", chiTieuCreate.Loai);
                //command.Parameters.AddWithValue("@DanhMuc", chiTieuCreate.DanhMuc);

                // Thực thi câu lệnh INSERT
                int rowsAffected = command.ExecuteNonQuery();

                
            }

        }

        public static int GetAmountWallet()
        {
            int amount = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("select Vi from NguoiDung where ID = @UserID", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@UserID", Constants.UserID);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            amount = (int)reader.GetInt32(0);
                        }
                    }
                }

                sqlConnection.Close();
                sqlConnection.Dispose();
            }

            return amount;
        }

        public static void UpdateWallet(int amount)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string sqlQuerry = "update NguoiDung set Vi = Vi + (@Amount) where ID = @UserID";
                using (SqlCommand command = new SqlCommand(sqlQuerry, sqlConnection))
                {
                    // Thay đổi giá trị @Value1, @Value2, @Value3 thành giá trị thực tế bạn muốn chèn vào cơ sở dữ liệu
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@UserID", Constants.UserID);

                    // Thực thi câu lệnh INSERT
                    int rowsAffected = command.ExecuteNonQuery();
                }

                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        public static void DeleteChiTieu(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string sqlQuerry = "delete from ChiTieu where ID = @ID";
                using (SqlCommand command = new SqlCommand(sqlQuerry, sqlConnection))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = command.ExecuteNonQuery();
                }

                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        public static void UpdateQLCT(ChiTieuUpdate chiTieuUpdate)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string sqlQuerry = "update ChiTieu set ThoiGian = @ThoiGian, GhiChu = @GhiChu, SoTien = @SoTien " +
                "where ID = @ID ";
            using (SqlCommand command = new SqlCommand(sqlQuerry, sqlConnection))
            {
                command.Parameters.AddWithValue("@ThoiGian", chiTieuUpdate.ThoiGian.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@GhiChu", chiTieuUpdate.GhiChu);
                command.Parameters.AddWithValue("@SoTien", chiTieuUpdate.SoTien);
                command.Parameters.AddWithValue("@ID", chiTieuUpdate.ID);

                int rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
}
