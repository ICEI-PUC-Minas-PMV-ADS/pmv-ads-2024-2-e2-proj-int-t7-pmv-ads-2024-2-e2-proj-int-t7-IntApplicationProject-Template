import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ContatoService {
  private apiUrl = 'http://localhost:5190/api/contato'; // URL da sua API

  constructor(private http: HttpClient) {}

  enviarContato(contato: any): Observable<any> {
    return this.http.post(this.apiUrl, contato);
  }
}
