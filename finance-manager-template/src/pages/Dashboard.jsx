import React from 'react';
import { useSelector } from 'react-redux';
import { useNavigate } from 'react-router-dom';
import { Box } from '@mui/material';

const Dashboard = () => {
  const navigate = useNavigate();
  // eslint-disable-next-line no-unused-vars
  const { user, isAuthenticated } = useSelector((state) => state.auth);

  // Nếu người dùng chưa đăng nhập, điều hướng về trang đăng nhập
  React.useEffect(() => {
    if (!isAuthenticated) {
      navigate('/login');
    }
  }, [isAuthenticated, navigate]);

  return (
    <Box sx={{ display: 'flex' }}>
      <Box sx={{ flex: 1 }}>
        <Box sx={{ padding: 2 }}>
          <h2>Dashboard Content</h2>
          <p>Welcome to the financial management system.</p>
        </Box>
      </Box>
    </Box>
  );
};

export default Dashboard;
