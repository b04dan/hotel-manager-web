import {AfterViewInit, Component, Input, OnChanges, OnInit, SimpleChanges, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatTable, MatTableDataSource} from '@angular/material/table';
import {Worker} from '../../../models/worker';
import {MatSort} from '@angular/material/sort';
import {MatDialog} from '@angular/material/dialog';
import {ScheduleDialogComponent} from '../schedule-dialog/schedule-dialog.component';
import {SchedulesService} from '../../../services/schedules.service';

@Component({
  selector: 'app-workers-table',
  templateUrl: './workers-table.component.html',
  styleUrls: ['./workers-table.component.css']
})
export class WorkersTableComponent implements AfterViewInit, OnChanges {

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatTable) table!: MatTable<Worker>;
  @ViewChild(MatSort) sort!: MatSort;

  @Input() workersTableData!: Worker[];

  public displayedColumns: string[] = [
    'id', 'surname', 'name', 'patronymic', 'passportNumber', 'email',
    'phoneNumber', 'workDaysCount', 'workdaySalary', 'working', 'control'
  ];
  public dataSource: MatTableDataSource<Worker> = new MatTableDataSource<Worker>();
  public filter = '';
  public isLoading = true;

  constructor(public dialog: MatDialog, public schedulesService: SchedulesService) {
  }

  openScheduleDialog(worker: Worker): void {
    this.schedulesService.getById(worker.weeklyScheduleId)
      .subscribe(schedule => {
        this.dialog.open(ScheduleDialogComponent, {
          data: {
            worker,
            schedule
          }
        });
      });
  }

  public ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (this.dataSource && this.table) {
      this.dataSource.data = this.workersTableData;
      this.isLoading = false;
      this.table.renderRows();
    }
  }

  public applyFilter(): void {
    this.dataSource.filter = this.filter.trim().toLowerCase();
  }

  public removeFilter(): void {
    this.dataSource.filter = this.filter = '';
  }
}
