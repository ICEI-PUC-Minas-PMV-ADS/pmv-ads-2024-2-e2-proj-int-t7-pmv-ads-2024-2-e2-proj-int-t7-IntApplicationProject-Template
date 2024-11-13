import { Injectable } from '@angular/core';
import { BaseService } from '../base.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ContatosModel } from '../../models/contatos/contatos.model';
import { ObrasModel } from '../../models/obras/obras.models';

@Injectable({
  providedIn: 'root'
})
export class ObrasService extends BaseService {

  private rotabase: string = 'ObraModel/Cadastrar';


  constructor(httpClient: HttpClient) {
    super(httpClient)
  }
 
  public cadastrarObra(data: ObrasModel) {
    return this.post(`${this.rotabase}`, data);
  }

}
