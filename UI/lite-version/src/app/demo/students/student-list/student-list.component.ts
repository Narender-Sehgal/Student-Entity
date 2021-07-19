import { Component, OnInit } from '@angular/core';
import { StudentService } from '../student.service';
import { Router } from '@angular/router';
import { PaginateService } from './pagination.service';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.scss'],
})

export class StudentListComponent implements OnInit {

  searchValue: string;
  studentList: any = [];
  pageCount: number;
  itemsPerPage: number = 5;
  totalRecords: any;
  isShown: boolean = true;
 
  constructor(public service: StudentService, private serv: PaginateService, private router: Router) { }

  ngOnInit() {
    this.getPage(1);
    this.getStudentsList();
  }
  getStudentsList() {
    return this.service.getStudents().subscribe((response: {}) => {
      this.studentList = response;
    })
  }

  disablePaging() {
    this.isShown = !this.isShown;
  }

  getPage(evt) {
      this.pageCount = evt;
      this.serv.pagination(this.pageCount,this.itemsPerPage).subscribe((data:any)=>{
      this.totalRecords = data.count;
    })
  }
  
  transferId(id){
    this.service.emitNextStudentId(id);
    this.router.navigate(['/studentform'])
  }
}
