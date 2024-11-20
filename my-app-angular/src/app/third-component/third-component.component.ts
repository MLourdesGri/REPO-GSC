import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-third-component',
  imports: [CommonModule],
  templateUrl: './third-component.component.html',
  styleUrl: './third-component.component.css'
})
export class ThirdComponentComponent {
  items = [
    { propiedad1: 'Valor 1A', propiedad2: 'Valor 1B', propiedad3: 'Valor 1C', propiedad4: 'Valor 1D' },
    { propiedad1: 'Valor 2A', propiedad2: 'Valor 2B', propiedad3: 'Valor 2C', propiedad4: 'Valor 2D' },
    { propiedad1: 'Valor 3A', propiedad2: 'Valor 3B', propiedad3: 'Valor 3C', propiedad4: 'Valor 3D' },
    { propiedad1: 'Valor 4A', propiedad2: 'Valor 4B', propiedad3: 'Valor 4C', propiedad4: 'Valor 4D' },
  ];
}
