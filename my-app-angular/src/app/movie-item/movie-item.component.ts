import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Movie } from '../movie';
import { NgIf } from '@angular/common';


@Component({
  selector: 'app-movie-item',
  standalone: true,
  imports: [NgIf],
  templateUrl: './movie-item.component.html',
  styleUrl: './movie-item.component.css'
})
export class MovieItemComponent {
  @Input() movie!: Movie;
  @Output() movieSelected = new EventEmitter<string>();

  selectMovie(): void{
    this.movieSelected.emit(this.movie.title)
  }
}
