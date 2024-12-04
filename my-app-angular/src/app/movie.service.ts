import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private movies = [
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
  ] 

  getMovies(){
    return this.movies
  }
}