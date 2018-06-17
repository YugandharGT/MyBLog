import { NgModule } from '@angular/core';
import { Blog } from './blog';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    { path: '/About', component: Blog }
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    exports: [

    ]
})

export class BlogRoutingModule {

}


