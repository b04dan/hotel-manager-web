import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Residence} from '../models/residence';

@Injectable({
  providedIn: 'root'
})
export class HotelService {
  constructor(private http: HttpClient) {
  }

  initializeTestData(): Observable<any> {
    return this.http.post(`api/Hotel/Initialize`, null);
  }
}
