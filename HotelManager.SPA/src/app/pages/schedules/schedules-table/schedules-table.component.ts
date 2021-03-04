import {AfterViewInit, Component, Input, OnChanges, OnInit, SimpleChanges, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatTable, MatTableDataSource} from '@angular/material/table';
import {Schedule} from '../../../models/schedule';
import {MatSort} from '@angular/material/sort';

@Component({
  selector: 'app-schedules-table',
  templateUrl: './schedules-table.component.html',
  styleUrls: ['./schedules-table.component.css']
})
export class SchedulesTableComponent implements AfterViewInit, OnChanges {

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatTable) table!: MatTable<Schedule>;
  @ViewChild(MatSort) sort!: MatSort;

  @Input() schedulesTableData!: Schedule[];

  public displayedColumns: string[] = ['id', 'monday', 'tuesday', 'wednesday', 'thursday', 'friday', 'saturday', 'sunday'];
  public dataSource: MatTableDataSource<Schedule> = new MatTableDataSource<Schedule>();
  public filter = '';
  public isLoading = true;

  public ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (this.dataSource && this.table) {
      this.dataSource.data = this.schedulesTableData;
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
