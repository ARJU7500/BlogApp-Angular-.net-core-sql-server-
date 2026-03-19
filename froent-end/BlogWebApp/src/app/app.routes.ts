import { Routes } from '@angular/router';
import { Home } from './Components/home/home';
import { About } from './Components/about/about';
import { Blog } from './Components/blog/blog';
import { Blogs } from './Components/blogs/blogs';
import { Contact } from './Components/contact/contact';
import { Help } from './Components/help/help';

export const routes: Routes = [
    {path: '',component:Home},
    // {path:'**',redirectTo:'/'},
    {path:'about',component:About},
    {path: 'blog',component:Blog},
    {path:'blogs',component:Blogs},
    {path:'contact',component:Contact},
    {path:'help',component:Help}
];
