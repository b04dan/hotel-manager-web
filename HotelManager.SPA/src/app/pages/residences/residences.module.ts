import {NgModule} from '@angular/core';
import {ResidencesTableComponent} from './residences-table/residences-table.component';
import {ResidencesPageComponent} from './residences-page.component';
import {RouterModule, Routes} from '@angular/router';
import {PipesModule} from '../../pipes/pipes.module';
import {SharedModule} from '../../shared/shared.module';


const routes: Routes = [
  {
    path: '',
    component: ResidencesPageComponent
  }
];

@NgModule({
  declarations: [ResidencesPageComponent, ResidencesTableComponent],
  imports: [
    SharedModule,
    PipesModule,
    RouterModule.forChild(routes),
  ]
})
export class ResidencesModule {
}
