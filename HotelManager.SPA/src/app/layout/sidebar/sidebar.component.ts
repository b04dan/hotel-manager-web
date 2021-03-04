import {Component, OnInit} from '@angular/core';

enum routes {
  REPORTS = '/reports',
  DASHBOARD = '/dashboard',
  RESIDENCES = '/residences',
  CLIENTS = '/clients',
  WORKERS = '/workers',
  ROOMS = '/rooms',
  SCHEDULES = '/schedules',
  HOTEL = '/hotel',
  SETTINGS = '/settings',
  ABOUT = '/about'
}

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent {
  public routes = routes;
}

