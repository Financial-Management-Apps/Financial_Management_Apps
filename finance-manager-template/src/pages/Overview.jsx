// import { Box, Typography } from '@mui/material';
// import { PieChart, Pie, Cell, Tooltip } from 'recharts';

// const Overview = () => {
//   const data = [
//     { name: 'Income', value: 4000 },
//     { name: 'Expenses', value: 3000 },
//   ];
//   const COLORS = ['#0088FE', '#FF8042'];

//   return (
//     <Box sx={{ padding: 4 }}>
//       <Typography variant="h4" gutterBottom>
//         Overview
//       </Typography>
//       <PieChart width={400} height={400}>
//         <Pie
//           data={data}
//           cx="50%"
//           cy="50%"
//           outerRadius={150}
//           fill="#8884d8"
//           dataKey="value"
//         >
//           {data.map((entry, index) => (
//             <Cell key={`cell-${index}`} fill={COLORS[index % COLORS.length]} />
//           ))}
//         </Pie>
//         <Tooltip />
//       </PieChart>
//     </Box>
//   );
// };

// export default Overview;

// pages/OverviewPage.jsx
import { Container, Box } from '@mui/material';
import OverviewList from '../components/OverviewList';

const Overview = () => {
  return (
    <Container>
      <Box sx={{ mt: 5 }}>
        <OverviewList />
      </Box>
    </Container>
  );
};

export default Overview;

