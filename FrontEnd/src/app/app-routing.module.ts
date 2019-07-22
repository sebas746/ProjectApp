import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './_guards/auth.guard';
import { CreatePolicyComponent } from './create-policy/create-policy.component';
import { PoliciesListComponent } from './policies-list/policies-list.component';


const routes: Routes = [
  { path: '', component: PoliciesListComponent, canActivate: [AuthGuard]},
  { path: 'createPolicy', component: CreatePolicyComponent },
  { path: 'login', component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
