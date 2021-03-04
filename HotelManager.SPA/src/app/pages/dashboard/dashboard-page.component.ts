import { Component } from '@angular/core';
import { map } from 'rxjs/operators';
import { Breakpoints, BreakpointObserver } from '@angular/cdk/layout';
import {StatisticsService} from '../../services/statistics.service';
import {Observable} from 'rxjs';
import {CheckInOutStatistics} from '../../models/statistics/checkInOut';

@Component({
  selector: 'app-dashboard-page',
  templateUrl: './dashboard-page.component.html',
  styleUrls: ['./dashboard-page.component.css']
})
export class DashboardPageComponent {

  public checkInOutStatistics: Observable<CheckInOutStatistics[]>;
  public numbersStatistics: Observable<any>;
  public occupancyStatistics: Observable<any>;

  constructor(private breakpointObserver: BreakpointObserver, public statisticsService: StatisticsService) {
    this.checkInOutStatistics = statisticsService.getCheckInOutStatistics(7);
    this.occupancyStatistics = statisticsService.getOccupancyStatistics();
    this.numbersStatistics = statisticsService.getNumbersStatistics();
  }



  public cards = this.breakpointObserver.observe(Breakpoints.Handset).pipe(
    map(({ matches }) => {
      if (matches) {
        return [
          { title: 'Диаграмма 1', cols: 1, rows: 1 },
          { title: 'Диаграмма 2', cols: 1, rows: 1 },
          { title: 'Диаграмма 3', cols: 1, rows: 1 },
          { title: 'Диаграмма 4', cols: 1, rows: 1 }
        ];
      }

      return [
        { title: 'Диаграмма 1', cols: 2, rows: 1 },
        { title: 'Диаграмма 2', cols: 1, rows: 1 },
        { title: 'Диаграмма 3', cols: 1, rows: 2 },
        { title: 'Диаграмма 4', cols: 1, rows: 1 }
      ];
    })
  );

}
