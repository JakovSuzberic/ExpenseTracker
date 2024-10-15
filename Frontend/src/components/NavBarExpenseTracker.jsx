import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import { useNavigate } from 'react-router-dom';
import { RouteNames } from '../constants';


export default function NavBarExpenseTracker(){

    const navigate = useNavigate()

return (
    <>
    
    <Navbar expand="lg" className="bg-body-tertiary">
        <Navbar.Brand className='pointer'
        onClick={()=>navigate(RouteNames.HOME)}
        >Expense Tracker
        </Navbar.Brand>

        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="me-auto">
            <Nav.Link href="http://jakovsuzberic1-001-site1.jtempurl.com/swagger/index.html" target='_blank'>Swagger</Nav.Link>
            
            <NavDropdown title="Budgets" id="basic-nav-dropdown">

            {/*Categorys su transakcije nije bitno kako se nazove */}
              <NavDropdown.Item 
              onClick={()=>navigate(RouteNames.USER_LIST)}
              >Users
              </NavDropdown.Item>

              <NavDropdown.Item href="#action/3.3">Payment mehods</NavDropdown.Item>

            </NavDropdown>
          </Nav>
        </Navbar.Collapse>
      </Navbar>

    
    </>
)

}