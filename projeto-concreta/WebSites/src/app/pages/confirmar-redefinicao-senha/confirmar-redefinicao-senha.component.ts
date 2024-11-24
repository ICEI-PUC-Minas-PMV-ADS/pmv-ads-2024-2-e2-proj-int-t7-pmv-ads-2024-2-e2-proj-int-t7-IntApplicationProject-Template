import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MessageService } from 'primeng/api';
import { ConfirmarRedefinicaoSenhaService } from '../../services/confirmar-redefinicao-senha.service';
import { ConfirmarRedefinicaoSenhaDTO } from '../../dto/confirmar-redefinicao-senha.dto'; // Importando o DTO

@Component({
  selector: 'app-confirmar-redefinicao-senha',
  templateUrl: './confirmar-redefinicao-senha.component.html',
  styleUrls: ['./confirmar-redefinicao-senha.component.scss']
})
export class ConfirmarRedefinicaoSenhaComponent implements OnInit {
  token: string = '';
  novaSenha: string = '';
  confirmarSenha: string = '';
  mensagem: string = '';

  constructor(
    private confirmarRedefinicaoSenhaService: ConfirmarRedefinicaoSenhaService,
    private router: Router,
    private messageService: MessageService,
    private route: ActivatedRoute 
  ) {}

  ngOnInit(): void {
    this.token = this.route.snapshot.queryParamMap.get('token') || '';
  }

  onConfirmarRedefinicao() {
    if (this.novaSenha !== this.confirmarSenha) {
      this.messageService.add({
        severity: 'warn',
        summary: 'Atenção',
        detail: 'As senhas não coincidem.'
      });
      return;
    }

    // Inclui o token no DTO
    const confirmarDto: ConfirmarRedefinicaoSenhaDTO = {
      token: this.token,  // Inclui o token
      novaSenha: this.novaSenha,
      confirmarSenha: this.confirmarSenha
    };

    // Chama o serviço passando o DTO com o token e as senhas
    this.confirmarRedefinicaoSenhaService.confirmarRedefinicaoSenha(confirmarDto).subscribe({
      next: () => {
        this.messageService.add({
          severity: 'success',
          summary: 'Sucesso',
          detail: 'Senha redefinida com sucesso! Você será redirecionado para a página de login.'
        });

        setTimeout(() => {
          this.router.navigate(['/login']);
        }, 2000);
      },
      error: (err) => {
        const mensagem = err.error?.mensagem || 'Erro ao confirmar redefinição de senha.';
        this.messageService.add({
          severity: 'error',
          summary: 'Erro',
          detail: mensagem
        });
      }
    });
  }
}
