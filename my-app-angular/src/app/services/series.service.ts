import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ApiResponse } from '../models/apiresponse';

@Injectable({
  providedIn: 'root'
})
export class SeriesService {
  private apiKey = '2ff6c6e4'
  private baseUrl = 'https://www.omdbapi.com/'
  
  constructor(private http: HttpClient) { }

  // Método para obtener episodios de una serie específica
  getEpisodes(seriesTitle: string, season: number): Observable<ApiResponse>{
    const url = `${this.baseUrl}?apikey=${this.apiKey}&t=${seriesTitle}&Season=${season}`
    return this.http.get<ApiResponse>(url)
  }
}