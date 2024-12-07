import { Component } from '@angular/core';

@Component({
  selector: 'app-menu-gestor-cliente',
  templateUrl: './menu-gestor-cliente.component.html',
  styleUrl: './menu-gestor-cliente.component.scss'
})
export class MenuGestorClienteComponent {
  menu: 'cliente' | 'gestor' = parseInt(localStorage.getItem('idTipoUsuario') || '0', 10) === 1 ? 'gestor' : 'cliente';

}
