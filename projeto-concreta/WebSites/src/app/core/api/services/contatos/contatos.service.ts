import { Injectable } from '@angular/core';
import { BaseService } from '../base.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ContatosModel } from '../../models/contatos/contatos.model';

@Injectable({
  providedIn: 'root'
})
export class ContatosService extends BaseService {

  private rotabase: string = 'Contato';


  constructor(httpClient: HttpClient) {
    super(httpClient)
  }
 
  public enviarContato(data: ContatosModel) {
    return this.post(`${this.rotabase}`, data);
  }

}
