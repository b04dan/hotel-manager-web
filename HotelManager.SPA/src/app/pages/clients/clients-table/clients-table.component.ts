import {AfterViewInit, Component, Input, OnChanges, OnInit, SimpleChanges, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatTable, MatTableDataSource} from '@angular/material/table';
import {MatSort} from '@angular/material/sort';
import {MatDialog} from '@angular/material/dialog';
import {Client} from '../../../models/client';

@Component({
  selector: 'app-clients-table',
  templateUrl: './clients-table.component.html',
  styleUrls: ['./clients-table.component.css']
})
export class ClientsTableComponent implements AfterViewInit, OnChanges {

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatTable) table!: MatTable<Client>;
  @ViewChild(MatSort) sort!: MatSort;

  @Input() clientsTableData!: Client[];

  public displayedColumns: string[] = [
    'id', 'surname', 'name', 'patronymic', 'passportNumber',
    'email', 'phoneNumber', 'city', 'control'
  ];
  public dataSource: MatTableDataSource<Client> = new MatTableDataSource<Client>();
  public filter = '';
  public isLoading = true;

  constructor(public dialog: MatDialog) {
  }

  public ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (this.dataSource && this.table) {
      this.dataSource.data = this.clientsTableData;
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
