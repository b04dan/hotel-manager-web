import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AboutPageComponent } from './about-page.component';
import {LayoutModule} from '../../layout/layout.module';
import {MatToolbarModule} from '@angular/material/toolbar';
import {RouterModule, Routes} from '@angular/router';

const routes: Routes = [
  {
    path: '',
    component: AboutPageComponent
  }
];

@NgModule({
  declarations: [AboutPageComponent],
  imports: [
    CommonModule,
    LayoutModule,
    MatToolbarModule,
    RouterModule.forChild(routes),
  ]
})
export class AboutModule { }
