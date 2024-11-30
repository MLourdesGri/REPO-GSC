import { CommonModule } from '@angular/common';
import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-movie-item',
  templateUrl: './movie-item.component.html',
  styleUrls: ['./movie-item.component.css'],
  imports: [CommonModule]
})
export class MovieItemComponent {
  @Input() movie!: { title: string; year: number; description: string };
  @Output() movieSelected = new EventEmitter<string>();

  selectMovie(): void {
    this.movieSelected.emit(this.movie.title);
  }
}
