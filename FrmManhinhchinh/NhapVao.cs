using FrmManhinhchinh.Connection;
using FrmManhinhchinh.Model.Command;
using FrmManhinhchinh.Model.DTO;
using FrmManhinhchinh.Utils;

namespace FrmManhinhchinh
{
    public partial class NhapVao : Form
    {
        public NhapVao()
        {
            InitializeComponent();
            txtVi.Text = QLCTDAO.GetAmountWallet().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rbDiLai.Checked && !rbAnUong.Checked && !rbBanBe.Checked &&
        !rbMuaSam.Checked && !rbTienPhong.Checked && !rbLuong.Checked && !rbNuoc.Checked && !rbDien.Checked)
                {
                    MessageBox.Show("Vui lòng chọn danh mục chi tiêu.");
                    return;
                }

                if (!rbThuNhap.Checked && !rbChiTieu.Checked)
                {
                    MessageBox.Show("Vui lòng chọn loại chi tiêu.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTien.Text) || !int.TryParse(txtTien.Text, out int soTien))
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ.");
                    return;
                }
                if (string.IsNullOrEmpty(txtGhiChu.Text))
                {
                    MessageBox.Show("Vui lòng nhập ghi chú.");
                    return;
                }

                ChiTieuCreate chiTieuCreate = new ChiTieuCreate();
                chiTieuCreate.NDID = Constants.UserID;
                chiTieuCreate.LoaiID = rbThuNhap.Checked ? Convert.ToInt32(rbThuNhap.Tag) : Convert.ToInt32(rbChiTieu.Tag);
                chiTieuCreate.SoTien = chiTieuCreate.LoaiID == 1 ? Convert.ToInt32(txtTien.Text) : Convert.ToInt32(txtTien.Text) * -1;
                DateTime createDate = dateTimePicker1.Value.Date;
                chiTieuCreate.ThoiGian = new DateOnly(createDate.Year, createDate.Month, createDate.Day);
                chiTieuCreate.GhiChu = txtGhiChu.Text;
                //chiTieuCreate.Loai = rbThuNhap.Checked ? rbThuNhap.Text : rbChiTieu.Text;

                if (rbDiLai.Checked)
                {
                    chiTieuCreate.DanhMucID = Convert.ToInt32(rbDiLai.Tag);
                    //chiTieuCreate.DanhMuc = rbDiLai.Text;
                }
                else if (rbAnUong.Checked)
                {
                    chiTieuCreate.DanhMucID = Convert.ToInt32(rbAnUong.Tag);
                    //chiTieuCreate.DanhMuc = rbAnUong.Text;
                }
                else if (rbBanBe.Checked)
                {
                    chiTieuCreate.DanhMucID = Convert.ToInt32(rbBanBe.Tag);
                    //chiTieuCreate.DanhMuc = rbBanBe.Text;
                }
                else if (rbMuaSam.Checked)
                {
                    chiTieuCreate.DanhMucID = Convert.ToInt32(rbMuaSam.Tag);
                    //chiTieuCreate.DanhMuc = rbMuaSam.Text;
                }
                else if (rbTienPhong.Checked)
                {
                    chiTieuCreate.DanhMucID = Convert.ToInt32(rbTienPhong.Tag);
                    //chiTieuCreate.DanhMuc = rbTienDienNuoc.Text;
                }
                else if(rbDien.Checked)
                {
                    chiTieuCreate.DanhMucID = Convert.ToInt32(rbDien.Tag);
                }
                else if (rbNuoc.Checked)
                {
                    chiTieuCreate.DanhMucID = Convert.ToInt32(rbNuoc.Tag);
                }
                else if (rbLuong.Checked)
                {
                    chiTieuCreate.DanhMucID = Convert.ToInt32(rbLuong.Tag);
                }

                QLCTDAO.AddQLCT(chiTieuCreate);

                //Update Vi
                QLCTDAO.UpdateWallet(chiTieuCreate.SoTien);

                txtVi.Text = QLCTDAO.GetAmountWallet().ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show(" Vui long nhap du cac truong du lieu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Da xay ra loi: {ex.Message}");
            }
            finally
            {
                txtTien.Text = "";
                txtGhiChu.Text = "";
                rbThuNhap.Checked = false;
                rbChiTieu.Checked = false;
                rbDiLai.Checked = false;
                rbAnUong.Checked = false;
                rbBanBe.Checked = false;
                rbMuaSam.Checked = false;
                rbTienPhong.Checked = false;
                rbLuong.Checked = false;
                rbDien.Checked = false;
                rbNuoc.Checked = false; 
            }
        }

        private void rbDiLai_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
