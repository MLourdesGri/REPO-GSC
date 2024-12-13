import { Component, OnInit } from '@angular/core';
import { SeriesService } from '../services/series.service';
import { NgFor, NgIf } from '@angular/common';
import { Episode } from '../models/episode';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-series',
  standalone: true,
  imports: [NgIf,NgFor,FormsModule],
  templateUrl: './series.component.html',
  styleUrl: './series.component.css'
})
export class SeriesComponent implements OnInit{
  episodes: Episode[] = [] // Aquí guardaremos los episodios obtenidos
  seriesTitle: string = 'Lost'
  season: number = 1
  totalSeasons!: number;
  errorMessage: string = ''

  constructor(private seriesService: SeriesService){}

  ngOnInit(): void {
    this.loadEpisodes();
  }

  loadEpisodes(): void {
    this.seriesService.getEpisodes(this.seriesTitle, this.season).subscribe({
      next: (response) => {
        if (response.Response === 'True') {
          this.totalSeasons = Number(response.totalSeasons); 
          this.episodes = response.Episodes; 
          this.errorMessage = '';
        } else {
          this.showError(`La serie "${this.seriesTitle}" no existe.`);
        }
      },
      error: (error) => {
        this.showError('Error al conectar con el servicio. Intente nuevamente.');
      },
      complete: () => {
        console.log('Se terminó de cargar la información de los episodios.');
      }
    });    
  }

  onSeasonChange(): void{
    this.loadEpisodes();
  }

  onSeriesTitleChange(): void {
    this.season = 1; 
    this.loadEpisodes();
  }

  private showError(message: string): void {
    this.errorMessage = message;
    this.episodes = [];
    this.totalSeasons = 1; 
  }
}