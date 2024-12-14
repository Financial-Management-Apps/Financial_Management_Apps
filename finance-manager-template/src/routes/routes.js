import Login from '../pages/Login';
import Register from '../pages/Register';
import Dashboard from '../pages/Dashboard';
import Overview from '../pages/Overview';
import Income from '../pages/Income';
import Expenses from '../pages/Expenses';
import Reports from '../pages/Reports';
import Settings from '../pages/Settings';

const routes = [
  { path: '/', element: Dashboard, isProtected: true },
  { path: '/login', element: Login, isProtected: false },
  { path: '/register', element: Register, isProtected: false },
  { path: '/overview', element: Overview, isProtected: true },
  { path: '/income', element: Income, isProtected: true },
  { path: '/expenses', element: Expenses, isProtected: true },
  { path: '/reports', element: Reports, isProtected: true },
  { path: '/settings', element: Settings, isProtected: true },
];

export default routes;
