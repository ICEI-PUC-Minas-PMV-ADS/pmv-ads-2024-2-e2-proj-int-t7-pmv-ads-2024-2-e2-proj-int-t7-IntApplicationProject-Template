import { Component } from '@angular/core';
import { MessageService } from 'primeng/api';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu-cliente',
  templateUrl: './menu-cliente.component.html',
  styleUrl: './menu-cliente.component.scss'
})
export class MenuClienteComponent {
  encryptedData: string = ''; // Variável vinculada ao input
  mensagem: string = '';

  constructor(
    private router: Router,
    private messageService: MessageService
  ) { }

  acessarObra() {
    console.log('O campo');
    if (!this.encryptedData) {
      this.messageService.add({ severity: 'error', summary: 'Aviso', detail: "O campo do código está vazio!" });
      console.error('O campo está vazio!');
      return;
    }

    try {
      
      const idObra = this.decodeIdObra(this.encryptedData);
      if(Number.isNaN(idObra)){
        this.messageService.add({ severity: 'warn', summary: 'Aviso', detail: "Parece que o código inserido está incorreto, fale com o seu gestor!" });
        return;
      }
      console.log('ID da obra decodificado:', idObra);
      this.messageService.add({ severity: 'success', summary: 'codigo recuperado com sucesso', detail: 'Codigo correto, redirecionando!' });    
      this.router.navigate(['/obra-especifica-gestor', idObra]);
    } catch (error) {
      this.messageService.add({ severity: 'warn', summary: 'Aviso', detail: "Parece que o código inserido está incorreto, fale com o seu gestor!" });
      console.error('Erro ao decodificar:', error);
    }
  }

  // Função para decodificar o valor inserido
  decodeIdObra(encoded: string): number {
    const base64 = encoded.replace('OBRA-', ''); // Remove o prefixo
    return parseInt(atob(base64), 10); // Decodifica e converte para número
  }
}
