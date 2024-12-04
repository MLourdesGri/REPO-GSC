import { Routes } from '@angular/router';
import { MoviesComponent } from './movies/movies.component';
import { EjerciciosComponent } from './ejercicios/ejercicios.component';

export const routes: Routes = [
    { path: 'movies', component: MoviesComponent },
    { path: 'ejercicios', component: EjerciciosComponent },
    { path: '', redirectTo: '/movies', pathMatch: 'full' }, // Redirige al inicio
    { path: '**', redirectTo: '/movies' } 
];
