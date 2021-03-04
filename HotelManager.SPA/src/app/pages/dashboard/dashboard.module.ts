import {NgModule} from '@angular/core';
import {DashboardPageComponent} from './dashboard-page.component';
import { CheckInOutStatisticsComponent } from './check-in-out-statistics/check-in-out-statistics.component';
import {NgxChartsModule} from '@swimlane/ngx-charts';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { NumbersStatisticsComponent } from './numbers-statistics/numbers-statistics.component';
import { OccupancyStatisticsComponent } from './occupancy-statistics/occupancy-statistics.component';
import {MatGridListModule} from '@angular/material/grid-list';
import {SharedModule} from '../../shared/shared.module';



@NgModule({
  declarations: [DashboardPageComponent, CheckInOutStatisticsComponent, NumbersStatisticsComponent, OccupancyStatisticsComponent],
  imports: [
    SharedModule,
    NgxChartsModule,
    BrowserAnimationsModule,
    MatGridListModule
  ]
})
export class DashboardModule {
}
