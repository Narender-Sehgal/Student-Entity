import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StudentformComponent } from './studentform.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: '',
        component: StudentformComponent
     }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StudentFormRoutingModule { }
