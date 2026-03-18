import { Routes } from '@angular/router';
import { Home } from './Components/home/home';
import { About } from './Components/about/about';
import { Blog } from './Components/blog/blog';
import { Blogs } from './Components/blogs/blogs';

export const routes: Routes = [
    {path: '',component:Home},
    //{path:'**',redirectTo:'/'},
    {path:'about',component:About},
    {path: 'blog',component:Blog},
    {path:'blogs',component:Blogs}
];
