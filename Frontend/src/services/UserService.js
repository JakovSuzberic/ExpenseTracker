import { HttpService } from "./HttpService";


async function get(){

    return await HttpService.get('/user')
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

export default {

    get

};