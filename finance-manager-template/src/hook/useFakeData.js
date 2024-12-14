// hooks/useFakeData.js
import { useState, useEffect } from 'react';
import { generateFakeTransactions } from '../utils/fakeData'; // Import hàm tạo dữ liệu giả

const useFakeData = (count = 100) => {
  const [data, setData] = useState([]);

  useEffect(() => {
    // Kiểm tra nếu dữ liệu đã có trong localStorage
    const storedData = localStorage.getItem('transactions');
    
    if (storedData) {
      setData(JSON.parse(storedData)); // Sử dụng dữ liệu từ localStorage
    } else {
      const fakeData = generateFakeTransactions(count); // Tạo dữ liệu giả
      localStorage.setItem('transactions', JSON.stringify(fakeData)); // Lưu vào localStorage
      setData(fakeData); // Set dữ liệu vào state
    }
  }, [count]);

  return data;
};

export default useFakeData;
