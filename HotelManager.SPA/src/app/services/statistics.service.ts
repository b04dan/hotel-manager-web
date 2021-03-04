import {Injectable} from '@angular/core';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {CheckInOutStatistics} from '../models/statistics/checkInOut';

@Injectable({
  providedIn: 'root'
})
export class StatisticsService {

  constructor(private http: HttpClient) {
  }

  getCheckInOutStatistics(maxNumber: number): Observable<CheckInOutStatistics[]> {
    return this.http.get<CheckInOutStatistics[]>(`api/Statistics/checkInOut/${maxNumber}`);
  }

  getNumbersStatistics(): Observable<any> {
    return this.http.get(`api/Statistics/numbers`);
  }

  getOccupancyStatistics(): Observable<any> {
    return this.http.get(`api/Statistics/occupancy`);
  }
}
