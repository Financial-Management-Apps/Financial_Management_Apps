import { useState, useEffect } from 'react';
import { Box, Typography, Grid, Alert } from '@mui/material';
import { LineChart, Line, XAxis, YAxis, CartesianGrid, Tooltip, BarChart, Bar } from 'recharts';
import { generateFakeTransactions } from '../utils/fakeData'; // Import dữ liệu giả

const BUDGET = 2000000; // Ngân sách cho "Ăn uống" (2 triệu)

// Dự đoán chi tiêu tương lai
const predictFutureSpending = (transactions) => {
  const monthlyExpenses = Array(12).fill(0); // Mảng lưu trữ chi tiêu mỗi tháng

  // Tính tổng chi tiêu của mỗi tháng
  transactions.forEach((transaction) => {
    const month = new Date(transaction.date).getMonth();
    if (transaction.amount < 0) {
      monthlyExpenses[month] += Math.abs(transaction.amount);
    }
  });

  // Tính trung bình chi tiêu hàng tháng
  const totalExpenses = monthlyExpenses.reduce((total, expense) => total + expense, 0);
  const monthsCount = monthlyExpenses.filter((expense) => expense > 0).length;
  const avgMonthlyExpense = monthsCount > 0 ? totalExpenses / monthsCount : 0;

  const predictedExpense = avgMonthlyExpense * 1.1; // Dự đoán chi tiêu tăng 10% trong tháng tiếp theo

  return predictedExpense;
};

// Cảnh báo chi tiêu vượt quá ngân sách
const checkSpendingLimit = (transactions, budget) => {
  const foodSpending = transactions
    .filter((transaction) => transaction.category === 'Food' && transaction.amount < 0)
    .reduce((total, transaction) => total + Math.abs(transaction.amount), 0);

  return foodSpending > budget;
};

const Reports = () => {
  const [monthlyData, setMonthlyData] = useState([]);
  const [isOverBudget, setIsOverBudget] = useState(false);
  const [predictedExpense, setPredictedExpense] = useState(0);
  const [foodSpending, setFoodSpending] = useState(0);

  useEffect(() => {
    const transactions = generateFakeTransactions(12); // Giả lập 12 tháng dữ liệu

    const formattedData = transactions.reduce((acc, curr) => {
      const month = new Date(curr.date).toLocaleString('default', { month: 'short' }); // Lấy tên tháng
      const existingMonth = acc.find(item => item.month === month);

      if (existingMonth) {
        existingMonth.income += curr.amount > 0 ? curr.amount : 0;
        existingMonth.expenses += curr.amount < 0 ? Math.abs(curr.amount) : 0;
      } else {
        acc.push({
          month,
          income: curr.amount > 0 ? curr.amount : 0,
          expenses: curr.amount < 0 ? Math.abs(curr.amount) : 0,
        });
      }

      return acc;
    }, []);

    // Sắp xếp dữ liệu theo thứ tự tháng
    const monthOrder = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
    const sortedData = monthOrder.map(month => {
      const monthData = formattedData.find(item => item.month === month);
      return monthData || { month, income: 0, expenses: 0 };
    });

    setMonthlyData(sortedData);

    // Cập nhật dự đoán chi tiêu và cảnh báo ngân sách
    const predicted = predictFutureSpending(transactions);
    setPredictedExpense(predicted);

    const foodSpending = transactions
      .filter((transaction) => transaction.category === 'Food' && transaction.amount < 0)
      .reduce((total, transaction) => total + Math.abs(transaction.amount), 0);

    setFoodSpending(foodSpending);
    setIsOverBudget(foodSpending > BUDGET);
  }, []);

  // Tính tổng thu nhập và chi tiêu
  const totalIncome = monthlyData.reduce((acc, item) => acc + item.income, 0);
  const totalExpenses = monthlyData.reduce((acc, item) => acc + item.expenses, 0);

  // Kiểm tra nếu chi tiêu vượt quá thu nhập
  const isExpensesExceedIncome = totalExpenses > totalIncome;

  return (
    <Box sx={{ padding: 4 }}>
      <Typography variant="h4" gutterBottom>
        Báo cáo Thu nhập và Chi tiêu
      </Typography>

      {/* Tổng kết thu nhập và chi tiêu */}
      <Box sx={{ marginBottom: 2 }}>
        <Typography variant="h6">
          Tổng thu nhập: {totalIncome} VND
        </Typography>
        <Typography variant="h6" color={isExpensesExceedIncome ? 'error' : 'initial'}>
          Tổng chi tiêu: {totalExpenses} VND
        </Typography>
      </Box>

      {/* Thông báo nếu chi tiêu vượt quá thu nhập */}
      {isExpensesExceedIncome && (
        <Typography variant="body1" color="error" sx={{ marginBottom: 2 }}>
          Cảnh báo: Chi tiêu vượt quá thu nhập!
        </Typography>
      )}

      {/* Thông báo nếu chi tiêu vượt quá ngân sách */}
      {isOverBudget && (
        <Alert severity="error" sx={{ marginBottom: 2 }}>
          Cảnh báo: Bạn đã vượt quá ngân sách cho "Ăn uống" với tổng chi tiêu là {foodSpending.toLocaleString()} VND!
        </Alert>
      )}

      {/* Dự đoán chi tiêu */}
      <Typography variant="h6" gutterBottom>
        Dự đoán chi tiêu trong tháng tiếp theo: {predictedExpense.toLocaleString()} VND
      </Typography>

      {/* Biểu đồ Line Chart và Bar Chart nằm ngang với nhau */}
      <Grid container spacing={3}>
        <Grid item xs={12} sm={6}>
          <Typography variant="h6" align="center" gutterBottom>
            Biểu đồ Thu nhập và Chi tiêu (Line Chart)
          </Typography>
          <LineChart width={600} height={300} data={monthlyData}>
            <CartesianGrid strokeDasharray="3 3" />
            <XAxis dataKey="month" />
            <YAxis />
            <Tooltip />
            <Line type="monotone" dataKey="income" stroke="#8884d8" />
            <Line type="monotone" dataKey="expenses" stroke="#FF6347" />
          </LineChart>
        </Grid>
        
        <Grid item xs={12} sm={6}>
          <Typography variant="h6" align="center" gutterBottom>
            Biểu đồ Thu nhập và Chi tiêu (Bar Chart)
          </Typography>
          <BarChart width={600} height={300} data={monthlyData}>
            <CartesianGrid strokeDasharray="3 3" />
            <XAxis dataKey="month" />
            <YAxis />
            <Tooltip />
            <Bar dataKey="income" fill="#8884d8" />
            <Bar dataKey="expenses" fill="#FF6347" />
          </BarChart>
        </Grid>
      </Grid>
    </Box>
  );
};

export default Reports;