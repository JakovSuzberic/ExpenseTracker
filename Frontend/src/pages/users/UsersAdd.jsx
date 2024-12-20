import UserService from "../../services/UserService"
import { Button, Col, FormLabel, Row,Form } from "react-bootstrap";
import moment from "moment";
import {  Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";
import useLoading from "../../hooks/useLoading";


export default function UsersAdd(){

    const navigate = useNavigate();
    const { showLoading, hideLoading } = useLoading();


    async function add(Users){

        showLoading();
        const response = await UserService.add(Users);
        hideLoading();

        if(response.error){

            alert(response.error)
            return;

        }
        navigate(RouteNames.USER_LIST)

    }

    function processSubmit(e){

        e.preventDefault();
        let data = new FormData(e.target)

        add({

            name: data.get('name'),
            email: data.get('email'),
            password: "",
            created_At: moment.utc(data.get('created_At'))

        })

    }


    const styles = {

        buttonContainer:{

            width: '25%',
            marginTop: 15

        },

        newUserText:{

            marginTop: 15,
            textAlign: 'center',
            fontSize:'24px',
            fontWeight: 'bold'

        }

    };

    
    return(
    
        <>

        <div style={styles.newUserText}>

        New user

        </div>

        <Form onSubmit={processSubmit}>

            <Form.Group controlId = "name">
                <Form.Label>Name</Form.Label>
                <Form.Control type = "text" name = "name" required />
            </Form.Group>

            <Form.Group controlId = "email">
                <Form.Label>Email</Form.Label>
                <Form.Control type = "text" name = "email"/>
            </Form.Group>

            <Form.Group controlId = "created_At">
                <Form.Label>Created at</Form.Label>
                <Form.Control type = "date" name = "created_At" required />
            </Form.Group>

        



        <Row className="d-flex justify-content-between">

            <Col style={styles.buttonContainer}>
            <Button variant="success" className="w-100" type="submit">
                Add user
            </Button>
            </Col>
      
            <Col style={styles.buttonContainer}>
            <Link to={RouteNames.USER_LIST}
            className = "btn btn-danger w-100">
            Cancel
            </Link>
            </Col>
            
        </Row>
        
        </Form>

        </>
    )
}