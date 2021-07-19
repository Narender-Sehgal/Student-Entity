import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentFormRoutingModule } from './studentform-routing.module';
import { StudentformComponent } from './studentform.component';
import { CardModule } from 'src/app/theme/shared/components';
import { FormsModule } from '@angular/forms';

@NgModule({
  imports: [
    CommonModule,
    StudentFormRoutingModule,
    CardModule,
    FormsModule
  ],
  declarations:[
    StudentformComponent
  ],
  providers:[
 
  ]
})
export class StudentFormModule { }
