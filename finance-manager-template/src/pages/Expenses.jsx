import { useState, useEffect } from 'react';
import { Box, Typography, List, ListItem, ListItemText, Pagination, FormControl, InputLabel, Select, MenuItem } from '@mui/material';
import { BarChart, Bar, XAxis, YAxis, CartesianGrid, Tooltip, ResponsiveContainer } from 'recharts';
import { generateFakeTransactions } from '../utils/fakeData';

// Số giao dịch tối đa mỗi trang
const ITEMS_PER_PAGE = 2;

const Expenses = () => {
  // Dữ liệu fake được tạo một lần và lưu vào state
  const [transactions, setTransactions] = useState([]);
  const [currentPage, setCurrentPage] = useState(1); // Trang hiện tại
  const [selectedMonth, setSelectedMonth] = useState(null); // Tháng đã chọn để hiển thị chi tiết
  const [categoryFilter, setCategoryFilter] = useState('Food'); // Lọc theo danh mục
  const [selectedYear, setSelectedYear] = useState('2023'); // Lọc theo năm

  // Sử dụng useEffect để tạo dữ liệu giả một lần khi component mount
  useEffect(() => {
    const data = generateFakeTransactions(100); // Fake 100 giao dịch
    setTransactions(data); // Lưu vào state
  }, []); // [] đảm bảo chỉ chạy 1 lần khi component được mount

  // Lọc giao dịch theo năm và danh mục
  const filteredTransactions = transactions.filter((transaction) => {
    const transactionYear = new Date(transaction.date).getFullYear();
    const transactionCategory = transaction.category;

    return transactionYear === parseInt(selectedYear) && transactionCategory === categoryFilter && transaction.amount < 0;
  });

  // Tính chi phí theo từng tháng cho mỗi loại chi phí
  const expensesByMonth = Array.from({ length: 12 }, (_, index) => {
    const month = index + 1;
    const monthTransactions = filteredTransactions.filter((transaction) => new Date(transaction.date).getMonth() + 1 === month);

    const totalAmount = monthTransactions.reduce((acc, transaction) => acc + transaction.amount, 0);

    return {
      month: `${month < 10 ? '0' : ''}${month}`, // Hiển thị tháng dưới dạng 01, 02, ...
      amount: totalAmount,
    };
  });

  // Dữ liệu cho biểu đồ
  const chartData = expensesByMonth;

  // Xử lý chuyển trang
  const handlePageChange = (event, value) => {
    setCurrentPage(value);
  };

  // Hiển thị giao dịch của tháng đã chọn
  const handleBarClick = (data) => {
    const clickedMonth = data.activeLabel;
    setSelectedMonth(clickedMonth);
  };

  // Lọc các giao dịch thuộc tháng đã chọn
  const filteredMonthTransactions = filteredTransactions.filter(transaction => {
    const month = new Date(transaction.date).getMonth() + 1; // Tháng của giao dịch (1-12)
    const selectedMonthNumber = parseInt(selectedMonth); // Tháng đã chọn (1-12)

    // Kiểm tra xem tháng đã chọn có hợp lệ không
    if (!selectedMonth || isNaN(selectedMonthNumber)) {
      return false; // Không có tháng hợp lệ
    }

    return month === selectedMonthNumber; // So sánh tháng của giao dịch với tháng đã chọn
  });

  // Tính toán giao dịch hiển thị theo trang
  const indexOfLastItem = currentPage * ITEMS_PER_PAGE;
  const indexOfFirstItem = indexOfLastItem - ITEMS_PER_PAGE;
  const currentTransactions = filteredMonthTransactions.slice(indexOfFirstItem, indexOfLastItem);

  return (
    <Box sx={{ padding: 4 }}>
      <Typography variant="h4" gutterBottom>
        Chi phí ({categoryFilter})
      </Typography>

      {/* Lọc theo năm */}
      <FormControl size="small" sx={{ minWidth: 200, marginBottom: 2 }}>
        <InputLabel id="year-select-label">Chọn năm</InputLabel>
        <Select
          labelId="year-select-label"
          value={selectedYear}
          onChange={(e) => setSelectedYear(e.target.value)}
          label="Chọn năm"
        >
          <MenuItem value="2023">2023</MenuItem>
          <MenuItem value="2024">2024</MenuItem>
        </Select>
      </FormControl>

      {/* Lọc theo danh mục */}
      <FormControl size="small" sx={{ minWidth: 200, marginBottom: 2 }}>
        <InputLabel id="category-select-label">Chọn danh mục</InputLabel>
        <Select
          labelId="category-select-label"
          value={categoryFilter}
          onChange={(e) => setCategoryFilter(e.target.value)}
          label="Chọn danh mục"
        >
          <MenuItem value="Food">Ăn uống</MenuItem>
          <MenuItem value="Shopping">Mua sắm</MenuItem>
          <MenuItem value="Utilities">Tiện ích</MenuItem>
          <MenuItem value="Entertainment">Giải trí</MenuItem>
        </Select>
      </FormControl>

      {/* Biểu đồ */}
      <Box sx={{ height: 300, maxWidth: '99%', overflow: 'hidden' }}>
        <ResponsiveContainer width="100%" height="100%">
          <BarChart data={chartData} onClick={handleBarClick}>
            <CartesianGrid strokeDasharray="3 3" />
            <XAxis dataKey="month" />
            <YAxis />
            <Tooltip />
            <Bar dataKey="amount" fill="#FF6347" />
          </BarChart>
        </ResponsiveContainer>
      </Box>

      {/* Nếu có tháng được chọn, hiển thị chi tiết giao dịch của tháng đó */}
      {selectedMonth && (
        <>
          <Typography variant="h6" sx={{ marginTop: 3 }}>
            Chi tiết chi phí tháng {selectedMonth}
          </Typography>
          <List>
            {currentTransactions.map((transaction) => (
              <ListItem key={transaction.id}>
                <ListItemText
                  primary={`Ngày: ${new Date(transaction.date).toLocaleDateString('en-GB', { day: '2-digit', month: '2-digit', year: 'numeric' })}`}
                  secondary={`Số tiền: ${transaction.formattedAmount}`}
                />
              </ListItem>
            ))}
          </List>

          {/* Pagination */}
          <Box sx={{ display: 'flex', justifyContent: 'center', marginTop: 2 }}>
            <Pagination
              count={Math.ceil(filteredMonthTransactions.length / ITEMS_PER_PAGE)}
              page={currentPage}
              onChange={handlePageChange}
              color="primary"
            />
          </Box>
        </>
      )}
    </Box>
  );
};

export default Expenses;
