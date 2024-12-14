namespace ThuatToan.Models
{
    public class FinancialData
    {
        public int CategoryId { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsExpense { get; set; }
    }

    public class FinancialPrediction
    {
        public string CategoryName { get; set; }
        public double PredictedAmount { get; set; }
        public double Confidence { get; set; }
        public List<string> Recommendations { get; set; }
        public Dictionary<string, double> ModelContributions { get; set; }
    }

    public class BudgetRecommendation
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public double RecommendedAmount { get; set; }
        public string Priority { get; set; }
        public string Reason { get; set; }
    }

    internal class CategoryStats
    {
        public double AverageAmount { get; set; }
        public double StandardDeviation { get; set; }
        public Dictionary<int, double> MonthlyPattern { get; set; }
        public Dictionary<int, double> WeekdayPattern { get; set; }
    }
} 