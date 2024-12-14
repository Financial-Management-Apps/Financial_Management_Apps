﻿using FrmManhinhchinh.Utils;
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
    public partial class tongquantienchi : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string connectionString = "Data Source=DESKTOP-6DJ3LQS\\VINHPHU;Initial Catalog=QLCT03;"
             + "Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public tongquantienchi()
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
                    string queryChi = "SELECT DAY(ThoiGian) AS Ngay, SUM(-SoTien) AS SoTien " +
                                        "FROM ChiTieu " +
                                        "WHERE DanhMucID = '4' AND LoaiID = '2' AND NDID = @UserID " +
                                         "GROUP BY DAY(ThoiGian)";
                    using (SqlCommand commandChi = new SqlCommand(queryChi, connection))
                    {
                        commandChi.Parameters.AddWithValue("@UserID", Constants.UserID);
                        SqlDataAdapter adapterChi = new SqlDataAdapter(commandChi);
                        DataTable tableChi = new DataTable();
                        adapterChi.Fill(tableChi);
                        Series seriesChi = chart1.Series.Add("Mua sắm");
                        seriesChi.Points.DataBind(tableChi.AsEnumerable(), "Ngay", "SoTien", "");
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
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryChi = "SELECT DAY(ThoiGian) AS Ngay, SUM(-SoTien) AS SoTien " +
                                        "FROM ChiTieu " +
                                        "WHERE DanhMucID = '2' AND LoaiID = '2' AND NDID = @UserID " +
                                         "GROUP BY DAY(ThoiGian)";
                    using (SqlCommand commandChi = new SqlCommand(queryChi, connection))
                    {
                        commandChi.Parameters.AddWithValue("@UserID", Constants.UserID);
                        SqlDataAdapter adapterChi = new SqlDataAdapter(commandChi);
                        DataTable tableChi = new DataTable();
                        adapterChi.Fill(tableChi);
                        Series seriesChi = chart1.Series.Add("Ăn uống");
                        seriesChi.Points.DataBind(tableChi.AsEnumerable(), "Ngay", "SoTien", "");
                        seriesChi.ChartType = SeriesChartType.Line;
                        seriesChi.Color = Color.Blue;
                        chart1.DataBind();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryChi = "SELECT DAY(ThoiGian) AS Ngay, SUM(-SoTien) AS SoTien " +
                                        "FROM ChiTieu " +
                                        "WHERE DanhMucID = '3' AND LoaiID = '2' AND NDID = @UserID " +
                                         "GROUP BY DAY(ThoiGian)";
                    using (SqlCommand commandChi = new SqlCommand(queryChi, connection))
                    {
                        commandChi.Parameters.AddWithValue("@UserID", Constants.UserID);
                        SqlDataAdapter adapterChi = new SqlDataAdapter(commandChi);
                        DataTable tableChi = new DataTable();
                        adapterChi.Fill(tableChi);
                        Series seriesChi = chart1.Series.Add("Bạn bè");
                        seriesChi.Points.DataBind(tableChi.AsEnumerable(), "Ngay", "SoTien", "");
                        seriesChi.ChartType = SeriesChartType.Line;
                        seriesChi.Color = Color.Orange;
                        chart1.DataBind();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryChi = "SELECT DAY(ThoiGian) AS Ngay, SUM(-SoTien) AS SoTien " +
                                        "FROM ChiTieu " +
                                        "WHERE DanhMucID = '1' AND LoaiID = '2' AND NDID = @UserID " +
                                         "GROUP BY DAY(ThoiGian)";
                    using (SqlCommand commandChi = new SqlCommand(queryChi, connection))
                    {
                        commandChi.Parameters.AddWithValue("@UserID", Constants.UserID);
                        SqlDataAdapter adapterChi = new SqlDataAdapter(commandChi);
                        DataTable tableChi = new DataTable();
                        adapterChi.Fill(tableChi);
                        Series seriesChi = chart1.Series.Add("Phương tiện");
                        seriesChi.Points.DataBind(tableChi.AsEnumerable(), "Ngay", "SoTien", "");
                        seriesChi.ChartType = SeriesChartType.Line;
                        seriesChi.Color = Color.Green;
                        chart1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryChi = "SELECT DAY(ThoiGian) AS Ngay, SUM(-SoTien) AS SoTien " +
                                        "FROM ChiTieu " +
                                        "WHERE DanhMucID = '5' AND LoaiID = '2' AND NDID = @UserID " +
                                         "GROUP BY DAY(ThoiGian)";
                    using (SqlCommand commandChi = new SqlCommand(queryChi, connection))
                    {
                        commandChi.Parameters.AddWithValue("@UserID", Constants.UserID);
                        SqlDataAdapter adapterChi = new SqlDataAdapter(commandChi);
                        DataTable tableChi = new DataTable();
                        adapterChi.Fill(tableChi);
                        Series seriesChi = chart1.Series.Add("Tiền nhà/phòng");
                        seriesChi.Points.DataBind(tableChi.AsEnumerable(), "Ngay", "SoTien", "");
                        seriesChi.ChartType = SeriesChartType.Line;
                        seriesChi.Color = Color.Black;
                        chart1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryChi = "SELECT DAY(ThoiGian) AS Ngay, SUM(-SoTien) AS SoTien " +
                                        "FROM ChiTieu " +
                                        "WHERE DanhMucID = '6' AND LoaiID = '2' AND NDID = @UserID " +
                                         "GROUP BY DAY(ThoiGian)";
                    using (SqlCommand commandChi = new SqlCommand(queryChi, connection))
                    {
                        commandChi.Parameters.AddWithValue("@UserID", Constants.UserID);
                        SqlDataAdapter adapterChi = new SqlDataAdapter(commandChi);
                        DataTable tableChi = new DataTable();
                        adapterChi.Fill(tableChi);
                        Series seriesChi = chart1.Series.Add("Tiền điện");
                        seriesChi.Points.DataBind(tableChi.AsEnumerable(), "Ngay", "SoTien", "");
                        seriesChi.ChartType = SeriesChartType.Line;
                        seriesChi.Color = Color.Black;
                        chart1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryChi = "SELECT DAY(ThoiGian) AS Ngay, SUM(-SoTien) AS SoTien " +
                                        "FROM ChiTieu " +
                                        "WHERE DanhMucID = '7' AND LoaiID = '2' AND NDID = @UserID " +
                                         "GROUP BY DAY(ThoiGian)";
                    using (SqlCommand commandChi = new SqlCommand(queryChi, connection))
                    {
                        commandChi.Parameters.AddWithValue("@UserID", Constants.UserID);
                        SqlDataAdapter adapterChi = new SqlDataAdapter(commandChi);
                        DataTable tableChi = new DataTable();
                        adapterChi.Fill(tableChi);
                        Series seriesChi = chart1.Series.Add("Tiền nước");
                        seriesChi.Points.DataBind(tableChi.AsEnumerable(), "Ngay", "SoTien", "");
                        seriesChi.ChartType = SeriesChartType.Line;
                        seriesChi.Color = Color.Black;
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
