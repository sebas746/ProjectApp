import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { JwtInterceptor } from './_helpers/jwt.interceptor';
import { ErrorInterceptor } from './_helpers/error.interceptor';
import { CreatePolicyComponent } from './create-policy/create-policy.component';
import { PoliciesListComponent } from './policies-list/policies-list.component';
import { PolicyAssignComponent } from './policy-assign/policy-assign.component';
import { AssignPolicyComponent } from './assign-policy/assign-policy.component';
import {AutocompleteLibModule} from 'angular-ng-autocomplete';
import { NgMultiSelectDropDownModule } from 'ng-multiselect-dropdown-angular7';
import {FormsModule} from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    CreatePolicyComponent,
    PoliciesListComponent,
    PolicyAssignComponent,
    AssignPolicyComponent
  ],
  imports: [   
    NgMultiSelectDropDownModule.forRoot(), 
    AutocompleteLibModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
