import {Component, Input, OnInit} from '@angular/core';

@Component({
  selector: 'app-numbers-statistics',
  templateUrl: './numbers-statistics.component.html',
  styleUrls: ['./numbers-statistics.component.css']
})
export class NumbersStatisticsComponent  {
  @Input() data: any;
  cardColor = '#f6f7ff';
}
