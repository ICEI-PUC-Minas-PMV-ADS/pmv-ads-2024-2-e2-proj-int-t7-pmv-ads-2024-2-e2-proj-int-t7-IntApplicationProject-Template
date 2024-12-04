import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ObrasService } from '../../core/api/services/obras/obras.service';
import { EtapasService } from '../../core/api/services/etapas/etapas.service';
import { MessageService } from 'primeng/api';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastrar-nova-obra',
  templateUrl: './cadastrar-nova-obra.component.html',
  styleUrls: ['./cadastrar-nova-obra.component.scss']
})
export class CadastrarNovaObraComponent implements OnInit {
  formGroup!: FormGroup;
  etapasControlsArray: FormGroup[] = [];
  etapasFormArray!: FormArray; // Alterado para usar FormArray
  idUsuario!: number;

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
    console.log(this.formGroup.value);
  }

  // Configuração inicial do formulário
  configureForm() {
    this.etapasFormArray = this.fb.array([
      this.createEtapaFormGroup() // Adiciona a primeira etapa inicial
    ]);

    this.formGroup = this.fb.group({
      nomeObra: [null, [Validators.required]],
      construtora: [null, [Validators.required]],
      localizacao: [null, [Validators.required]],
      prazoConclusao: [null],
      etapas: this.etapasFormArray // Associa o FormArray ao formulário principal
    });
  }

  // Criação dinâmica de FormGroup para etapas
  createEtapaFormGroup(): FormGroup {
    return this.fb.group({
      nomeEtapa: [null, [Validators.required]],
      descricaoEtapa: [null, [Validators.required]],
      prazoConclusaoEtapa: [null]
    });
  }

  // Adiciona uma nova etapa ao FormArray
  addNovaEtapa(event: Event) {
    event.preventDefault();
    this.etapasFormArray.push(this.createEtapaFormGroup());
  console.log('Etapa adicionada com sucesso!', this.formGroup.value);
  }

  // Getter para acessar controles do FormArray no template
  get etapasControls() {
    return (this.formGroup.get('etapas') as FormArray).controls;
  }

  // Método de salvar obra e suas etapas
  save() {
    const today = new Date();

    const novaObra = {
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
      idUf: 0
    };

    this.obraService.cadastrarObra(novaObra).subscribe({
      next: (response: any) => {
        const idObra = response.obraDto?.idObra;
        if (!idObra) {
          console.error('Erro: idObra não encontrado na resposta.');
          return;
        }

        // Loop pelas etapas para salvá-las
        this.etapasFormArray.controls.forEach((etapaForm, index) => {
          const novaEtapa = {
            nomeEtapa: etapaForm.get('nomeEtapa')?.value,
            descricao: etapaForm.get('descricaoEtapa')?.value,
            dataConclusao: etapaForm.get('prazoConclusaoEtapa')?.value,
            idEtapa: 0,
            idObra: idObra
          };

          this.etapasService.cadastrarEtapa(novaEtapa).subscribe({
            next: () => {
              console.log(`Etapa ${index + 1} cadastrada com sucesso!`);
            },
            error: etapaError => {
              console.error(`Erro ao cadastrar a Etapa ${index + 1}:`, etapaError);
            }
          });
        });

        this.messageService.add({
          severity: 'success',
          summary: 'Cadastro de obra bem-sucedido',
          detail: 'Obra e etapas cadastradas com sucesso!'
        });
        this.router.navigate(['/obra-andamento']);
      },
      error: error => {
        console.error('Erro ao cadastrar obra:', error);
      }
    });
  }
}
