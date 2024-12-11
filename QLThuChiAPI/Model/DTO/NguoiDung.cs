namespace QLThuChiAPI.Model.DTO
{
    public class NguoiDung
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateOnly NgaySinh { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Password { get; set; }
        public int Vi { get; set; }
    }
}
