import { Component } from '@angular/core';
import { RouterModule, Router } from '@angular/router'

@Component({
    selector: 'login-form',
    templateUrl: './login.component.html'
})

export class LoginComponent
{
    user: Object = {};
    private _router: Router;
    login() {
        //if (this.user.email == "admin" && this.user.password == "admin") {
        //    console.log("Hello admin");
        //}
        //else {
        //    console.log("Who is this");
        //}
    }
}