import { Component, OnInit } from '@angular/core';
import { ContatoService } from '../contato.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ContatosService } from '../core/api/services/contatos/contatos.service';
import { MessageService } from 'primeng/api';

@Component({
  selector: 'app-contato',
  templateUrl: './contato.component.html',
  styleUrl: './contato.component.scss'
})
export class ContatoComponent implements OnInit {
  nome: string = '';
  email: string = '';
  mensagem: string = '';

  formGroup!: FormGroup;

  constructor(
    private fb: FormBuilder,
    private contatoService: ContatosService,
    private messageService: MessageService
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

  oi() {
    const value = "oi"
    this.messageService.add({
      severity: 'success',
      summary: 'Success',
      detail: value || 'Contato enviado com sucesso!'
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
        console.log(value)
        this.messageService.add({
          severity: 'success',
          summary: 'Success',
          detail: value.message || 'Contato enviado com sucesso!'
        });
        this.formGroup.reset({
          nome: '',
          email: '',
          mensagem: ''
        });
      },
      error: (err: any) => {
        this.messageService.add({
          severity: 'error',
          summary: 'Erro',
          detail: 'Erro ao enviar contato. Tente novamente.'
        });
      }
    });
    

  }
}
