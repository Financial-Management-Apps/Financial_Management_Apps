import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import { loginUser, registerUser } from '../../api/auth';
import { toast } from 'react-toastify';

// Thunk: Đăng nhập
export const login = createAsyncThunk(
  'auth/login',
  async (credentials, { rejectWithValue }) => {
    try {
      const data = await loginUser(credentials);
      console.log('Data received in Thunk:', data); // Kiểm tra dữ liệu
      return data;
    } catch (error) {
      return rejectWithValue(error.message || 'Login failed');
    }
  }
);

// Thunk: Đăng ký
export const register = createAsyncThunk(
  '/api/Finance/TaiKhoan',
  async (userDetails, { rejectWithValue }) => {
    try {
      const response = await registerUser(userDetails);
      toast.success('Đăng ký thành công!');
      return {
        user: response.user,
      };
    } catch (error) {
      toast.error(error.message); // Hiển thị lỗi Toast
      return rejectWithValue(error.message || 'Registration failed');
    }
  }
);

// Slice quản lý Auth và User
const authSlice = createSlice({
  name: 'auth',
  initialState: {
    user: null,
    isAuthenticated: false,
    loading: false,
    error: null,
  },
  reducers: {
    setUser(state, action) {
      state.user = action.payload;
      state.isAuthenticated = !!action.payload; // Xác định trạng thái đăng nhập
    },
    clearUser(state) {
      state.user = null; // Xóa thông tin user
      state.isAuthenticated = false; // Reset trạng thái đăng nhập
    },
    logout(state) {
      state.user = null;
      state.isAuthenticated = false;
    },
  },
  extraReducers: (builder) => {
    builder
      // Đăng nhập
      .addCase(login.pending, (state) => {
        state.loading = true;
        state.error = null;
      })
      .addCase(login.fulfilled, (state, { payload }) => {
        state.loading = false;
        if (Array.isArray(payload) && payload.length > 0) {
          state.user = payload[0]; // Trường hợp API trả về mảng
        } else if (payload) {
          state.user = payload; // Trường hợp API trả về object
        } else {
          state.user = null; // Xử lý trường hợp không có dữ liệu
        }
        state.isAuthenticated = !!state.user; // Cập nhật trạng thái đăng nhập
        console.log('User stored in Redux:', state.user); // Log user trong store
      })
      .addCase(login.rejected, (state, { payload }) => {
        state.loading = false;
        state.error = payload || 'Login failed';
      })
      // Đăng ký
      // Xử lý trạng thái đăng ký
      .addCase(register.pending, (state) => {
        state.loading = true;
        state.error = null;
      })
      .addCase(register.fulfilled, (state, { payload }) => {
        state.loading = false;
        state.user = payload[0];
        state.isAuthenticated = true;
      })
      .addCase(register.rejected, (state, { payload }) => {
        state.loading = false;
        state.error = payload || 'Registration failed';
      });
  },
});

export const { setUser, clearUser, logout } = authSlice.actions;
export default authSlice.reducer;
