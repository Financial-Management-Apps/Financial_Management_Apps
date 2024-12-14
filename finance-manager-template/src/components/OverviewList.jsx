import { useState } from 'react';
import {
  Box,
  Typography,
  List,
  ListItem,
  ListItemText,
  Pagination,
  Select,
  MenuItem,
  FormControl,
  InputLabel,
} from '@mui/material';
import { generateFakeTransactions } from '../utils/fakeData';

const ITEMS_PER_PAGE = 6; // Số giao dịch tối đa mỗi trang

// Hàm định dạng số tiền với dấu cách
const formatAmount = (amount) => {
  return amount
    .toFixed(0) // Làm tròn không có số thập phân
    .replace(/\B(?=(\d{3})+(?!\d))/g, ' '); // Thêm dấu cách vào mỗi 3 chữ số
};

const OverviewList = () => {
  const transactions = generateFakeTransactions(100); // Fake 100 giao dịch
  const [currentPage, setCurrentPage] = useState(1); // Trang hiện tại
  const [selectedTransaction, setSelectedTransaction] = useState(null); // Giao dịch được chọn
  const [categoryFilter, setCategoryFilter] = useState('all'); // Lọc theo loại
  const [dateOrder, setDateOrder] = useState('desc'); // Sắp xếp theo ngày
  const [amountType, setAmountType] = useState('all'); // Lọc theo số tiền

  // Lọc và sắp xếp giao dịch
  const filteredTransactions = transactions
    .filter((transaction) => {
      if (categoryFilter === 'all') return true;
      return transaction.category === categoryFilter;
    })
    .filter((transaction) => {
      if (amountType === 'all') return true;
      return amountType === 'income' ? transaction.amount > 0 : transaction.amount < 0;
    })
    .sort((a, b) => {
      if (dateOrder === 'asc') return new Date(a.date) - new Date(b.date);
      return new Date(b.date) - new Date(a.date);
    });

  // Tính toán giao dịch hiển thị theo trang
  const indexOfLastItem = currentPage * ITEMS_PER_PAGE;
  const indexOfFirstItem = indexOfLastItem - ITEMS_PER_PAGE;
  const currentTransactions = filteredTransactions.slice(indexOfFirstItem, indexOfLastItem);

  // Chuyển trang
  const handlePageChange = (event, value) => {
    setCurrentPage(value);
    setSelectedTransaction(null); // Reset chi tiết giao dịch khi đổi trang
  };

  // Hiển thị chi tiết giao dịch
  const handleTransactionClick = (transaction) => {
    setSelectedTransaction(transaction);
  };

  return (
    <Box sx={{ padding: 2 }}>
      <Typography variant="h5" gutterBottom>
        Danh sách giao dịch
      </Typography>

      {/* Danh mục sắp xếp */}
      <Box sx={{ display: 'flex', gap: 2, marginBottom: 2 }}>
        {/* Lọc theo loại */}
        <FormControl size="small" sx={{ minWidth: 200 }}>
          <InputLabel id="category-select-label">Lọc theo loại</InputLabel>
          <Select
            labelId="category-select-label"
            value={categoryFilter}
            onChange={(e) => {
              setCategoryFilter(e.target.value);
              setCurrentPage(1);
            }}
            label="Lọc theo loại"
          >
            <MenuItem value="all">Tất cả</MenuItem>
            <MenuItem value="Food">Ăn uống</MenuItem>
            <MenuItem value="Shopping">Mua sắm</MenuItem>
            <MenuItem value="Salary">Lương</MenuItem>
          </Select>
        </FormControl>

        {/* Sắp xếp theo ngày */}
        <FormControl size="small" sx={{ minWidth: 200 }}>
          <InputLabel id="date-select-label">Sắp xếp theo ngày</InputLabel>
          <Select
            labelId="date-select-label"
            value={dateOrder}
            onChange={(e) => {
              setDateOrder(e.target.value);
              setCurrentPage(1);
            }}
            label="Sắp xếp theo ngày"
          >
            <MenuItem value="asc">Tăng dần</MenuItem>
            <MenuItem value="desc">Giảm dần</MenuItem>
          </Select>
        </FormControl>

        {/* Lọc theo số tiền */}
        <FormControl size="small" sx={{ minWidth: 200 }}>
          <InputLabel id="amount-select-label">Lọc theo số tiền</InputLabel>
          <Select
            labelId="amount-select-label"
            value={amountType}
            onChange={(e) => {
              setAmountType(e.target.value);
              setCurrentPage(1);
            }}
            label="Lọc theo số tiền"
          >
            <MenuItem value="all">Tất cả</MenuItem>
            <MenuItem value="income">Thêm vào</MenuItem>
            <MenuItem value="expense">Trừ ra</MenuItem>
          </Select>
        </FormControl>
      </Box>

      <Box sx={{ display: 'flex', flexDirection: 'row', gap: 2 }}>
        {/* Danh sách giao dịch */}
        <Box sx={{ flex: 1 }}>
          <List>
            {currentTransactions.map((transaction) => (
              <ListItem
                key={transaction.id}
                onClick={() => handleTransactionClick(transaction)}
                sx={{
                  cursor: 'pointer',
                  backgroundColor: transaction.amount > 0 ? 'rgba(76, 175, 80, 0.1)' : 'rgba(244, 67, 54, 0.1)',
                  border: transaction.amount > 0 ? '1px solid rgba(76, 175, 80, 0.4)' : '1px solid rgba(244, 67, 54, 0.4)',
                  marginBottom: 1,
                  '&:hover': {
                    backgroundColor: transaction.amount > 0
                      ? 'rgba(76, 175, 80, 0.2)'
                      : 'rgba(244, 67, 54, 0.2)',
                  },
                }}
              >
                <ListItemText
                  primary={
                    <Typography
                      variant="body1"
                      sx={{
                        display: 'flex',
                        alignItems: 'center',
                        color: transaction.amount > 0 ? 'green' : 'red',
                      }}
                    >
                      {transaction.amount > 0 ? '+' : '-'} {formatAmount(Math.abs(transaction.amount))} VND
                    </Typography>
                  }
                  secondary={`Ngày: ${new Date(transaction.date).toLocaleDateString('vi-VN')} | Danh mục: ${transaction.category}`}
                />
              </ListItem>
            ))}
          </List>
          {/* Pagination */}
          <Box sx={{ display: 'flex', justifyContent: 'center', marginTop: 2 }}>
            <Pagination
              count={Math.ceil(filteredTransactions.length / ITEMS_PER_PAGE)}
              page={currentPage}
              onChange={handlePageChange}
              color="primary"
            />
          </Box>
        </Box>

        {/* Chi tiết giao dịch */}
        <Box
          sx={{
            flex: 1,
            padding: 2,
            border: '1px solid #ddd',
            borderRadius: 2,
            backgroundColor: '#f9f9f9',
            display: selectedTransaction ? 'block' : 'none',
          }}
        >
          {selectedTransaction ? (
            <>
              <Typography variant="h6">Chi tiết giao dịch</Typography>
              <Typography>
                Số tiền: {selectedTransaction.amount > 0 ? '+' : '-'}
                {formatAmount(Math.abs(selectedTransaction.amount))} VND
              </Typography>
              <Typography>
                Ngày giao dịch: {new Date(selectedTransaction.date).toLocaleDateString('vi-VN')}
              </Typography>
              <Typography>Danh mục: {selectedTransaction.category}</Typography>
            </>
          ) : (
            <Typography variant="body1" color="text.secondary">
              Nhấn vào một giao dịch để xem chi tiết
            </Typography>
          )}
        </Box>
      </Box>
    </Box>
  );
};

export default OverviewList;
