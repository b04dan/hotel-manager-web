import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Client} from '../models/client';

@Injectable({
  providedIn: 'root'
})
export class ClientsService {
  constructor(private http: HttpClient) {
  }

  getClients(): Observable<Client[]> {
    return this.http.get<Client[]>(`api/Clients`);
  }
}
