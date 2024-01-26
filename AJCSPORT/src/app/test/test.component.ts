import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent {
  listuser : any;
  listarticle:any
  listcommande:any

  constructor(private http: HttpClient) { }

  ngOnInit(): void {

    this.http.get("http://localhost:62264/api/user").subscribe(
      (response) => {
        this.listuser=response;
       
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
    this.http.get("http://localhost:62264/api/article").subscribe(
      (response) => {
        this.listarticle=response;
       
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
    this.http.get("http://localhost:62264/api/commande").subscribe(
      (response) => {
        this.listcommande=response;
       
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
