import axios from "axios";
import { tokenToString } from "typescript";

const BaseUrl = "http://localhost:5039/"

const instance = axios.create(
    {
        baseURL: BaseUrl,
        headers : 
        {
            'Content-Type': 'application/json'
        }
    }
)


export default instance