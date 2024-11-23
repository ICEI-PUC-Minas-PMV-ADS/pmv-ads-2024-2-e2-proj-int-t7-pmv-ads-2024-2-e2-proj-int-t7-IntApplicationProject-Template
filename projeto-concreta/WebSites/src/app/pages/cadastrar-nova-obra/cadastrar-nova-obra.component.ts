import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MessageService } from 'primeng/api';
import { ObrasService } from '../../core/api/services/obras/obras.service';
import { ObrasModel } from '../../core/api/models/obras/obras.models';
import { EtapasService } from '../../core/api/services/etapas/etapas.service';
import { EtapasModel } from '../../core/api/models/etapas/etapas.model';

@Component({
  selector: 'app-cadastrar-nova-obra',
  templateUrl: './cadastrar-nova-obra.component.html',
  styleUrls: ['./cadastrar-nova-obra.component.scss']
})
export class CadastrarNovaObraComponent implements OnInit {
  formGroup!: FormGroup;
  etapasForm!: FormGroup;
  idUsuario!: number;
  mmensagem: string = '';

  constructor(
    private fb: FormBuilder,
    private obraService: ObrasService,
    private etapasService: EtapasService,
    private messageService: MessageService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.idUsuario = parseInt(localStorage.getItem('userId') || '0', 10);
    console.log(this.idUsuario);
    this.configureForm();
  }

  configureForm() {
    this.formGroup = this.fb.group({
      // Informações sobre a obra
      nomeObra: [null, [Validators.required]],
      construtora: [null, [Validators.required]],
      localizacao: [null, [Validators.required]],
      prazoConclusao: [null], // Não obrigatório
    });

    this.etapasForm = this.fb.group({
      nomeEtapa: [null, [Validators.required]],
      descricaoEtapa: [null, [Validators.required]],
      prazoConclusaoEtapa: [null], // Não obrigatório
    });
  }

  save() {
    const today = new Date();
    let idObraCriada: number;

    console.log("interno save button " + this.idUsuario);

    const novaObra: ObrasModel = {
      idObra: 0, // nao alterei na model pois era usado em outros arquivos
      nome: this.formGroup.controls['nomeObra'].value,
      descricao: this.formGroup.controls['construtora'].value,
      localizacao: this.formGroup.controls['localizacao'].value,
      dataInicio: today,
      dataFim: this.formGroup.controls['prazoConclusao'].value,
      construtora: this.formGroup.controls['construtora'].value,
      estaConcluido: false,
      idGestor: this.idUsuario,
      idUsuario: this.idUsuario,
      idUf: 0, // nao alterei na model pois era usado em outros arquivos
    };

    console.log("aaa" + novaObra);

    this.obraService.cadastrarObra(novaObra).subscribe({
      next: (response: any) => {
        // Se response.obraDto for o retorno esperado
        const idObra = response.obraDto?.idObra;

        if (!idObra) {
          console.error("Erro: idObra não encontrado na resposta.");
          this.messageService.add({ severity: 'error', summary: 'Erro', detail: 'Erro ao cadastrar obra.' });
          return;
        }

        console.log("response.idObra antes: " + idObra);

        const novaEtapa: EtapasModel = {
          nomeEtapa: this.etapasForm.get('nomeEtapa')?.value,
          descricao: this.etapasForm.get('descricaoEtapa')?.value,
          dataConclusao: this.etapasForm.get('prazoConclusaoEtapa')?.value,
          idEtapa: 0,
          idObra: idObra,
        };

        console.log("response.idObra depois: " + idObra);

        this.etapasService.cadastrarEtapa(novaEtapa).subscribe({
          next: etapaResponse => {
            this.messageService.add({
              severity: 'success',
              summary: 'Cadastro de etapa bem-sucedido',
              detail: 'Etapa cadastrada com sucesso!',
            });
            console.log("Etapa cadastrada com sucesso:", etapaResponse);
          },
          error: etapaError => {
            console.error("Erro ao cadastrar etapa:", etapaError);
            this.messageService.add({
              severity: 'error',
              summary: 'Erro',
              detail: 'Erro ao cadastrar etapa.',
            });
          },
        });

        this.messageService.add({
          severity: 'success',
          summary: 'Cadastro de obra bem-sucedido',
          detail: 'Obra cadastrada!',
        });
        console.log("Obra cadastrada:", response);
        this.router.navigate(['/obra-andamento']); // Navega para a rota de obras em andamento
      },
      error: error => {
        console.error("Erro ao cadastrar obra:", error);
        this.messageService.add({
          severity: 'error',
          summary: 'Erro',
          detail: 'Erro ao cadastrar obra.',
        });
      },
    });
  }
}
