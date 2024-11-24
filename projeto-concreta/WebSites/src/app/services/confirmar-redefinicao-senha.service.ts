import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ConfirmarRedefinicaoSenhaDTO } from '../dto/confirmar-redefinicao-senha.dto';

@Injectable({
  providedIn: 'root'
})
export class ConfirmarRedefinicaoSenhaService {
  private apiUrl = 'http://localhost:5190/api/usuario';

  constructor(private http: HttpClient) {}

  confirmarRedefinicaoSenha(confirmarDto: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/confirmar-redefinicao-senha`, confirmarDto);
  }
}
