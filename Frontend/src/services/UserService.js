import { HttpService } from "./HttpService";


async function get(){

    return await HttpService.get('/user')
    .then((response)=>{

        console.log(response.data)
        console.table(response.data)

    })
    .catch((e)=>console.log(e))

}

export default {

    get

}