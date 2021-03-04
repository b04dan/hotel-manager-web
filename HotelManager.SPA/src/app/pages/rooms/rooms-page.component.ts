import { Component, OnInit } from '@angular/core';
import {Observable} from 'rxjs';
import {Room} from '../../models/room';
import {RoomsService} from '../../services/rooms.service';

@Component({
  selector: 'app-rooms-page',
  templateUrl: './rooms-page.component.html',
  styleUrls: ['./rooms-page.component.css']
})
export class RoomsPageComponent {
  public rooms: Observable<Room[]>;

  constructor(private service: RoomsService) {
    this.rooms = service.getRooms();
  }
}
