import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-cadastrar-nova-obra',
  templateUrl: './cadastrar-nova-obra.component.html',
  styleUrls: ['./cadastrar-nova-obra.component.scss']
})
export class CadastrarNovaObraComponent implements OnInit {
  formGroup!: FormGroup;

  constructor(private fb: FormBuilder) {}

  ngOnInit(): void {
    this.configureForm();
  }

  configureForm() {
    this.formGroup = this.fb.group({
      // Informações sobre a obra
      nomeObra: [null, [Validators.required]],
      construtora: [null, [Validators.required]],
      localizacao: [null, [Validators.required]],
      prazoConclusao: [null], // Não obrigatório
      imagemCapa: [null], // Placeholder para arquivo de imagem
  
      // Etapas da obra
      etapas: this.fb.group({
        nomeEtapa: [null, [Validators.required]],
        descricaoEtapa: [null, [Validators.required]],
        prazoConclusaoEtapa: [null], // Não obrigatório
        imagemEtapa: [null] // Placeholder para arquivo de imagem
      })
    });
  }
  
  save() {
    const today = new Date().toISOString().split('T')[0];

    const novaObra = {
      nome: this.formGroup.controls['nomeObra'].value,
      descricao: this.formGroup.controls['construtora'].value,
      localizacao: this.formGroup.controls['localizacao'].value,
      dataInicio: today,
      dataFim: this.formGroup.controls['prazoConclusao'].value,
    }

    console.log(novaObra)
    }

  onFileSelected(event: Event, controlName: string) {
    const input = event.target as HTMLInputElement;
    if (input.files && input.files[0]) {
      const file = input.files[0];
      this.formGroup.get(controlName)?.setValue(file.name); // Armazena apenas o nome
    }
  }

  get etapasForm(): FormGroup {
    return this.formGroup.get('etapas') as FormGroup;
  }

}
