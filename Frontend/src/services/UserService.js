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

async function add(Users){

    return await HttpService.post('/Users', Users)
    .then((response)=>{

        return{error: false, message: response.data}

    })
    .catch((e)=>{

        switch(e.response.status){

            case 400:
                let message = '';
                for(const key in e.response.data.errors){

                    message += key + ': ' + e.response.data.errors[key][0] + '\n';

                }
                return {error:true, message: message}
            default:
                return {error: true, message: 'User can not be added!'}

        }

    })

}



export default {

    get,
    deleteU,
    add

};