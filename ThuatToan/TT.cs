using System;
using System.Collections.Generic;
using System.Linq;
using Accord.MachineLearning;
using Accord.Statistics.Models.Regression.Linear;
using Accord.Math;
using ThuatToan.Models;
using Accord.Statistics;
using System.Windows;

namespace ThuatToan
{
    public class TT
    {
        private readonly Dictionary<int, string> _categoryNames;
        private List<FinancialData> _historicalData;
        private Dictionary<int, CategoryStats> _categoryStats;
        private Dictionary<int, KNearestNeighbors> _knnModels;
        private const int MIN_SAMPLES_FOR_TRAINING = 3;
        private const int FEATURE_COUNT = 5; // Define number of features

        public TT()
        {
            _categoryNames = new Dictionary<int, string>
            {
                { 1, "Đi lại" },
                { 2, "Ăn uống" },
                { 3, "Bạn bè" },
                { 4, "Mua sắm" },
                { 5, "Tiền phòng" },
                { 6, "Tiền điện" },
                { 7, "Tiền nước" },
                { 8, "Lương" }
            };
            _categoryStats = new Dictionary<int, CategoryStats>();
            _historicalData = new List<FinancialData>();
            _knnModels = new Dictionary<int, KNearestNeighbors>();
        }

        public void TrainModel(List<FinancialData> data)
        {
            if (data == null || !data.Any())
                throw new ArgumentException("Training data cannot be null or empty");

            _historicalData = data;
            CalculateCategoryStatistics();
            TrainAccordModels();
        }

