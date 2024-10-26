import { Component } from '@angular/core';
import { UsuarioService } from '../../services/usuario.service';
import { CadastrarUsuarioDto } from '../../dto/cadastrar-usuario.dto';
import { HttpErrorResponse } from '@angular/common/http';
import { Router } from '@angular/router';

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
  mensagem: string | null = null;
  senhaIncorreta: boolean = false; 

  constructor(private usuarioService: UsuarioService, private router: Router) {}

  onSubmit() {
    this.senhaIncorreta = false;

    if (this.usuario.Senha !== this.confirmarSenha) {
      this.senhaIncorreta = true; 
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
        this.mostrarMensagem('Usuário cadastrado com sucesso!');
        this.router.navigate(['/login']); 
      },
      error: err => {
        console.error(err);
        const mensagem = err.error?.mensagem || 'Erro ao cadastrar usuário. Tente novamente.';
        this.mostrarMensagem(mensagem);
      }
    });
  }

  mostrarMensagem(msg: string) {
    this.mensagem = msg;
    setTimeout(() => {
      this.mensagem = null;
    }, 10000);
  }

  fecharMensagem() {
    this.mensagem = null;
  }

  goToLogin() {
    this.router.navigate(['/login']);
  }
}
