import {Component, OnInit} from '@angular/core';
import {Observable} from 'rxjs';
import {Room} from '../../models/room';
import {RoomsService} from '../../services/rooms.service';
import {SchedulesService} from '../../services/schedules.service';
import {Schedule} from '../../models/schedule';

@Component({
  selector: 'app-schedules-page',
  templateUrl: './schedules-page.component.html',
  styleUrls: ['./schedules-page.component.css']
})
export class SchedulesPageComponent {
  public schedules: Observable<Schedule[]>;

  constructor(private service: SchedulesService) {
    this.schedules = service.getSchedules();
  }
}
