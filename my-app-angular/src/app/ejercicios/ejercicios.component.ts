import { Component } from '@angular/core';
import { FirstComponentComponent } from "../first_component/first-component.component";
import { ThirdComponentComponent } from "../third-component/third-component.component";
import { SecondComponentComponent } from '../second-component/second-component.component';

@Component({
  selector: 'app-ejercicios',
  imports: [FirstComponentComponent, ThirdComponentComponent, SecondComponentComponent],
  templateUrl: './ejercicios.component.html',
  styleUrl: './ejercicios.component.css'
})
export class EjerciciosComponent {

}
