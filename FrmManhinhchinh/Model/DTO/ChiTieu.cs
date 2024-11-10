using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmManhinhchinh.Model.DTO
{
    public class ChiTieu
    {
        public int ID { get; set; }
        //public int NDID { get; set; }
        public string? Loai { get; set; }
        public DateOnly ThoiGian { get; set; }
        public string? GhiChu { get; set; }
        public int SoTien { get; set; }
        public string? DanhMuc { get; set; }
    }
}
