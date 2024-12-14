import { Box, Typography, TextField, Button } from '@mui/material';

const Settings = () => {
  return (
    <Box sx={{ padding: 4 }}>
      <Typography variant="h4" gutterBottom>
        Settings
      </Typography>
      <TextField
        label="Currency"
        variant="outlined"
        fullWidth
        sx={{ mb: 2 }}
      />
      <Button variant="contained" color="primary">
        Save Settings
      </Button>
    </Box>
  );
};

export default Settings;
