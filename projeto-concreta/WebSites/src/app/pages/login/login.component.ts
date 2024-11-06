import { Component } from '@angular/core';
import { LoginService } from '../../services/login.services';
import { Router } from '@angular/router';
import { LoginDTO } from '../../dto/login.dto';
import { MessageService } from 'primeng/api';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  email: string = '';
  senha: string = '';
  mensagem: string = '';

  constructor(
    private loginservice: LoginService,
    private router: Router,
    private messageService: MessageService
  ) { }

  onLogin() {
    const loginDto: LoginDTO = { email: this.email, senha: this.senha };

    this.loginservice.login(loginDto).subscribe({
      next: (response) => {
        const idTipoUsuario = response.idTipoUsuario;
        localStorage.setItem('idTipoUsuario', idTipoUsuario);
        
        if (idTipoUsuario === 1) {
          this.router.navigate(['/menu-gestor-cliente/gestor']);
          this.messageService.add({ severity: 'success', summary: 'Login bem-sucedido', detail: 'Bem-vindo, Gestor!' });
        } else if (idTipoUsuario === 2) {
          this.router.navigate(['/menu-gestor-cliente/cliente']);
          this.messageService.add({ severity: 'success', summary: 'Login bem-sucedido', detail: 'Bem-vindo, Cliente!' });
        } else {
          this.mensagem = 'Tipo de usuário desconhecido.';
          this.messageService.add({ severity: 'warn', summary: 'Aviso', detail: this.mensagem });
        }
      },
      error: (err) => {
        this.mensagem = err.error?.mensagem || 'Erro ao realizar login.';
        this.messageService.add({ severity: 'error', summary: 'Erro', detail: this.mensagem || 'Erro ao realizar login.' }); // Garantindo que não seja null
      }
    });
  }
}
