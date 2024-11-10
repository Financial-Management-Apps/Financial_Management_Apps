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

namespace FrmManhinhchinh
{
    public partial class TTCNpopup : Form
    {
        private NguoiDung currentUser;
        public TTCNpopup(NguoiDung user)
        {
            InitializeComponent();
            currentUser = user;
            HienThiThongTinCaNhan();
        }
        private void HienThiThongTinCaNhan()
        {
            txtHoTen.Text = currentUser.HoTen;
            txtGioiTinh.Text = currentUser.GioiTinh;
            txtNgaySinh.Text = currentUser.NgaySinh.ToString("dd/MM/yyyy");
            txtEmail.Text = currentUser.Email;
            txtDiaChi.Text = currentUser.DiaChi;
            txtPass.Text = currentUser.Password;
        }
        
    }
}
