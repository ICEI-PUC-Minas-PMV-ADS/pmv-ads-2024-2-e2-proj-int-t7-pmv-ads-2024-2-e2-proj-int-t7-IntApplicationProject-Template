import { Component } from '@angular/core';
import { SolicitarEsqueceuSenhaService } from '../../services/solicitar-esqueceu-senha.service';
import { MessageService } from 'primeng/api';
import { SolicitarEsqueceuSenhaDTO } from '../../dto/solicitar-esqueceu-senha.dto';

@Component({
  selector: 'app-solicitar-esqueceu-senha',
  templateUrl: './solicitar-esqueceu-senha.component.html',
  styleUrls: ['./solicitar-esqueceu-senha.component.scss']
})
export class SolicitarEsqueceuSenhaComponent {
  email: string = '';

  constructor(
    private solicitarEsqueceuSenhaService: SolicitarEsqueceuSenhaService,
    private messageService: MessageService
  ) {}

  onSolicitar() {
    if (!this.email) {
      this.messageService.add({
        severity: 'warn',
        summary: 'Atenção',
        detail: 'Por favor, insira um e-mail válido.'
      });
      return;
    }

    const solicitarDto: SolicitarEsqueceuSenhaDTO = { email: this.email };

    this.solicitarEsqueceuSenhaService.solicitarEsqueceuSenha(solicitarDto).subscribe({
      next: () => {
        this.messageService.add({
          severity: 'success',
          summary: 'Solicitação enviada',
          detail: 'Verifique seu e-mail para redefinir a senha.'
        });
        this.email = '';
      },
      error: (err: { error: { mensagem: string; }; }) => {
        const mensagem = err.error?.mensagem || 'Erro ao enviar solicitação.';
        this.messageService.add({
          severity: 'error',
          summary: 'Erro',
          detail: mensagem
        });
      }
    });
  }
}
