import { useEffect, useState } from "react"
import UserService from "../../services/UserService"
import { Table } from "react-bootstrap";


export default function UsersList(){

    const[users, setUsers] = useState();
    
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

    return(
    
        <>
    
        <Table striped bordered hover responsive>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Created at</th>
                </tr>
            </thead>

            <tbody>
                {users && users.map((user,index)=>(
                    <tr key={index}>
                        <td>
                            {user.name}
                        </td>
                        <td>
                            {user.email}
                        </td>
                        <td>
                            {user.created_At}
                        </td>
                        <td>Action</td>
                    </tr>
                ))}
            </tbody>
        </Table>
    
        </>
    )
}