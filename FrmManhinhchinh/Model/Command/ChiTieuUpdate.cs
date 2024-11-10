using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmManhinhchinh.Model.Command
{
    public class ChiTieuUpdate
    {
        public int ID{ get; set; }
        public DateOnly ThoiGian { get; set; }
        public string? GhiChu { get; set; }
        public int SoTien { get; set; }
    }
}
