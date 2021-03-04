import {Component} from '@angular/core';
import {Observable} from 'rxjs';
import {Client} from '../../models/client';
import {ClientsService} from '../../services/clients.service';

@Component({
  selector: 'app-clients-page',
  templateUrl: './clients-page.component.html',
  styleUrls: ['./clients-page.component.css']
})
export class ClientsPageComponent {
  public clients: Observable<Client[]>;

  constructor(private service: ClientsService) {
    this.clients = service.getClients();
  }
}
