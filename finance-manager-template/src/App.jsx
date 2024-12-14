import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Navbar from './components/Navbar';
import Footer from './components/Footer';
import ProtectedRoute from './routes/ProtectedRoute';
import routes from './routes/routes';

function App() {
  return (
    <Router>
      <Navbar />
      <Routes>
        {routes.map((route) => {
          const Element = route.isProtected ? (
            <ProtectedRoute>
              <route.element />
            </ProtectedRoute>
          ) : (
            <route.element />
          );

          return <Route key={route.path} path={route.path} element={Element} />;
        })}
      </Routes>
      <Footer />
    </Router>
  );
}

export default App;
