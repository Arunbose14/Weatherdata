import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WeatherdataComponent } from './weatherdata/weatherdata.component';


const routes: Routes = [
  {
  path:'',component:WeatherdataComponent,
  },
  // {path:'menu',component:WeatherhistoryComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
