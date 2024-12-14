using FrmManhinhchinh.Data;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using static FrmManhinhchinh.Data.Connect;
using System.Runtime.InteropServices;
namespace FrmManhinhchinh

{
    public partial class Trangchu : Form
    {
        private Connect connect;
        private Form activeForm;
        private NguoiDung currentUser;
        public Trangchu(NguoiDung user)
        {
            InitializeComponent();
            connect = new Connect();
            currentUser = user;
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm; childForm.BringToFront();
            childForm.Show();
        }


        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            try
            {
                // Tính tiền thu và hiển thị
                int totalIncomeThu = connect.GetTotalIncomeForCategory(1, IncomeType.Thu);
                txtThu.Text = totalIncomeThu.ToString();
                // Tính tiền chi và hiển thị
                int totalIncomeChi = connect.GetTotalIncomeForCategory(2, IncomeType.Chi);
                txtChi.Text = totalIncomeChi.ToString();
                int totalBalance = totalIncomeThu + totalIncomeChi;
                txtDu.Text = totalBalance.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                List<CategoryExpense> expensesByCategory = connect.GetTotalExpenseByCategory();

                foreach (var expense in expensesByCategory)
                {
                    switch (expense.Category)
                    {
                        case 2:
                            txtAnuong.Text = expense.TotalExpense.ToString();
                            break;
                        case 5:
                            txtPhong.Text = expense.TotalExpense.ToString();
                            break;
                        case 4:
                            txtMuaSam.Text = expense.TotalExpense.ToString();
                            break;
                        case 1:
                            txtDiLai.Text = expense.TotalExpense.ToString();
                            break;
                        case 3:
                            txtBanBe.Text = expense.TotalExpense.ToString();
                            break;
                        case 6:
                            txtDien.Text = expense.TotalExpense.ToString();
                            break;
                        case 7:
                            txtNuoc.Text = expense.TotalExpense.ToString();
                            break;     
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu từ cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {

            Trangchu trangchu = new Trangchu(currentUser);
            trangchu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new User(currentUser), sender);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Trangchu(currentUser), sender);
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhapVao(), sender);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoatDong(), sender);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe(), sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Dangnhap frmDN = new Dangnhap();
            frmDN.Show();
            this.Close();
        }
    }
}
