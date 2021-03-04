import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SettingsPageComponent } from './settings-page.component';
import {MatToolbarModule} from '@angular/material/toolbar';
import {LayoutModule} from '../../layout/layout.module';
import {RouterModule, Routes} from '@angular/router';

const routes: Routes = [
  {
    path: '',
    component: SettingsPageComponent
  }
];

@NgModule({
  declarations: [SettingsPageComponent],
  imports: [
    CommonModule,
    MatToolbarModule,
    LayoutModule,
    RouterModule.forChild(routes),
  ]
})
export class SettingsModule { }
