import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {DashboardPageComponent} from './pages/dashboard/dashboard-page.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: 'dashboard',
  },
  {
    path: 'dashboard',
    pathMatch: 'full',
    component: DashboardPageComponent
  },
  {
    path: 'residences',
    pathMatch: 'full',
    loadChildren: () => import('./pages/residences/residences.module').then(m => m.ResidencesModule)
  },
  {
    path: 'clients',
    pathMatch: 'full',
    loadChildren: () => import('./pages/clients/clients.module').then(m => m.ClientsModule)
  },
  {
    path: 'workers',
    pathMatch: 'full',
    loadChildren: () => import('./pages/workers/workers.module').then(m => m.WorkersModule)
  },
  {
    path: 'rooms',
    pathMatch: 'full',
    loadChildren: () => import('./pages/rooms/rooms.module').then(m => m.RoomsModule)
  },
  {
    path: 'schedules',
    pathMatch: 'full',
    loadChildren: () => import('./pages/schedules/schedules.module').then(m => m.SchedulesModule)
  },
  {
    path: 'settings',
    pathMatch: 'full',
    loadChildren: () => import('./pages/settings/settings.module').then(m => m.SettingsModule)
  },
  {
    path: 'about',
    pathMatch: 'full',
    loadChildren: () => import('./pages/about/about.module').then(m => m.AboutModule)
  },
  {
    path: 'hotel',
    pathMatch: 'full',
    loadChildren: () => import('./pages/hotel/hotel.module').then(m => m.HotelModule)
  },
  {
    path: 'reports',
    pathMatch: 'full',
    loadChildren: () => import('./pages/reports/reports.module').then(m => m.ReportsModule)
  },
  {
    path: '**',
    redirectTo: 'dashboard',
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
