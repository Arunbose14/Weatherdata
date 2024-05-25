import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class WeatherService {
  private apiUrl = 'https://localhost:44357/api/weather';

  constructor(private http: HttpClient) {}

  getCurrentWeather(location: string): Observable<any> {
    return this.http.get(`${this.apiUrl}/${location}`);
  }

  getWeatherHistory(location: string, from: string, to: string): Observable<any> {
    return this.http.get(`${this.apiUrl}/history`, { params: { location, from, to } });
  }
}


