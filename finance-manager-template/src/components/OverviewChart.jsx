// components/OverviewChart.jsx
import { useState } from 'react';
import { BarChart, Bar, XAxis, YAxis, CartesianGrid, Tooltip, ResponsiveContainer } from 'recharts';
import { Box, FormControl, InputLabel, Select, MenuItem, Typography } from '@mui/material';
import { generateFakeTransactions } from '../utils/fakeData';

// Tạo dữ liệu fake
const fakeTransactions = generateFakeTransactions(100);

// Hàm lọc giao dịch theo thời gian
const filterTransactionsByTime = (transactions, filter) => {
  const groupedData = {};
  transactions.forEach((transaction) => {
    const date = new Date(transaction.date);
    let key;

    if (filter === 'day') key = date.toISOString().split('T')[0]; // YYYY-MM-DD
    else if (filter === 'month') key = `${date.getFullYear()}-${date.getMonth() + 1}`; // YYYY-MM
    else if (filter === 'year') key = `${date.getFullYear()}`; // YYYY

    if (!groupedData[key]) groupedData[key] = [];
    groupedData[key].push(transaction);
  });

  // Chuyển đổi thành mảng dữ liệu để Recharts sử dụng
  return Object.keys(groupedData).map((key) => ({
    time: key,
    income: groupedData[key]
      .filter((t) => parseFloat(t.amount) > 0)
      .reduce((sum, t) => sum + parseFloat(t.amount), 0),
    expense: groupedData[key]
      .filter((t) => parseFloat(t.amount) < 0)
      .reduce((sum, t) => sum + Math.abs(parseFloat(t.amount)), 0),
  }));
};

const OverviewChart = () => {
  const [timeFilter, setTimeFilter] = useState('month');
  const filteredData = filterTransactionsByTime(fakeTransactions, timeFilter);

  return (
    <Box>
      <Typography variant="h4" gutterBottom>
        Transaction Overview
      </Typography>

      {/* Dropdown chọn thời gian */}
      <FormControl fullWidth sx={{ mb: 3 }}>
        <InputLabel>Filter by</InputLabel>
        <Select value={timeFilter} onChange={(e) => setTimeFilter(e.target.value)}>
          <MenuItem value="day">Day</MenuItem>
          <MenuItem value="month">Month</MenuItem>
          <MenuItem value="year">Year</MenuItem>
        </Select>
      </FormControl>

      {/* Biểu đồ */}
      <ResponsiveContainer width="100%" height={400}>
        <BarChart data={filteredData}>
          <CartesianGrid strokeDasharray="3 3" />
          <XAxis dataKey="time" />
          <YAxis />
          <Tooltip />
          <Bar dataKey="income" fill="#4caf50" name="Income" />
          <Bar dataKey="expense" fill="#f44336" name="Expense" />
        </BarChart>
      </ResponsiveContainer>
    </Box>
  );
};

export default OverviewChart;
