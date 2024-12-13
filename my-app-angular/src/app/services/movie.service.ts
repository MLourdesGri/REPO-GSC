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
    },
    {
      title: 'Pulp Fiction', 
      year: 1994, 
      description: 'Historias entrelazadas del bajo mundo de Los Ángeles.',
      image: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSkEzIee3yNksWWDkmoPeAokwKgp3x1ifJNfA&s"
    },
    {
      title: 'Forrest Gump', 
      year: 1994, 
      description: 'La vida de un hombre extraordinario contada a través de eventos históricos.',
      image: "https://upload.wikimedia.org/wikipedia/en/6/67/Forrest_Gump_poster.jpg"
    },
    {
      title: 'The Godfather', 
      year: 1972, 
      description: 'La historia de una poderosa familia mafiosa.',
      image: "https://upload.wikimedia.org/wikipedia/en/1/1c/Godfather_ver1.jpg"
    },
    {
      title: 'Fight Club', 
      year: 1999, 
      description: 'Un hombre encuentra una forma de liberarse del capitalismo.',
      image: "https://upload.wikimedia.org/wikipedia/en/f/fc/Fight_Club_poster.jpg"
    },
    {
      title: 'Avatar', 
      year: 2009, 
      description: 'Un ex-marine se aventura a un mundo alienígena.',
      image: "https://play-lh.googleusercontent.com/2RKyd1W-d1ZV6aEPri7I6bd4Ss-0QcgYb9NgaJDDUeJM3BX9g_wHRiFyiPl2EvJvVh-KrA"
    }
  ];

  getMovies(){
    return this.movies;
  }
}
