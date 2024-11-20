import { Component } from '@angular/core';

@Component({
  selector: 'app-second-component',
  imports: [],
  templateUrl: './second-component.component.html',
  styleUrl: './second-component.component.css'
})
export class SecondComponentComponent {
  objeto = {
    propiedad1: 'Valor 1',
    propiedad2: 'Valor 2',
    propiedad3: 'Valor 3',
    propiedad4: 'Valor 4'
  };
}
