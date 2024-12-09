import Login from '../pages/Login';
import Register from '../pages/Register';
import Dashboard from '../pages/Dashboard';

const routes = [
  {
    path: '/',
    element: Login,
    isProtected: false,
  },
  {
    path: '/register',
    element: Register,
    isProtected: false,
  },
  {
    path: '/dashboard',
    element: Dashboard,
    isProtected: true,
  },
];

export default routes;
