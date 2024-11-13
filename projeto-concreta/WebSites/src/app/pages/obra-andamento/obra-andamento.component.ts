import { Component, OnInit } from '@angular/core';
import { ObrasService } from "../../core/api/services/obras/obras.service"; // Ajuste o caminho
import { ObrasModel } from '../../core/api/models/obras/obras.models'; // Ajuste o caminho

@Component({
  selector: 'app-obra-andamento',
  templateUrl: './obra-andamento.component.html',
  styleUrls: ['./obra-andamento.component.scss']
})
export class ObraAndamentoComponent implements OnInit {
  
  obrasEmAndamento: ObrasModel[] = [];

  constructor(private obrasService: ObrasService) {}

  ngOnInit(): void {
    // Chama o serviço para obter as obras em andamento
    this.obrasService.getObrasEmAndamento().subscribe(
      (dados: any) => {
        this.obrasEmAndamento = dados;
      },
      (error: any) => {
        console.error('Erro ao buscar obras em andamento', error);
      }
    );
  }
}







