import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';
import {LayoutModule} from '../layout/layout.module';
import {MatIconModule} from '@angular/material/icon';
import {FormsModule} from '@angular/forms';
import {MatCardModule} from '@angular/material/card';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatInputModule} from '@angular/material/input';



@NgModule({
  imports: [
    CommonModule,
    MatTableModule,
    MatPaginatorModule,
    LayoutModule,
    MatIconModule,
    FormsModule,
    MatCardModule,
    MatProgressSpinnerModule,
    MatButtonModule,
    MatToolbarModule,
    MatInputModule
  ],
  exports: [
    CommonModule,
    MatTableModule,
    MatPaginatorModule,
    LayoutModule,
    MatIconModule,
    FormsModule,
    MatCardModule,
    MatProgressSpinnerModule,
    MatButtonModule,
    MatToolbarModule,
    MatInputModule
  ]
})
export class SharedModule { }
