using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmManhinhchinh.Model.Command
{
    public class ChiTieuCreate
    {
        public int NDID { get; set; }
        public DateOnly ThoiGian { get; set; }
        public string? GhiChu { get; set; }
        public int SoTien { get; set; }
        public int LoaiID { get; set; }
        public int DanhMucID { get; set; }
        //public string Loai { get; set; }
        //public string DanhMuc { get; set; }
    }
}
