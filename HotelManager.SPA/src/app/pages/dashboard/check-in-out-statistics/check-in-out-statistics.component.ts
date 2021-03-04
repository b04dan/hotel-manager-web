import {AfterViewInit, Component, Input, OnChanges, OnInit, SimpleChanges} from '@angular/core';
import {CheckInOutStatistics} from '../../../models/statistics/checkInOut';

@Component({
  selector: 'app-check-in-out-statistics',
  templateUrl: './check-in-out-statistics.component.html',
  styleUrls: ['./check-in-out-statistics.component.css']
})
export class CheckInOutStatisticsComponent {

  @Input() data!: CheckInOutStatistics[];

  // настройки
  legend = true;
  animations = true;
  xAxis = true;
  yAxis = true;
  showYAxisLabel = false;
  showXAxisLabel = false;
  xAxisLabel = 'Дни';
  yAxisLabel = 'Кол-во';
  timeline = true;
  legendTitle = 'Легенда';

  dateTickFormatting(value: any): string {
      return new Date(value).toLocaleDateString('ru-UA');
  }
}
