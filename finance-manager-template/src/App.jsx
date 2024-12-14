// App.jsx
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import MainLayout from './layouts/MainLayout';
import AuthLayout from './layouts/AuthLayout';
import routes from './routes/routes';

function App() {
  return (
    <Router>
      <Routes>
        {routes.map(({ path, element: Component, isProtected }) => {
          const Layout = isProtected ? MainLayout : AuthLayout;

          return (
            <Route
              key={path}
              path={path}
              element={
                <Layout>
                  <Component />
                </Layout>
              }
            />
          );
        })}
      </Routes>
    </Router>
  );
}

export default App;
