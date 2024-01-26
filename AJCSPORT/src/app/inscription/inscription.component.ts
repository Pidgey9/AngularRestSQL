import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-inscription',
  templateUrl: './inscription.component.html',
  styleUrls: ['./inscription.component.css']
})
export class InscriptionComponent {
  mail:string
  u={id: '',password:'',nom:'',prenom:'',adresse:'',date_naissance:'',isAdmin:0};
  message: string;

  constructor(private http: HttpClient) { }



  inscrit()
  {
    this.u.date_naissance = "2024-01-26"
    const body=JSON.stringify(this.u);
 
    this.http.post("http://localhost:62264/api/user",body,{
      headers: new HttpHeaders({
        "Content-Type": "application/json"
      })
    }).subscribe(response => {

   
      this.message="Merci " + this.u.nom + " " + this.u.prenom + " d'avoir rejoint la communauté AJCSPORT !"

    },

      err => {
        
       this.message="erreur"
     });

  }

}
