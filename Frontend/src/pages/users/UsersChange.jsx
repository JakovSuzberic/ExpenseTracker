import UserService from "../../services/UserService"
import { Button, Col, Form, Row } from "react-bootstrap";
import moment from "moment";
import { Link, useNavigate, useParams } from "react-router-dom";
import { RouteNames } from "../../constants";
import { useEffect } from "react";
import { useState } from "react";
import useLoading from "../../hooks/useLoading";


export default function UsersChange(){

    const [userObj, setUserObj] = useState({});
    const navigate = useNavigate();
    const routeParams = useParams();
    const { showLoading, hideLoading } = useLoading();

    async function fetchUser(){

        showLoading();
        const response = await UserService.getByUserId(routeParams.user_id);
        hideLoading();

        if(response.error){
           alert(response.message)
           return
        }

        let s = response.message
        s.created_At=moment.utc(s.created_At).format('yyyy-MM-DD')
        setUserObj(s)
        console.log(s)
    }

    useEffect(()=>{

        fetchUser();

    },[])

    async function change(Users){

        showLoading();
        const response = await UserService.change(routeParams.user_id, Users);
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

        change({
            name: data.get('name'),
            email: data.get('email'),
            password: "",
            created_At: moment.utc(data.get('created_At'))
        })

    }


    const styles = {

        buttonContainer:{

            width: '25%',
            marginTop: 15,
            

        },

        changeUserText:{

            marginTop: 15,
            textAlign: 'center',
            fontSize:'24px',
            fontWeight: 'bold',
            color: '#0d6efd'

        }

    };

    
    return(
    
        <>

        <div style={styles.changeUserText}>

        Change user

        </div>

        <Form onSubmit={processSubmit}>
       
            <Form.Group controlId = "name">
                <Form.Label>Name</Form.Label>
                <Form.Control type = "text" name = "name" required defaultValue={userObj.name} />
            </Form.Group>

            <Form.Group controlId = "email">
                <Form.Label>Email</Form.Label>
                <Form.Control type = "text" name = "email" defaultValue={userObj.email} />
            </Form.Group>


            <Form.Group controlId = "created_At">
                <Form.Label>Created at</Form.Label>
                <Form.Control type = "date" name = "created_At" required defaultValue={userObj.created_At}/>
            </Form.Group>


        <Row className="d-flex justify-content-between">

            <Col style={styles.buttonContainer}>
            <Button className="w-100" type="submit">
                Change user
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