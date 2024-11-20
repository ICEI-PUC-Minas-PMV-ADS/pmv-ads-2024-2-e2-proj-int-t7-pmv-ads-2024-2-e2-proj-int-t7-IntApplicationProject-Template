import { Component, OnInit } from '@angular/core';
import { ObrasService } from "../../core/api/services/obras/obras.service"; // Ajuste o caminho
import { ObrasModel } from '../../core/api/models/obras/obras.models'; // Ajuste o caminho
import { Router } from '@angular/router';


@Component({
  selector: 'app-obra-finalizada',
  templateUrl: './obra-finalizada.component.html',
  styleUrls: ['./obra-finalizada.component.scss']
})
export class ObraFinalizadaComponent implements OnInit {
  obraFinalizada: ObrasModel[] = []; // Armazena as obras recebidas do backend
  tipoUsuario: number = 1; //pegar tipo usuario dinamicamente depois (1 para gestor e 2 para cliente)
  visibleCount = 4; // Quantidade inicial de itens visíveis

  constructor(private obrasService: ObrasService, private router: Router) {}

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

  voltarParaMenu() {
    const rota = this.tipoUsuario === 1 ? 'menu-gestor-cliente/gestor' : 'menu-gestor-cliente/cliente';
    this.router.navigate([rota]);
  }

  carregarMaisObras() {
    this.visibleCount += 4; // Incrementa o número de itens visíveis
  }

}



