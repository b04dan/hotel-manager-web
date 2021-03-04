import {AfterViewInit, Component, Input, OnChanges, OnInit, SimpleChanges, ViewChild} from '@angular/core';
import {Residence} from '../../../models/residence';
import {MatTable, MatTableDataSource} from '@angular/material/table';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';

@Component({
  selector: 'app-residences-table',
  templateUrl: './residences-table.component.html',
  styleUrls: ['./residences-table.component.css']
})
export class ResidencesTableComponent implements AfterViewInit, OnChanges {

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatTable) table!: MatTable<Residence>;
  @ViewChild(MatSort) sort!: MatSort;

  @Input() residencesTableData!: Residence[];

  public displayedColumns: string[] = ['id', 'hotelRoomId', 'clientSNP', 'checkInDate', 'checkOutDate', 'control'];
  public dataSource: MatTableDataSource<Residence> = new MatTableDataSource<Residence>();
  public filter = '';
  public isLoading = true;

  public ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (this.dataSource && this.table) {
      this.dataSource.data = this.residencesTableData;
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
