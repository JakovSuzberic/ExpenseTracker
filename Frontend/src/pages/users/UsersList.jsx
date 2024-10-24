import { useEffect, useState } from "react"
import UserService from "../../services/UserService"
import { Button, Table } from "react-bootstrap";
import moment from "moment";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";


export default function UsersList(){

    const[users, setUsers] = useState();
    const navigate = useNavigate();
    
    async function fetchUsers(){

         const response = await UserService.get();
        if(response.error){
            alert(response.message)
            return
        }
        setUsers(response.message)
    }
    
    useEffect(()=>{

        fetchUsers();

    },[])

    function dateFormat(datum){

        if(datum == null){

            return 'Not defined';

        }

        return moment.utc(datum).format('DD. MM. YYYY.');

    }

    function deleteU(user_Id){

        if(!confirm('Confirm to delete')){

            return;

        }

        deleteUser(user_Id);

    }

    async function deleteUser(user_Id){

        const response = await UserService.deleteU(user_Id);
        if(response.error){
            alert(response.message)
            return;
        }
        fetchUsers();

    }

    const styles = {

        buttonContainer: {
            display: 'flex',
            justifyContent: 'center',
            marginTop: '10px'
        },

        tableContainer:{

            marginTop: '10px'

        }

    };

    return(
    
        <>

        <div style={styles.buttonContainer}>
        <Link to={RouteNames.USER_ADD}
        className='btn btn-success'
        >Add new user
        </Link>
        </div>

        <div style={styles.tableContainer}>
        <Table striped bordered hover responsive>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Created at</th>
                </tr>
            </thead>

            <tbody>
                {users && users.map((users,index)=>(
                    <tr key={index}>
                        <td className="lijevo">
                            {users.name}
                        </td>
                        <td className="centar">
                            {users.email}
                        </td>
                        <td className="centar">
                            {dateFormat(users.created_At)}
                        </td>
                        <td>
                            <Button
                            variant="danger"
                            onClick={()=>deleteU(users.user_Id)}
                            >
                                Delete
                            </Button>
                        </td>
                        <td>
                            <Button
                            onClick={()=>navigate(`/users/${users.user_Id}`)}
                            >
                                Change
                            </Button>
                        </td>
                    </tr>
                ))}
            </tbody>
        </Table>
        </div>
    
        </>
    )
}