import { useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { useNavigate } from 'react-router-dom';
import { register } from '../redux/slices/authSlice';
import { toast, ToastContainer} from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import {
  Box,
  TextField,
  Button,
  Typography,
  Select,
  MenuItem,
  FormControl,
  InputLabel,
} from '@mui/material';

const Register = () => {
  const dispatch = useDispatch();
  const navigate = useNavigate(); // Điều hướng
  const { loading, error } = useSelector((state) => state.auth);

  const [formData, setFormData] = useState({
    HoTen: '',
    GioiTinh: '',
    NgaySinh: '',
    Email: '',
    DiaChi: '',
    Password: '',
    confirmPassword: '',
  });

  const handleChange = (e) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value,
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    if (formData.Password !== formData.confirmPassword) {
      toast.error('Mật khẩu không khớp!', {
        autoClose: 1500,
      }
      );
      return;
    }

    const result = await dispatch(register(formData));
    if (register.fulfilled.match(result)) {
      toast.success('Login successful! Redirecting to dashboard...', {
        position: 'top-right',
        autoClose: 1500,
      });

      setTimeout(() => {
        navigate('/login');
      }, 2000);
    }
  };

  return (
    <Box
      component="form"
      sx={{
        maxWidth: 400,
        margin: '0 auto',
        padding: 3,
        boxShadow: 3,
        borderRadius: 2,
        mt: 5,
      }}
      onSubmit={handleSubmit}
    >
    <ToastContainer />

      <Typography variant="h5" gutterBottom textAlign="center">
        Đăng Ký
      </Typography>
      {error && (
        <Typography color="error" variant="body2" sx={{ mb: 2 }}>
          {error}
        </Typography>
      )}

      <TextField
        fullWidth
        label="Họ Tên"
        name="HoTen"
        value={formData.HoTen}
        onChange={handleChange}
        variant="outlined"
        margin="normal"
      />
      <FormControl fullWidth margin="normal">
        <InputLabel>Giới Tính</InputLabel>
        <Select
          name="GioiTinh"
          value={formData.GioiTinh}
          onChange={handleChange}
          label="Giới Tính"
        >
          <MenuItem value="Nam">Nam</MenuItem>
          <MenuItem value="Nữ">Nữ</MenuItem>
        </Select>
      </FormControl>
      <TextField
        fullWidth
        label="Ngày Sinh"
        name="NgaySinh"
        type="date"
        value={formData.NgaySinh}
        onChange={handleChange}
        variant="outlined"
        margin="normal"
        InputLabelProps={{
          shrink: true,
        }}
      />
      <TextField
        fullWidth
        label="Email"
        name="Email"
        type="email"
        value={formData.Email}
        onChange={handleChange}
        variant="outlined"
        margin="normal"
      />
      <TextField
        fullWidth
        label="Địa Chỉ"
        name="DiaChi"
        value={formData.DiaChi}
        onChange={handleChange}
        variant="outlined"
        margin="normal"
      />
      <TextField
        fullWidth
        label="Mật khẩu"
        name="Password"
        type="password"
        value={formData.Password}
        onChange={handleChange}
        variant="outlined"
        margin="normal"
      />
      <TextField
        fullWidth
        label="Nhập lại mật khẩu"
        name="confirmPassword"
        type="password"
        value={formData.confirmPassword}
        onChange={handleChange}
        variant="outlined"
        margin="normal"
      />
      <Button
        fullWidth
        variant="contained"
        type="submit"
        color="primary"
        sx={{ mt: 2 }}
        disabled={loading}
      >
        {loading ? 'Đang xử lý...' : 'Đăng Ký'}
      </Button>
    </Box>
  );
};

export default Register;
