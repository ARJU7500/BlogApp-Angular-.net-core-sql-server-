import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Blog } from './Components/Model/Blog';

@Injectable({
  providedIn: 'root',
})
export class BlogServices {
  http = inject(HttpClient);
  constructor() {}
  getFeaturedBlogs() {
    return this.http.get<Blog[]>('https://localhost:7014/api/BlogMaster/featured');
  }
}
