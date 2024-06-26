import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
@Component({
	selector: 'app-root',
	standalone: true,
	imports: [RouterOutlet],
	templateUrl: './app.component.html',
	styleUrl: './app.component.css'
  })
export class AppComponent {
  currentYear: number = new Date().getFullYear(); // Initialize in the declaration
	title: any;
}
