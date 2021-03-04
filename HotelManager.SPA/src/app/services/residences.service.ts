import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Residence} from '../models/residence';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ResidencesService {
  constructor(private http: HttpClient) {
  }

  getResidences(): Observable<Residence[]> {
    return this.http.get<Residence[]>(`api/Residences`);
  }
}
