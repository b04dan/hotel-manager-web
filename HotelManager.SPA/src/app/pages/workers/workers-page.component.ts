import { Component, OnInit } from '@angular/core';
import {Observable} from 'rxjs';
import {Worker} from '../../models/worker';
import {WorkersService} from '../../services/workers.service';

@Component({
  selector: 'app-workers-page',
  templateUrl: './workers-page.component.html',
  styleUrls: ['./workers-page.component.css']
})
export class WorkersPageComponent {
  public workers: Observable<Worker[]>;

  constructor(private service: WorkersService) {
    this.workers = service.getWorkers();
  }
}
