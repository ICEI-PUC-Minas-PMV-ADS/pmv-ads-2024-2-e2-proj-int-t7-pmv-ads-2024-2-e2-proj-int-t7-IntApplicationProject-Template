import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GalleriaThumbnails } from 'primeng/galleria';
import { ObrasService } from '../../core/api/services/obras/obras.service';
import { ObrasModel } from '../../core/api/models/obras/obras.models';
import { EtapasService } from '../../core/api/services/etapas/etapas.service';
import { EtapasModel } from '../../core/api/models/etapas/etapas.model';
import { MessageService } from 'primeng/api';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastrar-nova-obra',
  templateUrl: './cadastrar-nova-obra.component.html',
  styleUrls: ['./cadastrar-nova-obra.component.scss']
})
export class CadastrarNovaObraComponent implements OnInit {
  formGroup!: FormGroup;
  etapasForms: FormGroup[] = []; // Lista de formulários para cada etapa
  etapas: EtapasModel[] = []; // Lista de objetos de etapas
  idUsuario!: number;
  mmensagem: string = '';

  constructor(private fb: FormBuilder, private obraService: ObrasService, private etapasService: EtapasService, private messageService: MessageService, private router: Router,) {}

  ngOnInit(): void {
    this.idUsuario = parseInt(localStorage.getItem('userId') || '0', 10);
    console.log(this.idUsuario);
    this.configureForm();
  }

  configureForm() {
    this.formGroup = this.fb.group({
      nomeObra: [null, [Validators.required]],
      construtora: [null, [Validators.required]],
      localizacao: [null, [Validators.required]],
      prazoConclusao: [null],
    });
  
    // Inicializar a primeira etapa
    this.adicionarEtapa(null);
  }

  adicionarEtapa(event: Event | null): void {
    if (event) {
      event.preventDefault(); // Evita o redirecionamento do link
    }
  
    const novaEtapaForm = this.fb.group({
      nomeEtapa: [null, [Validators.required]],
      descricaoEtapa: [null, [Validators.required]],
      prazoConclusaoEtapa: [null], // Prazo de conclusão opcional
    });
  
    this.etapasForms.push(novaEtapaForm);
    this.etapas.push({
      nomeEtapa: '',
      descricao: '',
      dataConclusao: new Date(),
      idEtapa: 0,
      idObra: 0,
    });
  }
  
  
  
  
  save() {
    const today = new Date();

    console.log("id user "  + this.idUsuario)
  
    const novaObra: ObrasModel = {
      idObra: 0,
      nome: this.formGroup.controls['nomeObra'].value,
      descricao: '',
      localizacao: this.formGroup.controls['localizacao'].value,
      dataInicio: today,
      dataFim: this.formGroup.controls['prazoConclusao'].value,
      construtora: this.formGroup.controls['construtora'].value,
      estaConcluido: false,
      idGestor: this.idUsuario,
      idUsuario: this.idUsuario,
      idUf: 0,
    };

    console.log("Nova obra model " + novaObra.idUsuario)
  
    this.obraService.cadastrarObra(novaObra).subscribe({
      next: (response: any) => {
        const idObra = response.obraDto?.idObra;
        console.log(novaObra)
  
        if (!idObra) {
          console.error('Erro: idObra não encontrado na resposta.');
          return;
        }
  
        // Salvar todas as etapas
        this.etapasForms.forEach((etapaForm, index) => {
          const etapa: EtapasModel = {
            nomeEtapa: etapaForm.controls['nomeEtapa'].value,
            descricao: etapaForm.controls['descricaoEtapa'].value,
            dataConclusao: etapaForm.controls['prazoConclusaoEtapa'].value,
            idEtapa: 0,
            idObra: idObra,
          };
  
          this.etapasService.cadastrarEtapa(etapa).subscribe({
            next: (etapaResponse) => {
              console.log(`Etapa ${index + 1} cadastrada com sucesso:`, etapaResponse);
            },
            error: (etapaError) => {
              console.error(`Erro ao cadastrar etapa ${index + 1}:`, etapaError);
            },
          });
        });
  
        this.messageService.add({ severity: 'success', summary: 'Cadastro realizado', detail: 'Obra e etapas cadastradas com sucesso!' });
        this.router.navigate(['/obra-andamento']);
      },
      error: (error) => {
        console.error('Erro ao cadastrar obra:', error);
      },
    });
  }
  
}
