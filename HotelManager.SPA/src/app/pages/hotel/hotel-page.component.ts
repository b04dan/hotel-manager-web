import {Component, OnInit} from '@angular/core';
import {HotelService} from '../../services/hotel.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-hotel-page',
  templateUrl: './hotel-page.component.html',
  styleUrls: ['./hotel-page.component.css']
})
export class HotelPageComponent {

  constructor(private hotelService: HotelService, private router: Router) {
  }

  public generateTestData(): void {
    this.hotelService.initializeTestData()
      .subscribe(r => this.router.navigate(['/dashboard']));
  }
}
