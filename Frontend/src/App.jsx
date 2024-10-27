import 'bootstrap/dist/css/bootstrap.min.css';
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import './App.css'
import NavBarExpenseTracker from './components/NavBarExpenseTracker';
import { Route, Routes } from 'react-router-dom';
import { RouteNames } from './constants';
import Home from './pages/home';
import UsersList from './pages/users/UsersList';
import UsersAdd from './pages/users/UsersAdd';
import UsersChange from './pages/users/UsersChange';
import LoadingSpinner from './components/LoadingSpinner';


function App() {
  

  return (
    <>
       
    <LoadingSpinner />
    <Container>

        <NavBarExpenseTracker />
        
        <Routes>

        <Route path={RouteNames.HOME} element={<Home/>} />
        
        <Route path={RouteNames.USER_LIST} element={<UsersList/>} />
        <Route path={RouteNames.USER_ADD} element={<UsersAdd/>} />
        <Route path={RouteNames.USER_CHANGE} element={<UsersChange/>} />

        </Routes>

      <hr/>
      &copy; Jakov Šužberić
    </Container>

    </>
  )
}

export default App
