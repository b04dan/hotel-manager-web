import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';

import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatCardModule} from '@angular/material/card';
import {MatMenuModule} from '@angular/material/menu';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import {LayoutModule as CdkLayoutModule} from '@angular/cdk/layout';
import {DashboardModule} from './pages/dashboard/dashboard.module';
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';
import {LayoutModule} from './layout/layout.module';
import {API_URL, ApiUrlInterceptor} from './interceptors/api-url.interceptor';
import {environment} from '../environments/environment';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatGridListModule,
    MatCardModule,
    MatMenuModule,
    MatIconModule,
    MatButtonModule,
    LayoutModule,
    CdkLayoutModule,
    HttpClientModule,
    DashboardModule
  ],
  providers: [
    {provide: API_URL, useValue: environment.apiUrl},
    {provide: HTTP_INTERCEPTORS, useClass: ApiUrlInterceptor, multi: true, deps: [API_URL]}
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
