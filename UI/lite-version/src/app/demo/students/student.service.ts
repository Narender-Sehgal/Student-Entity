import { HttpClient} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { StudentForm } from './studentform/studentform.model';

@Injectable({providedIn: 'root'})
export class StudentService {
  
  readonly getUrl = "http://localhost:64640/api/Students/GetStudents";
  readonly getbyIdUrl = "http://localhost:64640/api/Students/GetStudentById";

  studentId$: BehaviorSubject<any> = new BehaviorSubject(undefined);

  constructor(private http : HttpClient) {
    
   }
    getStudents() {
      return this.http.get(this.getUrl);
    }
   
    getStudentByID(id){
      return this.http.get<StudentForm>(this.getbyIdUrl + '?' + 'id='+ id);
    } 

    emitNextStudentId(id) {
      this.studentId$.next(id);
    }
}
