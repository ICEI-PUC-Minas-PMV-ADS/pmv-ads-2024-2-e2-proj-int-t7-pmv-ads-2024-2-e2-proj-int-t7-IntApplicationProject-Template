import { Component, OnInit } from '@angular/core';
import { ObrasService } from "../../core/api/services/obras/obras.service"; // Ajuste o caminho
import { ObrasModel } from '../../core/api/models/obras/obras.models'; // Ajuste o caminho


@Component({
  selector: 'app-obra-finalizada',
  templateUrl: './obra-finalizada.component.html',
  styleUrls: ['./obra-finalizada.component.scss']
})
export class ObraFinalizadaComponent implements OnInit {
  obraFinalizada: ObrasModel[] = []; // Armazena as obras recebidas do backend

  constructor(private obrasService: ObrasService) {}

  ngOnInit(): void {
    this.carregarObraFinalizada();
  }

  carregarObraFinalizada(): void {
    this.obrasService.getObraFinalizada().subscribe({
      next: (data) => {
        this.obraFinalizada = data; // Recebe os dados do backend
      },
      error: (error) => {
        console.error('Erro ao carregar obras finalizadas:', error);
      }
    });
  }
}



