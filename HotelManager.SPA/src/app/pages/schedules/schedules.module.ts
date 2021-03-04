import { NgModule } from '@angular/core';
import { SchedulesPageComponent } from './schedules-page.component';
import { SchedulesTableComponent } from './schedules-table/schedules-table.component';
import {RouterModule, Routes} from '@angular/router';
import {SharedModule} from '../../shared/shared.module';
import {PipesModule} from '../../pipes/pipes.module';


const routes: Routes = [
  {
    path: '',
    component: SchedulesPageComponent
  }
];

@NgModule({
  declarations: [SchedulesPageComponent, SchedulesTableComponent],
  imports: [
    SharedModule,
    RouterModule.forChild(routes),
    PipesModule
  ]
})
export class SchedulesModule { }
