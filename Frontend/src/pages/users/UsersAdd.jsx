import UserService from "../../services/UserService"
import { Button, Col, Row } from "react-bootstrap";
import moment from "moment";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";


export default function UsersAdd(){

    const navigate = useNavigate();
    
    return(
    
        <>

        Adding Users

        <Row>
            
            <Col>
            <Button variant="success">Add user</Button>
            </Col>

            <Col>
            <Link to={RouteNames.USER_LIST}
            className = "btn btn-danger">
            Cancle
            </Link>
            </Col>
        
        </Row>
    

    
        </>
    )
}