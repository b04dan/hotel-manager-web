import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportsPageComponent } from './reports-page.component';
import {LayoutModule} from '../../layout/layout.module';
import {MatToolbarModule} from '@angular/material/toolbar';
import {RouterModule, Routes} from '@angular/router';

const routes: Routes = [
  {
    path: '',
    component: ReportsPageComponent
  }
];

@NgModule({
  declarations: [ReportsPageComponent],
  imports: [
    CommonModule,
    LayoutModule,
    MatToolbarModule,
    RouterModule.forChild(routes),
  ]
})
export class ReportsModule { }
