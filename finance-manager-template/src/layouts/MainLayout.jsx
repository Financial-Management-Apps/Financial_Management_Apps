import { Grid } from '@mui/material';
import Navbar from '../components/Navbar';
import Footer from '../components/Footer';
import Sidebar from '../components/Sidebar';

const MainLayout = ({ children }) => {
  return (
    <Grid container sx={{ minHeight: '100vh' }}>
      {/* Navbar */}
      <Grid item xs={12}>
        <Navbar />
      </Grid>

      {/* Content with Sidebar */}
      <Grid container item xs={12} sx={{ flexGrow: 1 }}>
        {/* Sidebar */}
        <Grid
          item
          sx={{
            width: 240, // Sidebar width
            bgcolor: 'lightgray',
            display: { xs: 'none', sm: 'block' }, // Ẩn trên màn hình nhỏ
          }}
        >
          <Sidebar />
        </Grid>

        {/* Main Content */}
        <Grid
          item
          sx={{
            flexGrow: 1,
            p: 2,
            overflowY: 'auto',
          }}
        >
          {children}
        </Grid>
      </Grid>

      {/* Footer */}
      <Grid item xs={12}>
        <Footer />
      </Grid>
    </Grid>
  );
};

export default MainLayout;
