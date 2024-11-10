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
    public partial class GYCTpopup : Form
    {
        public GYCTpopup()
        {
            InitializeComponent();
        }

        private void suggestButton_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ trước khi thêm dữ liệu mới
            chart1.Series["s1"].Points.Clear();

            // Nhập tổng số tiền
            double totalAmount = Convert.ToDouble(totalTextBox.Text);

            // Phần trăm cho từng danh mục
            double savingPercentage = 20;
            double rentPercentage = 30;
            double experiencePercentage = 10;
            double expensePercentage = 40;

            // Tính giá trị cho từng danh mục
            double savingAmount = (savingPercentage / 100) * totalAmount;
            double rentAmount = (rentPercentage / 100) * totalAmount;
            double experienceAmount = (experiencePercentage / 100) * totalAmount;
            double expenseAmount = (expensePercentage / 100) * totalAmount;

            // Hiển thị giá trị trong các ô nhập liệu
            savingTextBox.Text = savingAmount.ToString();
            rentTextBox.Text = rentAmount.ToString();
            experienceTextBox.Text = experienceAmount.ToString();
            expenseTextBox.Text = expenseAmount.ToString();

            // Thêm dữ liệu vào biểu đồ
            chart1.Series["s1"].Points.AddXY("Tiết kiệm", savingAmount);
            chart1.Series["s1"].Points.AddXY("Tiền nhà", rentAmount);
            chart1.Series["s1"].Points.AddXY("Quỹ trải nghiệm", experienceAmount);
            chart1.Series["s1"].Points.AddXY("Chi tiêu hàng tháng", expenseAmount);
        }
    }
}
