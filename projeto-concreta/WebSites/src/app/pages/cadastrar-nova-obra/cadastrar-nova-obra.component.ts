import { Component } from '@angular/core';

@Component({
  selector: 'app-cadastrar-nova-obra',
  templateUrl: './cadastrar-nova-obra.component.html',
  styleUrl: './cadastrar-nova-obra.component.scss'
})
export class CadastrarNovaObraComponent {
  dateValue: string | null = null; // Variável para armazenar o valor do input de data

  hideLabel() {
    // Esconde o label ao focar no input
    if (!this.dateValue) {
      this.dateValue = ''; // Necessário para acionar a mudança no Angular
    }
  }

  showLabel() {
    // Mostra o label se o input estiver vazio ao desfocar
    if (!this.dateValue) {
      this.dateValue = null;
    }
  }
}
