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
    if (sectionId === 'sobre') {
      // Verifica se a página atual não é a home
      if (this.router.url !== '/home') {
        // Redireciona para a home
        this.router.navigate(['/home']).then(() => {
          // Aguarda a navegação antes de rolar
          setTimeout(() => {
            const section = document.getElementById(sectionId);
            if (section) {
              section.scrollIntoView({ behavior: 'smooth' });
            }
          }, 0); // Use um timeout para garantir que a rolagem ocorra após a navegação
        });
      } else {
        // Se já estiver na home, apenas rola
        const section = document.getElementById(sectionId);
        if (section) {
          section.scrollIntoView({ behavior: 'smooth' });
        }
      }
    }
  }

}
