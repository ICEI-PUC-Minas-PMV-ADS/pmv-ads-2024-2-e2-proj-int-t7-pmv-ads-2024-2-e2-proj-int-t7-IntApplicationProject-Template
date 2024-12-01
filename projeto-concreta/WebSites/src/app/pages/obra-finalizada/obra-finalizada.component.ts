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
  obrasFiltradas: ObrasModel[] = [];
  idUsuario!: number;

  constructor(private obrasService: ObrasService, private router: Router) {}

  ngOnInit(): void {
    this.carregarObraFinalizada();
  }

  carregarObraFinalizada(): void {
    this.obrasService.getObraFinalizada().subscribe({
      next: (data: any[]) => {
        this.obraFinalizada = data.filter(obra => obra.estaConcluido);

        this.idUsuario = parseInt(localStorage.getItem('userId') || '0', 10);
        console.log(this.idUsuario)
        if (this.idUsuario != null) {
          this.obrasFiltradas = this.obraFinalizada.filter(obra => obra.idUsuario === Number(this.idUsuario));
          console.log(this.obrasFiltradas);
        } else {
          this.obraFinalizada = data.filter(obra => obra.estaConcluido);
          console.error('ID do usuário não encontrado no localStorage');
        }
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



