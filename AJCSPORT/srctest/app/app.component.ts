import { Component } from '@angular/core';
import { User } from './user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ajcsport';
  u:User = new User()
  ngOnInit(){
    //this.u.isAdmin = true


  }

}
