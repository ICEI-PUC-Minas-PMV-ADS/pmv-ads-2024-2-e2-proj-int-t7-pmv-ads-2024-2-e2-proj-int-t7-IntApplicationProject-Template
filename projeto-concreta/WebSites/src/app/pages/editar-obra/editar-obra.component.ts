import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ObrasService } from "../../core/api/services/obras/obras.service"; // Ajuste o caminho
import { ObrasModel } from '../../core/api/models/obras/obras.models'; // Ajuste o caminho
import { Router } from '@angular/router';
import { EtapasModel } from '../../core/api/models/etapas/etapas.model';
import { jsPDF } from 'jspdf'; // Biblioteca para gerar PDFs
import autoTable from 'jspdf-autotable'; // Plugin opcional para tabelas no PDF
import { EtapasService } from '../../core/api/services/etapas/etapas.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-editar-obra',
  templateUrl: './editar-obra.component.html',
  styleUrl: './editar-obra.component.scss'
})
export class EditarObraComponent {
  idObra: number | null = null;
  obra: ObrasModel | null = null;
  etapasRelatorio: EtapasModel[] = []; // Inicialize como um array vazio
  etapa: EtapasModel | null = null;
  etapas: EtapasModel[] = [];

  constructor(private route: ActivatedRoute,
    private obrasService: ObrasService,
    private router: Router,
    private etapasService: EtapasService,
    private location: Location
  ) {}


  ngOnInit(): void {
    this.idObra = +this.route.snapshot.paramMap.get('id')!; // Captura o parâmetro 'id'
    this.carregarEtapaEscolhida(this.idObra);
  }

  carregarEtapaEscolhida(idObra: number): void {
    console.log("entrei no método")
    this.etapasService.getEtapaEscolhida(idObra).subscribe({
      next: (data) => {
        this.etapas = data;
        this.etapasRelatorio = [];
        data.forEach((dado, index) => {
          this.etapa = dado;
          this.etapasRelatorio.push(dado);
        })
      },
      error: (error) => {
        console.error('Erro ao carregar etapa:', error);
      }
    });
  }

  getStatus(dataConclusao: string | Date): string {
    const hoje = new Date();
    const data = new Date(dataConclusao);
  
    if (hoje > data) {
      return 'Finalizado';
    } else if (hoje.toDateString() === data.toDateString()) {
      return 'Em Andamento';
    } else if (hoje < data) {
      return 'Aguardando Início';
    }
  
    return '';
  }

  salvarEtapa(index: number, isFinalizado: boolean): void {
    const etapaEditada = this.etapas[index];
    // etapaEditada.dataConclusao = new Date(Date.now());
    console.log("editar etapa " + etapaEditada.dataConclusao)
    console.log("editar etapa " + etapaEditada.descricao)
    console.log("editar etapa " + etapaEditada.idEtapa)
    console.log("editar etapa " + etapaEditada.idObra)
    console.log("editar etapa " + etapaEditada.nomeEtapa)

    if (isFinalizado) etapaEditada.dataConclusao = new Date(Date.now());

    // Envia os dados da etapa editada para a API usando o método PUT
    this.etapasService.putEtapaEscolhida(etapaEditada.idEtapa, etapaEditada).subscribe({
      next: () => {
        window.location.reload()
        console.log(`Etapa ${index + 1} atualizada com sucesso!`);
      },
      error: (error) => {
        console.error(`Erro ao atualizar a Etapa ${index + 1}:`, error);
      }
    });
  }

  deleteEtapa(index: number): void {
    const etapaEditada = this.etapas[index];
    console.log("editar etapa " + etapaEditada.dataConclusao)
    console.log("editar etapa " + etapaEditada.descricao)
    console.log("editar etapa " + etapaEditada.idEtapa)
    console.log("editar etapa " + etapaEditada.idObra)
    console.log("editar etapa " + etapaEditada.nomeEtapa)


    // Envia os dados da etapa editada para a API usando o método PUT
    this.etapasService.deleteEtapaEscolhida(etapaEditada.idEtapa).subscribe({
      next: () => {
        window.location.reload()
        console.log(`Etapa ${index + 1} excluida com sucesso!`);
      },
      error: (error) => {
        console.error(`Erro ao atualizar a Etapa ${index + 1}:`, error);
      }
    });
  }

  voltarPagina(): void {
    this.location.back();
  }

}
