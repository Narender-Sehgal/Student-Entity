import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StudentListComponent } from './student-list.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'student-list',
        component:StudentListComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StudentListRoutingModule { }
