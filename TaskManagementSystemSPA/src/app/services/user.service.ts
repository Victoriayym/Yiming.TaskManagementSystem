import { User } from './../models/user';
import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private apiService:ApiService) { }
  getAllUsers(): Observable<User[]>
  {
    return this.apiService.getALL('user/allusers');
  }
  
}
