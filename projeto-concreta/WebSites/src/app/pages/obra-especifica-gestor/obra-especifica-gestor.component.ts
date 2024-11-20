import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ObrasService } from "../../core/api/services/obras/obras.service"; // Ajuste o caminho
import { ObrasModel } from '../../core/api/models/obras/obras.models'; // Ajuste o caminho

@Component({
  selector: 'app-obra-especifica-gestor',
  templateUrl: './obra-especifica-gestor.component.html',
  styleUrl: './obra-especifica-gestor.component.scss'
})
export class ObraEspecificaGestorComponent {
  imageSrc: string = '../../../assets/capa-provisoria.svg'; //imagem padrão
  idObra: number | null = null;
  obra: ObrasModel | null = null;

  constructor(private route: ActivatedRoute, private obrasService: ObrasService) {}

  ngOnInit(): void {
    this.idObra = +this.route.snapshot.paramMap.get('id')!; // Captura o parâmetro 'id'
    // Aqui você pode usar o ID para buscar detalhes da obra na API, por exemplo.
    this.carregarObraEscolhida(this.idObra);
  }

  carregarObraEscolhida(idObra: number): void {
    this.obrasService.getObraEscolhida(idObra).subscribe({
      next: (data) => {
        this.obra = data; // Recebe os dados do backend
      },
      error: (error) => {
        console.error('Erro ao carregar obras Escolhida:', error);
      }
    });

  }

  marcarComoConcluida() {
    this.obrasService.atualizarEstaConcluido(this.obra!.idObra, true).subscribe(
      (response) => {
        console.log('Obra atualizada:', response);
      },
      (error) => {
        console.error('Erro ao atualizar obra:', error);
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
