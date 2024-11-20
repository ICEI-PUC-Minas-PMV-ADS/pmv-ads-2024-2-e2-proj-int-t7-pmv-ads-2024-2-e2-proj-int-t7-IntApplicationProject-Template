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

  private apiUrl = 'ObraModel/em-andamento';

  private obraFinalizadaEndpoint = 'ObraModel/obra-finalizada';

  private obraEscolhidaEndpoint = 'ObraModel/obra-escolhida';


  constructor(httpClient: HttpClient) {
    super(httpClient)
  }

  public cadastrarObra(data: ObrasModel) {
    return this.post(`${this.rotabase}`, data);
  }

  // Método para pegar as obras em andamento
  public getObrasEmAndamento(): Observable<ObrasModel[]> {

    return this.get<ObrasModel[]>(this.apiUrl);
  }

  // Método para pegar as obras finalizadas
public getObraFinalizada(): Observable<ObrasModel[]> {
  return this.get<ObrasModel[]>(this.obraFinalizadaEndpoint);
}

public getObraEscolhida(id: number): Observable<ObrasModel> {
  const url = `${this.obraEscolhidaEndpoint}/${id}`; // Concatena o id à rota
  return this.get<ObrasModel>(url); // Faz a requisição GET
}

atualizarEstaConcluido(id: number, estaConcluido: boolean): Observable<any> {
  const obraAtualizada = {
    idObra: id,
    estaConcluido: estaConcluido
  };

  const url = `ObraModel/obra-escolhida/${id}`;
  return this.put<any>(url, obraAtualizada);
}



}
