import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Worker} from '../models/worker';

@Injectable({
  providedIn: 'root'
})
export class WorkersService {
  constructor(private http: HttpClient) {
  }

  getWorkers(): Observable<Worker[]> {
    return this.http.get<Worker[]>(`api/Workers`);
  }
}
