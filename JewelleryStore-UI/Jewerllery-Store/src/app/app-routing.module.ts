import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EstimationComponent } from './customer/estimation/estimation.component';
import { LoginComponent } from './customer/login/login.component';

const routes: Routes = [{path : '', component :LoginComponent}, {path : '', component : EstimationComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
