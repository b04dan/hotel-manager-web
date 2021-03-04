import {Inject, Injectable, InjectionToken} from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';

export const API_URL = new InjectionToken<string>('apiUrl');

@Injectable()
export class ApiUrlInterceptor implements HttpInterceptor {

  constructor(@Inject(API_URL) private apiUrl: string) {}

  private static isAbsoluteUrl(url: string): boolean {
    const absolutePattern = /^https?:\/\//i;
    return absolutePattern.test(url);
  }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    req = req.clone({url: this.prepareUrl(req.url)});
    return next.handle(req);
  }

  private prepareUrl(url: string): string {
    url = ApiUrlInterceptor.isAbsoluteUrl(url) ? url : this.apiUrl + '/' + url;
    return url.replace(/([^:]\/)\/+/g, '$1');
  }
}
