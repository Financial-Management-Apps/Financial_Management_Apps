import { faker } from '@faker-js/faker';

// Hàm định dạng số với khoảng trắng giữa các nhóm ba chữ số
const formatAmount = (value) => {
  const formatter = new Intl.NumberFormat('en-US', {
    minimumFractionDigits: 0,
    maximumFractionDigits: 0,
    useGrouping: true,
    groupingSeparator: ' ', // Dùng khoảng trắng làm phân cách
  });
  return formatter.format(value);
};

// Hàm tạo dữ liệu giả
export const generateFakeTransactions = (count = 100) => {
  const transactions = [];
  for (let i = 0; i < count; i++) {
    const isPositive = Math.random() > 0.5; // 50% cộng tiền, 50% trừ tiền
    const rawAmount = isPositive
      ? faker.number.int({ min: 10000, max: 5000000 }) // Số nguyên dương
      : -faker.number.int({ min: 10000, max: 5000000 }); // Số nguyên âm

    transactions.push({
      id: faker.string.uuid(),
      amount: rawAmount, // Giá trị gốc (để tính toán nếu cần)
      formattedAmount: `${rawAmount > 0 ? '+' : ''}${formatAmount(rawAmount)}`, // Định dạng hiển thị
      date: faker.date.between({ from: '2023-01-01', to: '2023-12-31' }).toISOString(),
      category: faker.helpers.arrayElement(['Food', 'Travel', 'Salary', 'Shopping', 'Other']),
    });
  }
  return transactions;
};
