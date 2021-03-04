import {AfterViewInit, Component, Input, OnChanges, OnInit, SimpleChanges, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatTable, MatTableDataSource} from '@angular/material/table';
import {Room} from '../../../models/room';
import {MatSort} from '@angular/material/sort';

@Component({
  selector: 'app-rooms-table',
  templateUrl: './rooms-table.component.html',
  styleUrls: ['./rooms-table.component.css']
})
export class RoomsTableComponent implements AfterViewInit, OnChanges {

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatTable) table!: MatTable<Room>;
  @ViewChild(MatSort) sort!: MatSort;

  @Input() roomsTableData!: Room[];

  public displayedColumns: string[] = ['id', 'roomType', 'floor', 'phoneNumber', 'price'];
  public dataSource: MatTableDataSource<Room> = new MatTableDataSource<Room>();
  public filter = '';
  public isLoading = true;

  public ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (this.dataSource && this.table) {
      this.dataSource.data = this.roomsTableData;
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
