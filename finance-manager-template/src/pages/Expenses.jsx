import { Box, Typography, List, ListItem, ListItemText } from '@mui/material';
import { BarChart, Bar, XAxis, YAxis, CartesianGrid, Tooltip } from 'recharts';

const data = [
  { name: 'Rent', amount: 1200 },
  { name: 'Groceries', amount: 600 },
  { name: 'Utilities', amount: 300 },
  { name: 'Entertainment', amount: 400 },
];

const Expenses = () => {
  return (
    <Box sx={{ padding: 4 }}>
      <Typography variant="h4" gutterBottom>
        Expenses
      </Typography>
      <List>
        {data.map((item, index) => (
          <ListItem key={index}>
            <ListItemText primary={item.name} secondary={`$${item.amount}`} />
          </ListItem>
        ))}
      </List>
      <BarChart width={500} height={300} data={data}>
        <CartesianGrid strokeDasharray="3 3" />
        <XAxis dataKey="name" />
        <YAxis />
        <Tooltip />
        <Bar dataKey="amount" fill="#FF6347" />
      </BarChart>
    </Box>
  );
};

export default Expenses;
