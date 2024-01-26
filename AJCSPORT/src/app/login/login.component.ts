import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  u:any
  id:string
  password:string
  constructor(private http: HttpClient){}
    
  
 connexion(){
  this.http.get("http://localhost:62264/api/user/"+this.id).subscribe(
      (response) => {
        this.u=response;
       
        console.log(response);
      }
      ,
     (err) => {
        console.log("*************KO")
        
      },

      () => {
        console.log("*********complete****")
        
      }

    );
}




}
