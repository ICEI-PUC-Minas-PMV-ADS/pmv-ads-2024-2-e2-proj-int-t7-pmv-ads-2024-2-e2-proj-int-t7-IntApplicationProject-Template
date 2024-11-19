import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu-gestor',
  templateUrl: './menu-gestor.component.html',
  styleUrl: './menu-gestor.component.scss'
})
export class MenuGestorComponent {

  constructor(
    private router: Router,
  ) {
  }

  goToNovaObra() {
    this.router.navigateByUrl(`cadastrar-obra`)
  }

  goToObrasEmAndamento() {
    this.router.navigateByUrl(`obra-andamento`)
  }
  goToObraFinalizada() {
    this.router.navigateByUrl(`obra-finalizada`)
  }

}
