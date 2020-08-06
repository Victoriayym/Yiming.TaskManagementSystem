import { UserService } from './../../services/user.service';
import { User } from './../../models/user';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
users:User[];
  constructor(private userService:UserService) { }

  ngOnInit(): void {
    this.userService.getAllUsers().subscribe(
      (users)=>{
        console.log(users);
        this.users=users;
      }
    )
  }

}
