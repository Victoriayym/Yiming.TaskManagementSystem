import { TaskService } from './../../services/task.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AllTask } from 'src/app/models/allTask';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css']
})
export class TaskComponent implements OnInit {
userId:number;
allTask:AllTask;
  constructor(private route:ActivatedRoute, private taskService:TaskService) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      this.userId = +params.get('id');
      this.taskService.getAllTasks(this.userId).subscribe((t) => {
        this.allTask= t;
        console.log(this.allTask);
      });
    });
  }

}
