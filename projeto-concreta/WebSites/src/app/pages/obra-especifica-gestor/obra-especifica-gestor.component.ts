import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ObrasService } from "../../core/api/services/obras/obras.service"; // Ajuste o caminho
import { ObrasModel } from '../../core/api/models/obras/obras.models'; // Ajuste o caminho
import { Router } from '@angular/router';
import { EtapasModel } from '../../core/api/models/etapas/etapas.model';
import { jsPDF } from 'jspdf'; // Biblioteca para gerar PDFs
import autoTable from 'jspdf-autotable'; // Plugin opcional para tabelas no PDF
import { EtapasService } from '../../core/api/services/etapas/etapas.service';

@Component({
  selector: 'app-obra-especifica-gestor',
  templateUrl: './obra-especifica-gestor.component.html',
  styleUrl: './obra-especifica-gestor.component.scss'
})
export class ObraEspecificaGestorComponent {
  imageSrc: string = '../../../assets/capa-provisoria.svg'; //imagem padrão
  idObra: number | null = null;
  obra: ObrasModel | null = null;
  etapasRelatorio: EtapasModel[] = []; // Inicialize como um array vazio
  etapa: EtapasModel | null = null;
  linkObra: String | null = null;
  idTipoUsuario: number | null = null;
  isGestor: boolean | null = null;

  constructor(private route: ActivatedRoute, private obrasService: ObrasService, private router: Router, private etapasService: EtapasService,) {}

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
    this.carregarEtapaEscolhida(1);
  }

  gerarRelatorioSimples(event: Event) {
    event.preventDefault();
    if (!this.obra) {
    
      console.error('Dados da obra não encontrados.');
      return;
    }
    const doc = new jsPDF();

    // Título do relatório
    doc.setFontSize(18);
    doc.text('Relatório Simples da Obra', 105, 20, { align: 'center' });

    // Dados básicos da obra
    doc.setFontSize(12);
    doc.text(`Nome: ${this.obra.nome}`, 10, 40);
    doc.text(`Localização: ${this.obra.localizacao}`, 10, 50);
    doc.text(`Construtora: ${this.obra.construtora}`, 10, 60); 
    doc.text(`Prazo de Conclusão: ${new Date(this.obra.dataFim).toLocaleDateString()}`, 10, 70);

    // Salvar o PDF
    doc.save(`Relatorio_Simples_Obra_${this.obra.nome}.pdf`);
  }

  gerarRelatorioDetalhado(event: Event) {
    event.preventDefault();
    if (!this.obra) {
      console.error('Dados da obra não encontrados.');
      return;
    }
    const doc = new jsPDF();

    // Título do relatório
    doc.setFontSize(18);
    doc.text('Relatório Detalhado da Obra', 105, 20, { align: 'center' });

    // Dados básicos da obra
    doc.setFontSize(12);
    doc.text(`Nome: ${this.obra.nome}`, 10, 40);
    doc.text(`Localização: ${this.obra.localizacao}`, 10, 50);
    doc.text(`Construtora: ${this.obra.construtora}`, 10, 60); 
    doc.text(`Prazo de Conclusão: ${new Date(this.obra.dataFim).toLocaleDateString()}`, 10, 70);


  // Adicionando as etapas ao relatório
  let yPosition = 80; // Posição inicial para as etapas
  doc.text('Etapas da Obra:', 10, yPosition);
  yPosition += 10;

  if (this.etapasRelatorio && this.etapasRelatorio.length > 0) {
    this.etapasRelatorio.forEach((etapasRelatorio, index) => {      

      const dataFormatada = etapasRelatorio?.dataConclusao ? new Date(etapasRelatorio.dataConclusao).toLocaleDateString() : 'Data não disponível';
      doc.text(` ${etapasRelatorio?.nomeEtapa} - Descrição: ${etapasRelatorio?.descricao} - Prazo: ${dataFormatada}`, 10, yPosition);
      
      yPosition += 10;
    });
  } else {
    doc.text('Nenhuma etapa encontrada.', 10, yPosition);
  }

    // Salvar o PDF
    doc.save(`Relatorio_Detalhado_Obra_${this.obra.nome}.pdf`);

  }

  carregarEtapaEscolhida(idObra: number): void {
    console.log("entrei no método")
    this.etapasService.getEtapaEscolhida(idObra).subscribe({
      next: (data) => {
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
