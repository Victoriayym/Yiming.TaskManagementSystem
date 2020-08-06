import { TaskComponent } from './task/task/task.component';
import { HomeComponent } from './home/home/home.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'app',component:AppComponent },
  {path:'user/alltasks/:id', component:TaskComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
