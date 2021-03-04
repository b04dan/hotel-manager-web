import {Component, Inject} from '@angular/core';
import {MAT_DIALOG_DATA} from '@angular/material/dialog';
import {ScheduleDialogData} from './ScheduleDialogData';

@Component({
  selector: 'app-schedule-dialog',
  templateUrl: './schedule-dialog.component.html',
  styleUrls: ['./schedule-dialog.component.css']
})
export class ScheduleDialogComponent {
  constructor(@Inject(MAT_DIALOG_DATA) public data: ScheduleDialogData) {
  }
}
