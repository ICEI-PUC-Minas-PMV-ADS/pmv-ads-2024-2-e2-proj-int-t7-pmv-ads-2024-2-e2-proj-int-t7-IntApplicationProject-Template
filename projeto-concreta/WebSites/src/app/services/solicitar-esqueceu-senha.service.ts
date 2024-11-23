import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SolicitarEsqueceuSenhaService {
  private apiUrl = 'http://localhost:5190/api/usuario';

  constructor(private http: HttpClient) {}

  solicitarEsqueceuSenha(solicitarDto: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/solicitar-redefinicao-senha`, solicitarDto);
  }
}