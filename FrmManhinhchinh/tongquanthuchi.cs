using FrmManhinhchinh.Utils;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace FrmManhinhchinh
{
    public partial class tongquanthuchi : Form
    {


        SqlConnection connection;
        SqlCommand command;
        string connectionString = "user id=Hoanron_SQLLogin_1;pwd=op1esplwlp;data source=QLCT003.mssql.somee.com;initial catalog=QLCT003;TrustServerCertificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        public tongquanthuchi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string queryThu = "SELECT DAY(ThoiGian) AS Thang, SUM(CASE WHEN LoaiID = 1  THEN SoTien ELSE 0 END) AS SoTien FROM  ChiTieu WHERE NDID = @UserId  GROUP BY  DAY(ThoiGian)";
                    string queryChi = "SELECT DAY(ThoiGian) AS Thang, SUM(-CASE WHEN LoaiID = 2  THEN SoTien ELSE 0 END) AS SoTien FROM  ChiTieu WHERE NDID = @UserId  GROUP BY  DAY(ThoiGian)";


                    using (SqlCommand commandThu = new SqlCommand(queryThu, connection))
                    using (SqlCommand commandChi = new SqlCommand(queryChi, connection))
                    {

                        commandThu.Parameters.AddWithValue("@UserID", Constants.UserID);
                        commandChi.Parameters.AddWithValue("@UserID", Constants.UserID);

                        SqlDataAdapter adapterThu = new SqlDataAdapter(commandThu);
                        SqlDataAdapter adapterChi = new SqlDataAdapter(commandChi);
                        DataTable tableThu = new DataTable();
                        DataTable tableChi = new DataTable();
                        adapterThu.Fill(tableThu);
                        adapterChi.Fill(tableChi);
                        Series seriesThu = chart1.Series.Add("Tien Thu");
                        seriesThu.Points.DataBind(tableThu.AsEnumerable(), "Thang", "SoTien", "");
                        seriesThu.ChartType = SeriesChartType.Line;
                        seriesThu.Color = Color.Blue;
                        Series seriesChi = chart1.Series.Add("Tien Chi");
                        seriesChi.Points.DataBind(tableChi.AsEnumerable(), "Thang", "SoTien", "");
                        seriesChi.ChartType = SeriesChartType.Line;
                        seriesChi.Color = Color.Red;
                        chart1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
