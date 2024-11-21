import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.scss'
})
export class NavbarComponent {
  isMenuOpen = false;

  toggleMenu() {
    this.isMenuOpen = !this.isMenuOpen;
  }

  constructor(
    private router: Router,
  ) {
  }

  scrollToSection(sectionId: string) {
    const routesMap: { [key: string]: string } = {
      sobre: '/home',
      ferramentas: '/home',
      contato: '/home',
    };

    const targetRoute = routesMap[sectionId];

    if (!targetRoute) {
      console.error(`Seção ${sectionId} não está mapeada.`);
      return;
    }

    if (this.router.url !== targetRoute) {
      // Redireciona para a rota correspondente
      this.router.navigate([targetRoute]).then(() => {
        // Aguarda a navegação antes de rolar
        setTimeout(() => this.scrollToElement(sectionId), 0);
      });
    } else {
      // Se já estiver na rota correta, apenas rola
      this.scrollToElement(sectionId);
    }
  }

  private scrollToElement(sectionId: string) {
    const section = document.getElementById(sectionId);
    if (section) {
      section.scrollIntoView({ behavior: 'smooth' });
    } else {
      console.warn(`Seção com ID '${sectionId}' não encontrada.`);
    }
  }


}
