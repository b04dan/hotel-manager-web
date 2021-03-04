import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Room} from '../models/room';

@Injectable({
  providedIn: 'root'
})
export class RoomsService {
  constructor(private http: HttpClient) {
  }

  getRooms(): Observable<Room[]> {
    return this.http.get<Room[]>(`api/Rooms`);
  }
}
