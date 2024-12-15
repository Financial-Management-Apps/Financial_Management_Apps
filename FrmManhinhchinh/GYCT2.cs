using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuatToan;
using ThuatToan.Models;
using System.Windows.Forms.DataVisualization.Charting;
using FrmManhinhchinh.Connection;
using FrmManhinhchinh.Model.DTO;

namespace FrmManhinhchinh
{
    public partial class GYCT2 : Form
    {
        private readonly TT _algorithm;
        private Chart predictionChart;
        private ComboBox categoryComboBox;
        private TextBox resultTextBox;

        public GYCT2()
        {
            InitializeComponent();
            _algorithm = new TT();
            SetupUI();
            InitializeAI();
        }

        private void SetupUI()
        {
            // Setup chart
            predictionChart = new Chart();
            predictionChart.ChartAreas.Add(new ChartArea("PredictionArea"));
            predictionChart.Series.Add(new Series("Historical"));
            predictionChart.Series.Add(new Series("Predicted"));
            predictionChart.Dock = DockStyle.Top;
            predictionChart.Height = 300;

            // Setup category selection
            categoryComboBox = new ComboBox();
            categoryComboBox.Items.AddRange(new string[] { 
                "Đi lại", "Ăn uống", "Bạn bè", "Mua sắm", "Tiền phòng", "Tiền điện", "Tiền nước", "Lương"
            });
            categoryComboBox.Location = new Point(20, 320);
            categoryComboBox.Width = 200;

            // Setup analyze button
            Button analyzeButton = new Button();
            analyzeButton.Text = "Phân tích";
            analyzeButton.Location = new Point(240, 320);
            analyzeButton.Width = 170;
            analyzeButton.Click += new EventHandler(AnalyzeButton_Click);

            // Setup result textbox
            resultTextBox = new TextBox();
            resultTextBox.Multiline = true;
            resultTextBox.Location = new Point(20, 360);
            resultTextBox.Size = new Size(600, 200);
            resultTextBox.ScrollBars = ScrollBars.Vertical;

            // Add controls
            Controls.AddRange(new Control[] { 
                predictionChart, 
                categoryComboBox, 
                analyzeButton, 
                resultTextBox 
            });
        }

        private void InitializeAI()
        {
            try
            {
                var transactions = QLCTDAO.GetAllQLCTDAO();
                var historicalData = transactions
                    .Where(t => t.SoTien > 0) // Filter out zero amounts
                    .Select(t => new FinancialData
                    {
                        CategoryId = GetCategoryId(t.DanhMuc),
                        Amount = Math.Abs(t.SoTien),
                        Date = t.ThoiGian.ToDateTime(TimeOnly.MinValue),
                        IsExpense = t.Loai == "Chi tiêu"
                    })
                    .OrderBy(d => d.Date)
                    .ToList();

                if (historicalData.Count < 1)
                {
                    throw new Exception($"Thiếu dữ liệu: {historicalData.Count} bản");
                }

                _algorithm.TrainModel(historicalData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing AI: {ex.Message}");
            }
        }

        private int GetCategoryId(string categoryName)
        {
            // Map category names to IDs based on your database
            Dictionary<string, int> categoryMap = new Dictionary<string, int>
        {
            {"Đi lại", 1},
            {"Ăn uống", 2},
            {"Bạn bè", 3},
            {"Mua sắm", 4},
            {"Tiền phòng", 5},
            {"Tiền điện", 6 },
            {"Tiền nước", 7 },
            {"Lương", 8}
        };

            return categoryMap.GetValueOrDefault(categoryName, 1); // Default to 1 if not found
        }

        private double GetTotalIncomeForCurrentMonth()
        {
            var transactions = QLCTDAO.GetAllQLCTDAO();
            return transactions
                .Where(t => t.Loai == "Thu nhập" &&
                           t.ThoiGian.Month == DateTime.Now.Month &&
                           t.ThoiGian.Year == DateTime.Now.Year)
                .Sum(t => Math.Abs(t.SoTien));
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn danh mục chi tiêu!");
                    return;
                }

                // Get category ID (add 1 because array index starts at 0)
                int categoryId = categoryComboBox.SelectedIndex + 1;

                // Get current total income
                var currentIncome = GetTotalIncomeForCurrentMonth();

                // Get prediction
                var transactions = QLCTDAO.GetAllQLCTDAO();
                var categoryData = transactions
                    .Where(t => GetCategoryId(t.DanhMuc) == categoryId)
                    .ToList();

            // Get prediction
                var prediction = _algorithm.PredictSpending(DateTime.Now, categoryId, currentIncome);

                if (prediction != null)
                {
                    UpdateChart(categoryId, prediction);
                    UpdateResults(prediction);
                }
                else
                {
                    MessageBox.Show("Không thể tạo dự đoán. Có thể do thiếu dữ liệu lịch sử.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi phân tích: {ex.Message}");
            }
        }

