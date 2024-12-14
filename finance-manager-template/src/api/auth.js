import axios from 'axios';

const baseUrl = import.meta.env.VITE_API_URL

// Hàm gọi API đăng nhập
export const loginUser = async ({ emailInput, passwordInput }) => {
  try {
    const response = await axios.post(`${baseUrl}/api/Finance/NguoiDung`, {
      emailInput,     // Đặt key là emailInput
      passwordInput,  // Đặt key là passwordInput
    });
    console.log('Response from Backend:', response.data);
    return response.data;
  } catch (error) {
    throw new Error(error.response?.data?.message || 'Login API failed');
  }
};

// Hàm gọi API đăng ký
export const registerUser = async (userDetails) => {
  try {
    const response = await axios.post(`${baseUrl}/api/Finance/TaiKhoan`, userDetails);
    console.log('Register Response:', response.data); // Log dữ liệu trả về
    return response.data;
  } catch (error) {
    console.error('Register API Error:', error.response?.data || error.message);
    throw new Error(error.response?.data?.message || 'Registration API failed');
  }
};
