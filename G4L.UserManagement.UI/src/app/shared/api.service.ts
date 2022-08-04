import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  baseUri = environment.apiUrl;

  constructor(private httpClient: HttpClient) { }

  get(path: string): Observable<any> {
    return this.httpClient.get(`${this.baseUri}/${path}`)
  }

  post(path: string, body: any): Observable<any> {
    return this.httpClient.post(`${this.baseUri}/${path}`, body);
  }

}
