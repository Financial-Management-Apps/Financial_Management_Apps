using FrmManhinhchinh.Connection;
using FrmManhinhchinh.Model.Command;
using FrmManhinhchinh.Model.DTO;
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
    public partial class HoatDong : Form
    {
        BindingSource _supplierBindingSource;
        private string temAmount = "0";

        public HoatDong()
        {
            InitializeComponent();
            lblID.Visible = false;
            _supplierBindingSource = new BindingSource();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int currentRow = dataGridView.CurrentRow.Index;
            lblID.Text = dataGridView.Rows[currentRow].Cells[0].Value.ToString();
            txtLoai.Text = dataGridView.Rows[currentRow].Cells[1].Value.ToString();
            dpTime.Text = dataGridView.Rows[currentRow].Cells[2].Value.ToString();
            txtGhiChu.Text = dataGridView.Rows[currentRow].Cells[3].Value.ToString();
            txtSoTien.Text = dataGridView.Rows[currentRow].Cells[4].Value.ToString();
            txtDanhMuc.Text = dataGridView.Rows[currentRow].Cells[5].Value.ToString();
            temAmount = txtSoTien.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoai.Text = "";
            dpTime.Text = "1990-01-01";
            txtGhiChu.Text = "";
            txtSoTien.Text = "";
            txtDanhMuc.Text = "";
        }

        public void LoadData()
        {
            List<ChiTieu> chiTieus = QLCTDAO.GetAllQLCTDAO();

            _supplierBindingSource.DataSource = chiTieus;
            dataGridView.DataSource = _supplierBindingSource;
        }

        private void btnHoatDong_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(lblID.Text))
            {
                int id = Convert.ToInt32(lblID.Text);

                QLCTDAO.DeleteChiTieu(id);
                QLCTDAO.UpdateWallet(Convert.ToInt32(temAmount) * -1);

                LoadData();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime updateDate = dpTime.Value.Date;

            QLCTDAO.UpdateQLCT(new ChiTieuUpdate
            {
                ID = Convert.ToInt32(lblID.Text),
                ThoiGian = new DateOnly(updateDate.Year, updateDate.Month, updateDate.Day),
                GhiChu = txtGhiChu.Text,
                SoTien = Convert.ToInt32(txtSoTien.Text),
            });

            QLCTDAO.UpdateWallet((-1 * Convert.ToInt32(temAmount)) + Convert.ToInt32(txtSoTien.Text));
            LoadData();
        }
    }
}
