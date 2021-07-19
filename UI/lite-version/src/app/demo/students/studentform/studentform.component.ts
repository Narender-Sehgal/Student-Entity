import { Component, OnInit } from '@angular/core';
import { StudentService } from '../student.service';
import { Router } from '@angular/router';
import { StudentForm } from './studentform.model';
import { formatDate } from '@angular/common';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-studentform',
  templateUrl: './studentform.component.html',
  styleUrls: ['./studentform.component.scss'],
})
export class StudentformComponent implements OnInit {

  student: StudentForm = new StudentForm();
  subscription: Subscription;
  
  constructor(private service: StudentService, private route: Router) {
  
  }
  
  ngOnInit() {
    this.subscription = this.service.studentId$.subscribe(id => {
      if (id) {
        // this.subscription.unsubscribe();
        this.service.getStudentByID(+id).subscribe(res=>{
          if(res){
            this.student = res;
            const formattedDate = formatDate(this.student.dob,'MM-dd-yyyy','en-US')
            this.student.dob = formattedDate;
          }
          else{
            console.log('response not found from api');
          }
          this.subscription.unsubscribe();
        })
      }
    })
  }

  backPage() {
    this.route.navigate(['students/student-list'])
  }
}