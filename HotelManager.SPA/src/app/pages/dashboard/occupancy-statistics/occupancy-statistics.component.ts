import {Component, Input, OnInit} from '@angular/core';

@Component({
  selector: 'app-occupancy-statistics',
  templateUrl: './occupancy-statistics.component.html',
  styleUrls: ['./occupancy-statistics.component.css']
})
export class OccupancyStatisticsComponent {
  @Input() data: any;

  // настройки
  showLegend = true;
  showLabels = false;
  legendTitle = 'Легенда';
}
