import { Component } from '@angular/core';
import { MovieItemComponent } from "../movie-item/movie-item.component";
import { MovieListComponent } from "../movie-list/movie-list.component";
import { NgIf } from '@angular/common';
import { MovieService } from '../services/movie.service';
import { SearchBarComponent } from "../search-bar/search-bar.component";

@Component({
  selector: 'app-movies',
  imports: [MovieListComponent, SearchBarComponent],
  templateUrl: './movies.component.html',
  styleUrl: './movies.component.css',
  standalone: true
})
export class MoviesComponent {

}
