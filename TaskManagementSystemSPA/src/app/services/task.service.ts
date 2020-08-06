import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import {AllTask} from './../models/allTask';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class TaskService {


  constructor(private apiService:ApiService) { }

  getAllTasks(userId:number):Observable<AllTask>{
    return this.apiService.getOne('user/alltasks', userId);
      
  }
}
