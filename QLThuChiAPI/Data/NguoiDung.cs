using QLThuChiAPI.PWSHA256;

namespace QLThuChiAPI.Data
{
    public class NguoiDung
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Password { get; set; }

        public NguoiDung() { }
        public NguoiDung(int id, string hoTen, string gioiTinh, DateTime ngaySinh, string email, string diaChi, string password)
        {
            ID = id;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Email = email;
            DiaChi = diaChi;
            Password = PasswordHasher.HashPassword(password);
        }
    }
    
}
