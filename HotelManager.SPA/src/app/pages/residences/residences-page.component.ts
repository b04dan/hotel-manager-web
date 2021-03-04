import { Component } from '@angular/core';
import {Residence} from '../../models/residence';
import {Observable} from 'rxjs';
import {ResidencesService} from '../../services/residences.service';

@Component({
  selector: 'app-residences-page',
  templateUrl: './residences-page.component.html',
  styleUrls: ['./residences-page.component.css']
})
export class ResidencesPageComponent {
  public residences: Observable<Residence[]>;

  constructor(private service: ResidencesService) {
    this.residences = service.getResidences();
  }
}
