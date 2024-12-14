import { Box, Typography } from '@mui/material';
import { LineChart, Line, XAxis, YAxis, CartesianGrid, Tooltip } from 'recharts';

const data = [
  { month: 'Jan', income: 4000, expenses: 2000 },
  { month: 'Feb', income: 3000, expenses: 1500 },
  { month: 'Mar', income: 3500, expenses: 1800 },
];

const Reports = () => {
  return (
    <Box sx={{ padding: 4 }}>
      <Typography variant="h4" gutterBottom>
        Reports
      </Typography>
      <LineChart width={600} height={300} data={data}>
        <CartesianGrid strokeDasharray="3 3" />
        <XAxis dataKey="month" />
        <YAxis />
        <Tooltip />
        <Line type="monotone" dataKey="income" stroke="#8884d8" />
        <Line type="monotone" dataKey="expenses" stroke="#FF6347" />
      </LineChart>
    </Box>
  );
};

export default Reports;
