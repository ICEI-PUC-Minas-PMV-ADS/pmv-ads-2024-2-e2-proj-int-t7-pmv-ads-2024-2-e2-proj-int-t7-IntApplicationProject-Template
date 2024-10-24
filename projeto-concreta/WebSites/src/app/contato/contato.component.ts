import { Component } from '@angular/core';
import { ContatoService } from '../contato.service';

@Component({
  selector: 'app-contato',
  templateUrl: './contato.component.html',
})
export class ContatoComponent {
  nome: string = '';
  email: string = '';
  mensagem: string = '';

  constructor(private contatoService: ContatoService) {}

  enviarFormulario() {
    const contato = {
      nome: this.nome,
      email: this.email,
      mensagem: this.mensagem
    };

    this.contatoService.enviarContato(contato).subscribe(
      response => {
        alert('Mensagem enviada com sucesso!');
        // Limpar os campos do formulário, se desejar
        this.nome = '';
        this.email = '';
        this.mensagem = '';
      },
      error => {
        alert('Erro ao enviar a mensagem.');
      }
    );
  }
}
