import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentListRoutingModule } from './student-list-routing.module';
import { StudentListComponent } from './student-list.component';
import { FormsModule } from '@angular/forms';
import { CardModule } from 'src/app/theme/shared/components';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NgxPaginationModule } from 'ngx-pagination';

@NgModule({
  imports: [
    CommonModule,
    StudentListRoutingModule,
    FormsModule,
    CardModule,
    Ng2SearchPipeModule,
    NgxPaginationModule
  ],
  declarations:[
      StudentListComponent
  ]
})
export class StudentListModule { }
