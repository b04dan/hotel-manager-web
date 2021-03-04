import {NgModule} from '@angular/core';
import {WorkersPageComponent} from './workers-page.component';
import {WorkersTableComponent} from './workers-table/workers-table.component';
import {ScheduleDialogComponent} from './schedule-dialog/schedule-dialog.component';
import {RouterModule, Routes} from '@angular/router';
import {PipesModule} from '../../pipes/pipes.module';
import {SharedModule} from '../../shared/shared.module';
import {MatDialogModule} from '@angular/material/dialog';

const routes: Routes = [
  {
    path: '',
    component: WorkersPageComponent
  }
];

@NgModule({
  declarations: [WorkersPageComponent, WorkersTableComponent, ScheduleDialogComponent],
  imports: [
    SharedModule,
    PipesModule,
    RouterModule.forChild(routes),
    MatDialogModule
  ]
})
export class WorkersModule {
}
