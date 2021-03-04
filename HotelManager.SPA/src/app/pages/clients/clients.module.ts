import {NgModule} from '@angular/core';
import {ClientsPageComponent} from './clients-page.component';
import {ClientsTableComponent} from './clients-table/clients-table.component';
import {RouterModule, Routes} from '@angular/router';
import {MatDialogModule} from '@angular/material/dialog';
import {SharedModule} from '../../shared/shared.module';

const routes: Routes = [
  {
    path: '',
    component: ClientsPageComponent
  }
];


@NgModule({
  declarations: [ClientsPageComponent, ClientsTableComponent],
  imports: [
    RouterModule.forChild(routes),
    SharedModule,
    MatDialogModule
  ]
})
export class ClientsModule {
}
