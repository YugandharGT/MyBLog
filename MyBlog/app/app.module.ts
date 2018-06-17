import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
// import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
// import { AppNavbar } from './Components/app.navbar';


// import { CollapseModule, BsDropdownModule } from 'ngx-bootstrap';
// const appRoutes: Routes = [
//    { path: '', redirectTo: '/blog', pathMatch: 'full' }
// ];

/*, RouterModule.forRoot(appRoutes)*/
 @NgModule({
     imports: [BrowserModule, FormsModule],
     declarations: [AppComponent],
     bootstrap: [AppComponent]
})
export class AppModule { }