        private void UpdateChart(int categoryId, FinancialPrediction prediction)
        {
            predictionChart.Series["Historical"].Points.Clear();
            predictionChart.Series["Predicted"].Points.Clear();

            // Configure chart appearance with more friendly colors and style
            predictionChart.BackColor = Color.White;
            predictionChart.ChartAreas[0].BackColor = Color.WhiteSmoke;
            
            // Configure axes
            var chartArea = predictionChart.ChartAreas[0];
            chartArea.AxisX.Title = "Thời gian";
            chartArea.AxisY.Title = "Số tiền (VND)";
            chartArea.AxisY.LabelStyle.Format = "N0";
            chartArea.AxisY.LineColor = Color.Gray;
            chartArea.AxisX.LineColor = Color.Gray;
            
            // Configure grid lines
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            
            // Configure X axis dates
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Days;
            chartArea.AxisX.LabelStyle.Format = "dd/MM/yyyy";
            chartArea.AxisX.Minimum = DateTime.Now.AddMonths(-1).ToOADate();
            chartArea.AxisX.Maximum = DateTime.Now.AddDays(7).ToOADate();
            
            // Configure historical data series
            predictionChart.Series["Historical"].ChartType = SeriesChartType.Line;
            predictionChart.Series["Historical"].Color = Color.FromArgb(65, 105, 225); // Royal Blue
            predictionChart.Series["Historical"].BorderWidth = 3;
            predictionChart.Series["Historical"].MarkerStyle = MarkerStyle.Circle;
            predictionChart.Series["Historical"].MarkerSize = 8;
            predictionChart.Series["Historical"].MarkerColor = Color.White;
            predictionChart.Series["Historical"].MarkerBorderColor = Color.FromArgb(65, 105, 225);
            predictionChart.Series["Historical"].MarkerBorderWidth = 2;
            predictionChart.Series["Historical"].XValueType = ChartValueType.DateTime;
            predictionChart.Series["Historical"].ToolTip = "Ngày: #VALX{dd/MM/yyyy}\nChi tiêu: #VALY{N0} VND";
            
            // Configure prediction series
            predictionChart.Series["Predicted"].ChartType = SeriesChartType.Point;
            predictionChart.Series["Predicted"].Color = Color.FromArgb(220, 20, 60); // Crimson
            predictionChart.Series["Predicted"].MarkerStyle = MarkerStyle.Diamond;
            predictionChart.Series["Predicted"].MarkerSize = 12;
            predictionChart.Series["Predicted"].XValueType = ChartValueType.DateTime;
            predictionChart.Series["Predicted"].ToolTip = "Dự đoán: #VALY{N0} VND";

            // Plot historical data
            var transactions = QLCTDAO.GetAllQLCTDAO()
                .Where(t => GetCategoryId(t.DanhMuc) == categoryId)
                .OrderBy(t => t.ThoiGian)
                .ToList();

            foreach (var transaction in transactions)
            {
                var date = transaction.ThoiGian.ToDateTime(TimeOnly.MinValue);
                var point = new DataPoint(date.ToOADate(), Math.Abs(transaction.SoTien));
                predictionChart.Series["Historical"].Points.Add(point);
            }

            // Plot prediction
            var predictedPoint = new DataPoint(DateTime.Now.ToOADate(), prediction.PredictedAmount);
            predictedPoint.Label = $"{prediction.PredictedAmount:N0} VND";
            predictedPoint.LabelForeColor = Color.FromArgb(220, 20, 60);
            predictedPoint.LabelBackColor = Color.FromArgb(255, 255, 255, 220);
            predictionChart.Series["Predicted"].Points.Add(predictedPoint);

            // Configure legend
            predictionChart.Legends.Clear();
            var legend = predictionChart.Legends.Add("Legend");
            legend.Docking = Docking.Bottom;
            legend.BackColor = Color.FromArgb(250, 250, 250);
            legend.BorderColor = Color.LightGray;
            predictionChart.Series["Historical"].LegendText = "Dữ liệu chi tiêu";
            predictionChart.Series["Predicted"].LegendText = "Dự đoán chi tiêu";

            // Add title with nice formatting
            predictionChart.Titles.Clear();
            var title = predictionChart.Titles.Add($"Biểu đồ chi tiêu - {prediction.CategoryName}");
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(50, 50, 50);

            // Enable user interaction
            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScrollBar.IsPositionedInside = true;
        }

        private void UpdateResults(FinancialPrediction prediction)
        {
            var result = new StringBuilder();
            result.AppendLine($"Dự đoán chi tiêu cho {prediction.CategoryName}:");
            result.AppendLine($"Số tiền dự kiến: {prediction.PredictedAmount:N0} VND");
            result.AppendLine($"Độ tin cậy: {prediction.Confidence:P0}");
            result.AppendLine();
            result.AppendLine("Gợi ý:");

            foreach (var recommendation in prediction.Recommendations)
            {
                result.AppendLine($"- {recommendation}");
            }

            result.AppendLine();
            result.AppendLine("Chi tiết mô hình:");
            foreach (var contribution in prediction.ModelContributions)
            {
                result.AppendLine($"- {contribution.Key}: {contribution.Value:N0}");
            }

            resultTextBox.Text = result.ToString();
        }
    }
}
