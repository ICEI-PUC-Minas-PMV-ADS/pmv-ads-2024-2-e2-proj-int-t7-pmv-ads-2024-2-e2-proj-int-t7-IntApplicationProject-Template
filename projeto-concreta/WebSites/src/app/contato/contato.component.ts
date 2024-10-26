import { Component, OnInit } from '@angular/core';
import { ContatoService } from '../contato.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ContatosService } from '../core/api/services/contatos/contatos.service';

@Component({
  selector: 'app-contato',
  templateUrl: './contato.component.html',
})
export class ContatoComponent implements OnInit {
  nome: string = '';
  email: string = '';
  mensagem: string = '';

  formGroup!: FormGroup;

  constructor(
    private fb: FormBuilder,
    private contatoService: ContatosService
  ) {}

  ngOnInit(): void {
    this.configureForm();
  }

  configureForm() {
    this.formGroup = this.fb.group({
      nome: [null, [Validators.required]],
      email: [null, [Validators.required, Validators.email]],
      mensagem: [null, [Validators.required]],
    });
  }

  enviarFormulario() {
    const contato = {
      nome: this.formGroup.controls['nome'].value,
      email: this.formGroup.controls['email'].value,
      mensagem: this.formGroup.controls['mensagem'].value,
    };

    console.log(contato);

    this.contatoService.enviarContato(contato).subscribe({
      next: (value: any) => {
        this.formGroup.reset();
      }
    });

  }
}
