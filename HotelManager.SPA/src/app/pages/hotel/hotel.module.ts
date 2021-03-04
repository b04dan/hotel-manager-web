import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HotelPageComponent } from './hotel-page.component';
import {LayoutModule} from '../../layout/layout.module';
import {MatToolbarModule} from '@angular/material/toolbar';
import {RouterModule, Routes} from '@angular/router';
import {MatButtonModule} from '@angular/material/button';

const routes: Routes = [
  {
    path: '',
    component: HotelPageComponent
  }
];

@NgModule({
  declarations: [HotelPageComponent],
    imports: [
        CommonModule,
        LayoutModule,
        MatToolbarModule,
        RouterModule.forChild(routes),
        MatButtonModule,
    ]
})
export class HotelModule { }
