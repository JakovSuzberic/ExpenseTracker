import { HttpService } from "./HttpService";


async function get(){

    return await HttpService.get('/Users')
    .then((response)=>{

        // console.log(response.data)
        //console.table(response.data)
        return {error: false, message: response.data}

    })
    .catch((e)=>{
        
        //console.log(e)
        return {error: true, message: 'Problem kod dohvacanja usera'}

    })

}

async function deleteU(user_Id){

    return await HttpService.delete('/Users/' + user_Id)
    .then((response)=>{

        // console.log(response.data)
        //console.table(response.data)
        return {error: false, message: "Deleted"}

    })
    .catch((e)=>{
        
        //console.log(e)
        return {error: true, message: 'Problem kod brisanja usera'}

    })

}



export default {

    get,
    deleteU

};