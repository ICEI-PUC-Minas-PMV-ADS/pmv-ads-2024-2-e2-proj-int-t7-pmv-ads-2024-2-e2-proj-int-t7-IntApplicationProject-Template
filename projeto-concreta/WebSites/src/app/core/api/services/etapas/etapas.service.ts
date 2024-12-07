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

  public putEtapaEscolhida(idEtapa: number, etapa: EtapasModel): Observable<EtapasModel> {
    const url = `EtapaModel/editar/${idEtapa}`; 
    return this.put<EtapasModel>(url, etapa);
  }
  
  deleteEtapaEscolhida(idEtapa: number): Observable<any> {
    const etapaExcluida = {
      idObra: idEtapa,
    };
    const url = `EtapaModel/excluir/${idEtapa}`;
    // Adicionar o corpo no objeto de opções
    const options = {
      body: etapaExcluida
    };
    
    return this.deleteAllBody(url, options);
  }


}
