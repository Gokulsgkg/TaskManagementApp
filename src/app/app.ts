import { Component, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet,RouterModule } from '@angular/router';
import { CommonModule, UpperCasePipe, TitleCasePipe } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    FormsModule,
    CommonModule,       // gives you *ngIf and *ngFor
    UpperCasePipe,      // enables | uppercase
    TitleCasePipe,       // enables | titlecase
    RouterModule         // enables routerLink and router-outlet
  ],
  templateUrl: './app.html',
  styleUrls: ['./app.css']
})
export class App {
  protected readonly title = signal('Techzines');

  email: string = '';
  status: string = '';
  subscribers: string[] = [];

  onSubmit(): void {
    this.status = `Confirmation mail has been sent to ${this.email} successfully`;
    this.subscribers.push(this.email);
    this.email = ''; // clear input after submit
  }
}
