using FrmManhinhchinh.Utils;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmManhinhchinh
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            tongquanthuchi tongquanthuchi = new tongquanthuchi();

            
            tongquanthuchi.TopLevel = false;
            tongquanthuchi.Parent = panelhienthi;
            tongquanthuchi.FormBorderStyle = FormBorderStyle.None;
            tongquanthuchi.Dock = DockStyle.Fill;

            // Hiển thị form1
            tongquanthuchi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tongquantienchi tongquantienchi = new tongquantienchi();


            tongquantienchi.TopLevel = false;
            tongquantienchi.Parent = panelhienthi;
            tongquantienchi.FormBorderStyle = FormBorderStyle.None; // ẩn viền của form
            tongquantienchi.Dock = DockStyle.Fill;

            // Hiển thị form1
            tongquantienchi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportToExcel();

        }
        public void ExportToExcel()
        {
            string connectionString = "Data Source=DESKTOP-6DJ3LQS\\VINHPHU;Initial Catalog=QLCT03;"
             + "Integrated Security=True;Encrypt=False";

            string query = "SELECT * FROM ChiTieu WHERE NDID = @UserID ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                command.Parameters.AddWithValue("@UserID", Constants.UserID);
                adapter.Fill(dataTable);

                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    int columnCount = dataTable.Columns.Count;

                    // Ghi dữ liệu từ DataTable vào Excel
                    for (int i = 0; i < columnCount; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                    }

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataTable.Rows[i][j].ToString();
                        }
                    }

                    // Lưu file Excel
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            excelPackage.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
