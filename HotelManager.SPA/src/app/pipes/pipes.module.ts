import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {ResidenceDatePipe} from './residence-date.pipe';
import { ScheduleCellPipe } from './schedule-cell.pipe';


@NgModule({
  declarations: [
    ResidenceDatePipe,
    ScheduleCellPipe],
  imports: [
    CommonModule
  ],
  exports: [
    ResidenceDatePipe,
    ScheduleCellPipe
  ]
})
export class PipesModule {
}
