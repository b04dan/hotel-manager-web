import { NgModule } from '@angular/core';
import { RoomsPageComponent } from './rooms-page.component';
import { RoomsTableComponent } from './rooms-table/rooms-table.component';
import {RouterModule, Routes} from '@angular/router';
import {SharedModule} from '../../shared/shared.module';


const routes: Routes = [
  {
    path: '',
    component: RoomsPageComponent
  }
];


@NgModule({
  declarations: [RoomsPageComponent, RoomsTableComponent],
  imports: [
    SharedModule,
    RouterModule.forChild(routes)
  ]
})
export class RoomsModule { }
