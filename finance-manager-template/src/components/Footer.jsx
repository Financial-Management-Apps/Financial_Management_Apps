import { Box, Typography, Link } from '@mui/material';

const Footer = () => {
  return (
    <Box
      component="footer"
      sx={{
        backgroundColor: '#333',
        color: '#fff',
        py: 2,
        textAlign: 'center',
      }}
    >
      <Typography variant="body2" gutterBottom>
        &copy; {new Date().getFullYear()} Financial Management App. All Rights Reserved.
      </Typography>
      <Box sx={{ display: 'flex', justifyContent: 'center', gap: 2 }}>
        <Link href="/about" color="inherit" underline="hover">
          About
        </Link>
        <Link href="/contact" color="inherit" underline="hover">
          Contact
        </Link>
        <Link href="/privacy" color="inherit" underline="hover">
          Privacy Policy
        </Link>
      </Box>
      <Typography variant="body2" sx={{ mt: 1 }}>
        Contact us: <Link href="mailto:support@financialapp.com" color="inherit">support@financialapp.com</Link>
      </Typography>
    </Box>
  );
};

export default Footer;
