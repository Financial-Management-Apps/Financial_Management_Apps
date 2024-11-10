﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmManhinhchinh.Data
{
    public class ThuChi
    {
        [Key]
        public int Id { get; set; }
        public int NDID { get; set; }
        [Required]
        public string Loai {  get; set; }
        public DateTime  ThoiGian { get; set; }
        public string GhiChu { get; set; }

        public int Tien {  get; set; }
        public string DanhMuc { get; set; }
    }
}
