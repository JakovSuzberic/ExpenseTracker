import { useEffect } from "react"
import UserService from "../../services/UserService"


export default function UsersList(){

    async function fetchUsers(){

         await UserService.get();

    }
    
    useEffect(()=>{

        fetchUsers();

    },[])

    return(
    
        <>
    
            Ovdi dode nesto pregled usera
    
        </>
    )
}