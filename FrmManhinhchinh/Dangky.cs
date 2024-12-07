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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FrmManhinhchinh
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string HoTen = txtHoTen.Text;
            string GioiTinh = txtGioiTinh.Text;
            DateTime NgaySinh = DateTime.Parse(txtNgaySinh.Text);
            string DiaChi = txtDiaChi.Text;
            string Password = txtPassword.Text;
            string confirmPassword = txtConfirm.Text;
            string Email = txtEmail.Text;
            Connect connect = new Connect();
            connect.RegisterUser(HoTen, GioiTinh, NgaySinh, Email, DiaChi, Password, confirmPassword);
            this.Close();

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            Dangnhap DN = new Dangnhap();
            DN.Show();
            this.Hide();
        }
    }
}
