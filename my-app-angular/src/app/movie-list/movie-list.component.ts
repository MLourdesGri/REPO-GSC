import { Component } from '@angular/core';
import { MovieItemComponent } from "../movie-item/movie-item.component";
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css'],
  imports: [CommonModule, MovieItemComponent]
})
export class MovieListComponent {
  movies = [
    { title: 'Inception', year: 2010, description: 'A thief who enters dreams to steal secrets.' },
    { title: 'The Matrix', year: 1999, description: 'A hacker discovers a dystopian reality.' },
    { title: 'Interstellar', year: 2014, description: 'Astronauts explore a wormhole to save humanity.' },
    { title: 'The Dark Knight', year: 2008, description: 'Batman fights the Joker in Gotham City.' }
  ];
  selectedMovie: string | null = null;

  onMovieSelected(movieTitle: string): void {
    this.selectedMovie = movieTitle;
  }
}
