import { Injectable } from '@angular/core';
import { BaseService } from '../base.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { EtapasModel } from '../../models/etapas/etapas.model';

@Injectable({
  providedIn: 'root'
})
export class EtapasService extends BaseService {

  private cadastrarEtapaEndpoint: string = 'EtapaModel/cadastrar';

  constructor(httpClient: HttpClient) {
    super(httpClient)
  }

  public cadastrarEtapa(data: EtapasModel) {
    return this.post(`${this.cadastrarEtapaEndpoint}`, data);
  }

  public getEtapaEscolhida(idObra: number): Observable<EtapasModel[]> {
    const url = `EtapaModel/obras/${idObra}/etapas`; // Concatena o id à rota
    return this.get<EtapasModel[]>(url); // Faz a requisição GET e espera uma lista
  }



}
