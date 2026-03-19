import { Component,inject } from '@angular/core';
import { BlogServices } from '../../blogService';
import {MatButtonModule} from '@angular/material/button';
import {MatCardModule} from '@angular/material/card';
import { Blog } from '../Model/Blog';
@Component({
  selector: 'app-home',
  imports: [MatCardModule, MatButtonModule],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {
  blogServices= inject(BlogServices);
  featuredBlog!:Blog[];
  ngOnInit(){
    this.blogServices.getFeaturedBlogs().subscribe((data)=>{
      this.featuredBlog=data;
      console.log(this.featuredBlog);
    },
    (error)=>{
       console.log(error);
    }
    );
  }
}

