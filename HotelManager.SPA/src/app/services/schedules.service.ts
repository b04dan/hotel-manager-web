import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Schedule} from '../models/schedule';

@Injectable({
  providedIn: 'root'
})
export class SchedulesService {
  constructor(private http: HttpClient) {
  }

  getById(id: number): Observable<Schedule> {
    return this.http.get<Schedule>(`api/Schedules/${id}`);
  }

  getSchedules(): Observable<Schedule[]> {
    return this.http.get<Schedule[]>(`api/Schedules`);
  }
}
