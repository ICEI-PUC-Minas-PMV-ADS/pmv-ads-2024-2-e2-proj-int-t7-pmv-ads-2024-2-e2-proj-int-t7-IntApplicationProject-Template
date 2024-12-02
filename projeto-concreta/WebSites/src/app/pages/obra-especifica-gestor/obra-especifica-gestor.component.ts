import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ObrasService } from "../../core/api/services/obras/obras.service"; // Ajuste o caminho
import { ObrasModel } from '../../core/api/models/obras/obras.models'; // Ajuste o caminho
import { Router } from '@angular/router';
import { EtapasModel } from '../../core/api/models/etapas/etapas.model';

@Component({
  selector: 'app-obra-especifica-gestor',
  templateUrl: './obra-especifica-gestor.component.html',
  styleUrl: './obra-especifica-gestor.component.scss'
})
export class ObraEspecificaGestorComponent {
  imageSrc: string = '../../../assets/capa-provisoria.svg'; //imagem padrão
  idObra: number | null = null;
  obra: ObrasModel | null = null;
  etapa: EtapasModel | null = null;
  linkObra: String | null = null;
  idTipoUsuario: number | null = null;
  isGestor: boolean | null = null;

  constructor(private route: ActivatedRoute, private obrasService: ObrasService, private router: Router) {}

  ngOnInit(): void {
    this.idTipoUsuario = parseInt(localStorage.getItem('idTipoUsuario') || '0', 10);
    if(this.idTipoUsuario == 1) {
      this.isGestor = true
    } else {
      this.isGestor = false
    }
    this.idObra = +this.route.snapshot.paramMap.get('id')!; // Captura o parâmetro 'id'
    // Aqui você pode usar o ID para buscar detalhes da obra na API, por exemplo.
    this.carregarObraEscolhida(this.idObra);
  }

  carregarObraEscolhida(idObra: number): void {
    this.obrasService.getObraEscolhida(idObra).subscribe({
      next: (data) => {
        this.obra = data; // Recebe os dados do backend
        this.linkObra = this.encodeIdObra(idObra);
        console.log(this.obra)
      },
      error: (error) => {
        console.error('Erro ao carregar obras Escolhida:', error);
      }
    });

  }

  encodeIdObra(idObra: number): string {
    const base64 = btoa(idObra.toString());
    return `OBRA-${base64}`;
  }
  

  marcarComoConcluida() {
    this.obrasService.atualizarEstaConcluido(this.obra!.idObra, true).subscribe(
      (response) => {
        this.router.navigate(['/obra-finalizada']);
        console.log('Obra atualizada:', response);
      },
      (error) => {
        console.error('Erro ao atualizar obra:', error);
      }
    );
  }

  excluirObra() {
    this.obrasService.excluirObra(this.obra!.idObra).subscribe(
      (response) => {
        this.router.navigate(['/obra-andamento']);
        console.log('Obra excluída:', response);
      },
      (error) => {
        console.error('Erro ao excluir obra:', error);
      }
    );
  }

  editImage() {
    const input = document.createElement('input');
    input.type = 'file';
    input.accept = 'image/*';

    input.onchange = (event: Event) => {
      const target = event.target as HTMLInputElement; // Verificação do tipo
      if (target.files && target.files.length > 0) {
        const file = target.files[0]; // Pega o primeiro arquivo
        const reader = new FileReader();
        
        reader.onload = () => {
          this.imageSrc = reader.result as string; // Atualiza a imagem
        };
        
        reader.readAsDataURL(file); // Lê a imagem como URL
      }
    };

    input.click(); 
  }
}
