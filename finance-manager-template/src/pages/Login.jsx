import { useState } from 'react';
import { useDispatch } from 'react-redux';
import { useNavigate, Link } from 'react-router-dom';
import { login, setUser } from '../redux/slices/authSlice';
import { toast, ToastContainer } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import {
  Box,
  TextField,
  Button,
  Typography,
  Card,
  CardContent,
  CardActions,
  Divider,
} from '@mui/material';

const Login = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState('');
  const navigate = useNavigate();
  const dispatch = useDispatch();

  const handleSubmit = async (e) => {
    e.preventDefault();
    setError(''); // Clear previous errors

    try {
      const user = await dispatch(
        login({ emailInput: email, passwordInput: password })
      ).unwrap();
      dispatch(setUser(user));

      // Show success notification
      toast.success('Login successful! Redirecting...', {
        position: 'top-right',
        autoClose: 1500,
      });

      setTimeout(() => {
        navigate('/');
      }, 2000);
    } catch (err) {
      setError(err); // Display error if any
      toast.error(err || 'Login failed!', {
        position: 'top-right',
        autoClose: 3000,
      });
    }
  };

  return (
    <Box
      display="flex"
      justifyContent="center"
      alignItems="center"
      height="100vh"
      bgcolor="background.default"
    >
      <ToastContainer />
      <Card
        sx={{
          width: 400,
          padding: 3,
          boxShadow: 3,
        }}
      >
        <CardContent>
          <Typography variant="h4" component="div" gutterBottom textAlign="center">
            Login
          </Typography>
          <Divider sx={{ mb: 2 }} />
          {error && (
            <Typography color="error" textAlign="center" gutterBottom>
              {error}
            </Typography>
          )}
          <form onSubmit={handleSubmit}>
            <TextField
              fullWidth
              label="Email"
              type="email"
              margin="normal"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              required
              sx={{ transition: 'border-color 0.3s', '&:focus-within': { borderColor: '#1976d2' } }}
            />
            <TextField
              fullWidth
              label="Password"
              type="password"
              margin="normal"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              required
              sx={{ transition: 'border-color 0.3s', '&:focus-within': { borderColor: '#1976d2' } }}
            />
            <Button
              fullWidth
              type="submit"
              variant="contained"
              color="primary"
              sx={{
                mt: 2,
                transition: 'background-color 0.3s',
                '&:hover': { backgroundColor: '#1565c0' },
              }}
            >
              Login
            </Button>
          </form>
        </CardContent>
        <CardActions sx={{ justifyContent: 'center', mt: 1 }}>
          <Typography variant="body2">
            Don&apos;t have an account?{' '}
            <Link to="/register" style={{ textDecoration: 'none', color: '#1976d2' }}>
              Register here
            </Link>
          </Typography>
        </CardActions>
      </Card>
    </Box>
  );
};

export default Login;
