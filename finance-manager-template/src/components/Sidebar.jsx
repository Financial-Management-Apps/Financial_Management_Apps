import { Box, List, ListItem, ListItemText } from '@mui/material';
import { Link } from 'react-router-dom';

const Sidebar = () => {
  const menuItems = [
    { label: 'Overview', path: '/overview' },
    { label: 'Income', path: '/income' },
    { label: 'Expenses', path: '/expenses' },
    { label: 'Reports', path: '/reports' },
    { label: 'Settings', path: '/settings' },
  ];

  return (
    <Box sx={{ width: 150, height: '100vh', bgcolor: 'lightgray', padding: 2 }}>
      <List>
        {menuItems.map((item, index) => (
          <ListItem button key={index} component={Link} to={item.path}>
            <ListItemText primary={item.label} />
          </ListItem>
        ))}
      </List>
    </Box>
  );
};

export default Sidebar;
