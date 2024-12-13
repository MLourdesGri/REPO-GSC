import { NgFor, NgIf } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { MovieItemComponent } from '../movie-item/movie-item.component';
import { MovieService } from '../services/movie.service';
import { Movie } from '../models/movie';

/* export interface Movie {
  title: string;
  year: number;
  description: string;
  image?: string;
}  */

@Component({
  selector: 'app-movie-list',
  standalone: true,
  imports: [NgIf, NgFor,MovieItemComponent],
  templateUrl: './movie-list.component.html',
  styleUrl: './movie-list.component.css'
 
})


export class MovieListComponent implements OnInit{
  /* movies: Movie[] = [
    {
      title: 'Inception', 
      year: 2010, 
      description: 'Un thriller alucinante.',
      image: "https://upload.wikimedia.org/wikipedia/en/2/2e/Inception_%282010%29_theatrical_poster.jpg"
    },

    {
      title: 'The Matrix', 
      year: 1999, 
      description: 'Un hacker descubre que la realidad es una simulación.',
      image: "https://pics.filmaffinity.com/the_matrix-155050517-large.jpg"
    },

    {
      title: 'Interstellar', 
      year: 2014, 
      description: 'Un viaje a los confines del espacio.',
      image: "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEiRdlal-DyX1hbPmmSWSRl6Gv8Ev0v8Ugk71D-TakxV3KPFwrojG05f4jLsgL1tcb1QgwXha9hzCPp73wvAzHJ7ZbQ6PWCuTzQHmXTVz6XDNmSlLi7hNjYxH_BcOMY1sma-nW5oIS-HZsB1/s800/interstellar-imax-movie-poster.jpg"
    },

    {
      title: 'The Dark Knight', 
      year: 2010, 
      description: 'Un thriller alucinante.',
      image: "https://pics.filmaffinity.com/the_dark_knight-102763119-mmed.jpg"
    }
  ] */

  movies: Movie[] = [];
  selectedMovie: string = ''

  constructor(private movieService: MovieService){}

   onMovieSelected(movieTitle: string): void{
    this.selectedMovie = movieTitle
} 

  ngOnInit(): void {
    this.movies = this.movieService.getMovies();
  }

}



