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

