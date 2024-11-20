import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-first-component',
  imports: [CommonModule],
  standalone: true,
  templateUrl: './first-component.component.html',
  styleUrl: './first-component.component.css'
})
export class FirstComponentComponent {
  mensaje1: string='Este es el primer mensaje';
  mensaje2: string='Este es el segundo mensaje';
  var_boolean: boolean = false;

}
