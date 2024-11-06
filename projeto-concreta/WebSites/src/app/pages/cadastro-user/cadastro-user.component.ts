import { Component } from '@angular/core';
import { UsuarioService } from '../../services/usuario.service';
import { CadastrarUsuarioDto } from '../../dto/cadastrar-usuario.dto';
import { Router } from '@angular/router';
import { MessageService } from 'primeng/api';

@Component({
  selector: 'app-cadastro-user',
  templateUrl: './cadastro-user.component.html',
  styleUrls: ['./cadastro-user.component.scss']
})
export class CadastroUserComponent {
  usuario: CadastrarUsuarioDto = {
    Nome: '',
    Email: '',
    Senha: '',
    IdTipoUsuario: 0
  };

  confirmarSenha: string = '';
  senhaIncorreta: boolean = false; 

  constructor(
    private usuarioService: UsuarioService, 
    private router: Router,
    private messageService: MessageService
  ) {}

  onSubmit() {
    this.senhaIncorreta = false;

    if (!this.usuario.Nome || !this.usuario.Email || !this.usuario.Senha || !this.confirmarSenha) {
      this.messageService.add({ severity: 'error', summary: 'Erro', detail: 'Todos os campos são obrigatórios.' });
      return;
    }

    if (this.usuario.Senha !== this.confirmarSenha) {
      this.senhaIncorreta = true; 
      this.messageService.add({ severity: 'error', summary: 'Erro', detail: 'As senhas não coincidem.' });
      return;
    }

    const usuarioDto = {
      Nome: this.usuario.Nome,
      Email: this.usuario.Email,
      Senha: this.usuario.Senha,
      ConfirmarSenha: this.confirmarSenha,
      IdTipoUsuario: this.usuario.IdTipoUsuario
    };

    this.usuarioService.cadastrarUsuario(usuarioDto).subscribe({
      next: response => {
        this.messageService.add({ severity: 'success', summary: 'Sucesso', detail: 'Usuário cadastrado com sucesso!' });
        this.router.navigate(['/login']); 
      },
      error: err => {
        const mensagem = err.error?.mensagem || 'Erro ao cadastrar usuário. Tente novamente.';
        this.messageService.add({ severity: 'error', summary: 'Erro', detail: mensagem });
      }
    });
  }

  goToLogin() {
    this.router.navigate(['/login']);
  }
}
