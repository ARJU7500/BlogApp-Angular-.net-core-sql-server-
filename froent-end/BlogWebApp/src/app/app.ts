import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {MatButtonModule} from '@angular/material/button';
import { Header } from './Components/header/header';
import { Footer } from './Components/footer/footer';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet,MatButtonModule,Header,Footer],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('BlogWebApp');
}
