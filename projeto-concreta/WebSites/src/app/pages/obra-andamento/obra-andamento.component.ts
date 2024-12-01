import { Component, OnInit } from '@angular/core';
import { ObrasService } from "../../core/api/services/obras/obras.service"; // Ajuste o caminho
import { ObrasModel } from '../../core/api/models/obras/obras.models'; // Ajuste o caminho
import { Router } from '@angular/router';


@Component({
  selector: 'app-obra-andamento',
  templateUrl: './obra-andamento.component.html',
  styleUrls: ['./obra-andamento.component.scss']
})
export class ObraAndamentoComponent implements OnInit {
  tipoUsuario: number = 1; //pegar tipo usuario dinamicamente depois (1 para gestor e 2 para cliente)
  obrasEmAndamento: ObrasModel[] = [];
  visibleCount = 4; // Quantidade inicial de itens visíveis
  obrasFiltradas: ObrasModel[] = [];
  idUsuario!: number;

  constructor(private obrasService: ObrasService, private router: Router) {}

  ngOnInit(): void {
    // Chama o serviço para obter as obras em andamento
    
    this.obrasService.getObrasEmAndamento().subscribe(
      (dados: any[]) => {
        this.obrasEmAndamento = dados.filter(obra => !obra.estaConcluido);
        // Recupera o ID do usuário do localStorage
        this.idUsuario = parseInt(localStorage.getItem('userId') || '0', 10);

      if (this.idUsuario != null) {
        // Filtra as obras para mostrar apenas as obras do usuário atual
        this.obrasFiltradas = this.obrasEmAndamento.filter(obra => obra.idUsuario === Number(this.idUsuario));
        console.log(this.obrasFiltradas);
      } else {
        console.error('ID do usuário não encontrado no localStorage');
      }

      },
      (error: any) => {
        console.error('Erro ao buscar obras em andamento', error);
      },
    ); 

  }

  voltarParaMenu() {
    const rota = this.tipoUsuario === 1 ? 'menu-gestor-cliente/gestor' : 'menu-gestor-cliente/cliente';
    this.router.navigate([rota]);
  }
  
  carregarMaisObras() {
    this.visibleCount += 4; // Incrementa o número de itens visíveis
  }
  
  irParaObraEspecifica(id: number): void {
    this.router.navigate(['/obra-especifica-gestor', id]);
  }

}







