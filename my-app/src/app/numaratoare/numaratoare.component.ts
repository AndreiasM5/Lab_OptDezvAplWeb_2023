import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

// src/app/numaratoare/numaratoare.component.ts

@Component({
  selector: 'app-numaratoare',
  template: `
    <h2>Contor: {{ counter }}</h2>
    <button (click)="decrement()">Decrementare</button>
  `,
  styles: []
})
export class NumaratoareComponent {
  counter = 0;

  decrement() {
    this.counter--;
  }
}
