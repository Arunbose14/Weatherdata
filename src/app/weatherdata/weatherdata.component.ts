import { Component, OnInit } from '@angular/core';
import { WeatherService } from '../weather.service';
import { HttpClient } from '@angular/common/http';



@Component({
  selector: 'app-weatherdata',
  templateUrl: './weatherdata.component.html',
  styleUrls: ['./weatherdata.component.css']
})
export class WeatherdataComponent implements OnInit {

  currentWeather: any;
  weatherHistory: any;
  location!: string;
  from!: string;
  to!: string;

  constructor(private weatherService: WeatherService) {
    
  }
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  getCurrentWeather() {
    this.weatherService.getCurrentWeather(this.location).subscribe(data => {
      this.currentWeather = data;
    });
  }

  getWeatherHistory() {
    debugger
    this.weatherService.getWeatherHistory(this.location, this.from, this.to).subscribe(data => {
      this.weatherHistory = data;
    });
  }

}