        private void TrainAccordModels()
        {
            foreach (var category in _categoryNames.Keys)
            {
                try
                {
                    var categoryData = _historicalData
                        .Where(d => d.CategoryId == category)
                        .OrderBy(d => d.Date)
                        .ToList();

                    if (categoryData.Count >= MIN_SAMPLES_FOR_TRAINING)
                    {
                        TrainModelsForCategory(category, categoryData);
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error training models for category {category}: {ex.Message}");
                }
            }
        }

        private void TrainModelsForCategory(int category, List<FinancialData> categoryData)
        {
            try
            {
                if (categoryData.Count < MIN_SAMPLES_FOR_TRAINING)
                {
                    System.Diagnostics.Debug.WriteLine($"[Category {category}] Insufficient data: {categoryData.Count} samples (minimum {MIN_SAMPLES_FOR_TRAINING} required)");
                    return;
                }

                // Sort and prepare data
                categoryData = categoryData.OrderBy(d => d.Date).ToList();
                var inputs = new double[categoryData.Count][];
                var outputs = new int[categoryData.Count];

                System.Diagnostics.Debug.WriteLine($"\n[Category {category}] Training Data:");
                System.Diagnostics.Debug.WriteLine($"----------------------------------------");
                
                // Create mapping for unique amounts to class indices
                var uniqueAmounts = categoryData.Select(d => (int)Math.Abs(d.Amount)).Distinct().OrderBy(x => x).ToList();
                var amountToClassIndex = new Dictionary<int, int>();
                for (int i = 0; i < uniqueAmounts.Count; i++)
                {
                    amountToClassIndex[uniqueAmounts[i]] = i;
                }

                // Prepare features and outputs
                for (int i = 0; i < categoryData.Count; i++)
                {
                    inputs[i] = new double[]
                    {
                        categoryData[i].Date.Month / 12.0,
                        categoryData[i].Date.Day / 31.0,
                        (double)categoryData[i].Date.DayOfWeek / 7.0
                    };
                    
                    int amount = (int)Math.Abs(categoryData[i].Amount);
                    outputs[i] = amountToClassIndex[amount];

                    System.Diagnostics.Debug.WriteLine(
                        $"Sample {i}: Features=[{string.Join(", ", inputs[i].Select(x => x.ToString("F4")))}], " +
                        $"Amount={amount:N0} → Class {outputs[i]}");
                }

                // Calculate optimal k
                int k = (int)Math.Sqrt(categoryData.Count);
                k = Math.Max(1, Math.Min(k, categoryData.Count - 1));

                System.Diagnostics.Debug.WriteLine($"\n[Category {category}] Model Configuration:");
                System.Diagnostics.Debug.WriteLine($"Samples: {inputs.Length}");
                System.Diagnostics.Debug.WriteLine($"Features per sample: {inputs[0].Length}");
                System.Diagnostics.Debug.WriteLine($"Number of classes: {uniqueAmounts.Count}");
                System.Diagnostics.Debug.WriteLine($"k-value: {k}");
                System.Diagnostics.Debug.WriteLine($"----------------------------------------");

                try
                {
                    var knn = new KNearestNeighbors(
                        k: k,
                        classes: uniqueAmounts.Count,
                        inputs: inputs,
                        outputs: outputs,
                        distance: new Accord.Math.Distances.Euclidean()
                    );

                    // Validate model with test prediction
                    var testInput = inputs[0];
                    var testPrediction = knn.Compute(testInput);
                    var predictedAmount = uniqueAmounts[testPrediction];

                    System.Diagnostics.Debug.WriteLine($"Test prediction successful: {predictedAmount:N0} VND");
                    
                    _knnModels[category] = knn;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[Category {category}] KNN training failed:");
                    System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
                    System.Diagnostics.Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
                    throw;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[Category {category}] Training error:");
                System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
                _knnModels.Remove(category);
            }
        }

        private void CalculateCategoryStatistics()
        {
            _categoryStats.Clear(); // Clear existing stats

            foreach (var category in _categoryNames.Keys)
            {
                var categoryData = _historicalData
                    .Where(d => d.CategoryId == category)
                    .ToList();

                if (categoryData.Any())
                {
                    var amounts = categoryData.Select(d => d.Amount).ToList();
                    var avgAmount = amounts.Average();
                    var stdDev = CalculateStandardDeviation(amounts);

                    System.Diagnostics.Debug.WriteLine($"Category {category}:");
                    System.Diagnostics.Debug.WriteLine($"Average: {avgAmount}");
                    System.Diagnostics.Debug.WriteLine($"StdDev: {stdDev}");
                    System.Diagnostics.Debug.WriteLine($"Sample size: {amounts.Count}");

                    _categoryStats[category] = new CategoryStats
                    {
                        AverageAmount = avgAmount,
                        StandardDeviation = stdDev,
                        MonthlyPattern = CalculateMonthlyPattern(categoryData),
                        WeekdayPattern = CalculateWeekdayPattern(categoryData)
                    };
                }
            }
        }

        public FinancialPrediction PredictSpending(DateTime date, int categoryId, double currentIncome)
        {
            try
            {
                if (!_categoryStats.ContainsKey(categoryId))
                    return null;

                var stats = _categoryStats[categoryId];
                double predictedAmount = stats.AverageAmount;
                double confidence = 0.5;

                if (_knnModels.ContainsKey(categoryId))
                {
                    try
                    {
                        var categoryData = _historicalData
                            .Where(d => d.CategoryId == categoryId)
                            .OrderBy(d => d.Date)
                            .ToList();

                        double[] features = new double[]
                        {
                            date.Month / 12.0,
                            date.Day / 31.0,
                            (double)date.DayOfWeek / 7.0
                        };

                        System.Diagnostics.Debug.WriteLine($"Category {categoryId} - Predicting with features: [{string.Join(", ", features)}]");

                        var knn = _knnModels[categoryId];
                        
                        // Get distances to all training samples
                        var distances = new double[categoryData.Count];
                        var sortedIndices = new int[categoryData.Count];
                        
                        // Calculate distances to all training points
                        for (int i = 0; i < categoryData.Count; i++)
                        {
                            var trainingFeatures = new double[]
                            {
                                categoryData[i].Date.Month / 12.0,
                                categoryData[i].Date.Day / 31.0,
                                (double)categoryData[i].Date.DayOfWeek / 7.0
                            };
                            
                            distances[i] = CalculateDistance(features, trainingFeatures);
                            sortedIndices[i] = i;
                        }
                        
                        // Sort indices by distance
                        Array.Sort(distances, sortedIndices);
                        
                        // Calculate weighted average of k nearest neighbors
                        double totalWeight = 0;
                        double weightedSum = 0;
                        
                        for (int i = 0; i < knn.K && i < categoryData.Count; i++)
                        {
                            int idx = sortedIndices[i];
                            double distance = distances[i];
                            double weight = 1.0 / (distance + 1e-6); // Avoid division by zero
                            double amount = categoryData[idx].Amount;
                            
                            weightedSum += amount * weight;
                            totalWeight += weight;
                            
                            System.Diagnostics.Debug.WriteLine($"Neighbor {i}: Amount={amount:N0}, Distance={distance:F4}, Weight={weight:F4}");
                        }

                        if (totalWeight > 0)
                        {
                            predictedAmount = weightedSum / totalWeight;
                            System.Diagnostics.Debug.WriteLine($"Weighted prediction: {predictedAmount:N0}");
                        }
                        else
                        {
                            predictedAmount = stats.AverageAmount;
                            System.Diagnostics.Debug.WriteLine("Using average as fallback");
                        }

                        // Calculate confidence using recent transactions
                        var recentTransactions = _historicalData
                            .Where(d => d.CategoryId == categoryId)
                            .OrderByDescending(d => d.Date)
                            .Take(5)
                            .ToList();

                        if (recentTransactions.Any())
                        {
                            double recentAvg = recentTransactions.Average(d => d.Amount);
                            double recentStdDev = CalculateStandardDeviation(recentTransactions.Select(d => d.Amount).ToList());

                            if (recentStdDev > 0)
                            {
                                double zScore = Math.Abs(predictedAmount - recentAvg) / recentStdDev;
                                confidence = Math.Exp(-zScore / 2);
                                confidence = Math.Max(0.3, Math.Min(0.9, confidence));

                                System.Diagnostics.Debug.WriteLine($"Recent Avg: {recentAvg:N0}, StdDev: {recentStdDev:N0}");
                                System.Diagnostics.Debug.WriteLine($"Z-Score: {zScore}, Confidence: {confidence:P0}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"KNN prediction failed: {ex.Message}");
                        predictedAmount = stats.AverageAmount;
                        confidence = 0.3;
                    }
                }

                return new FinancialPrediction
                {
                    CategoryName = _categoryNames[categoryId],
                    PredictedAmount = predictedAmount,
                    Confidence = confidence,
                    Recommendations = GenerateRecommendations(categoryId, predictedAmount, currentIncome),
                    ModelContributions = new Dictionary<string, double>
                    {
                        { "Trung bình", stats.AverageAmount },
                        { "Dự đoán", predictedAmount },
                        { "Độ tin cậy (%)", confidence * 100 }
                    }
                };
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Prediction error: {ex.Message}");
                return null;
            }
        }

        private double CalculateDistance(double[] a, double[] b)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                double diff = a[i] - b[i];
                sum += diff * diff;
            }
            return Math.Sqrt(sum);
        }

        public List<BudgetRecommendation> GenerateBudgetPlan(double income)
        {
            var recommendations = new List<BudgetRecommendation>();
            var essentialCategories = new[] { 2, 5 }; // Ăn uống và tiền phòng

            // Phân bổ ngân sách theo quy tắc 50/30/20
            var essentials = income * 0.5; // 50% cho chi phí thiết yếu
            var savings = income * 0.2;    // 20% cho tiết kiệm
            var flexible = income * 0.3;   // 30% cho chi tiêu linh hoạt

            // Chi phí thiết yếu
            foreach (var category in essentialCategories)
            {
                var avgAmount = _categoryStats.ContainsKey(category) 
                    ? _categoryStats[category].AverageAmount 
                    : 0;
                
                recommendations.Add(new BudgetRecommendation
                {
                    CategoryId = category,
                    CategoryName = _categoryNames[category],
                    RecommendedAmount = Math.Min(avgAmount, essentials / essentialCategories.Length),
                    Priority = "Cao",
                    Reason = "Chi phí thiết yếu cần được ưu tiên"
                });
            }

            // Chi phí linh hoạt
            var flexibleCategories = new[] { 3, 4 }; // Bạn bè và mua sắm
            foreach (var category in flexibleCategories)
            {
                recommendations.Add(new BudgetRecommendation
                {
                    CategoryId = category,
                    CategoryName = _categoryNames[category],
                    RecommendedAmount = flexible / flexibleCategories.Length,
                    Priority = "Trung bình",
                    Reason = "Chi phí có thể điều chỉnh theo tình hình"
                });
            }

            // Tiết kiệm
            recommendations.Add(new BudgetRecommendation
            {
                CategoryId = 1,
                CategoryName = "Tiết kiệm",
                RecommendedAmount = savings,
                Priority = "Cao",
                Reason = "Cần duy trì tỷ lệ tiết kiệm 20% thu nhập"
            });

            return recommendations;
        }

        private List<string> GenerateRecommendations(int categoryId, double predictedAmount, double income)
        {
            var recommendations = new List<string>();
            var stats = _categoryStats[categoryId];

            if (predictedAmount > stats.AverageAmount * 1.2)
            {
                recommendations.Add($"Chi tiêu {_categoryNames[categoryId]} dự kiến cao hơn 20% so với trung bình");
            }

            if (predictedAmount > income * 0.4)
            {
                recommendations.Add("Chi tiêu này chiếm tỷ lệ lớn trong thu nhập. Cân nhắc giảm chi tiêu");
            }

            return recommendations;
        }

        private double CalculateStandardDeviation(List<double> values)
        {
            if (values == null || values.Count < 2)
            {
                System.Diagnostics.Debug.WriteLine("Not enough values for std dev calculation");
                return 0;
            }

            double avg = values.Average();
            double sumOfSquaresOfDifferences = values.Sum(val => Math.Pow(val - avg, 2));
            double standardDeviation = Math.Sqrt(sumOfSquaresOfDifferences / (values.Count - 1));
            
            if (standardDeviation == 0)
            {
                System.Diagnostics.Debug.WriteLine("Warning: Calculated standard deviation is 0");
                // Return a small non-zero value to avoid division by zero
                return 1.0;
            }

            return standardDeviation;
        }

        private Dictionary<int, double> CalculateMonthlyPattern(List<FinancialData> data)
        {
            var pattern = new Dictionary<int, double>();
            var monthlyAverages = data
                .GroupBy(d => d.Date.Month)
                .ToDictionary(
                    g => g.Key,
                    g => g.Average(d => d.Amount)
                );

            var overallAverage = monthlyAverages.Values.Average();

            foreach (var month in monthlyAverages.Keys)
            {
                pattern[month] = monthlyAverages[month] / overallAverage;
            }

            return pattern;
        }

        private Dictionary<int, double> CalculateWeekdayPattern(List<FinancialData> data)
        {
            var pattern = new Dictionary<int, double>();
            var weekdayAverages = data
                .GroupBy(d => (int)d.Date.DayOfWeek)
                .ToDictionary(
                    g => g.Key,
                    g => g.Average(d => d.Amount)
                );

            var overallAverage = weekdayAverages.Values.Average();

            foreach (var day in weekdayAverages.Keys)
            {
                pattern[day] = weekdayAverages[day] / overallAverage;
            }

            return pattern;
        }
    }
}
