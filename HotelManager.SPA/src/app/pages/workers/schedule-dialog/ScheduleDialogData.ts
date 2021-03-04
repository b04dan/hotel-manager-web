import {Worker} from '../../../models/worker';
import {Schedule} from '../../../models/schedule';

export interface ScheduleDialogData {
  worker: Worker;
  schedule: Schedule;
}
