import { Component } from '@angular/core';

@Component({
  selector: 'app-obra-especifica-gestor',
  templateUrl: './obra-especifica-gestor.component.html',
  styleUrl: './obra-especifica-gestor.component.scss'
})
export class ObraEspecificaGestorComponent {
  imageSrc: string = '../../../assets/capa-provisoria.svg'; //imagem padrão

  editImage() {
    const input = document.createElement('input');
    input.type = 'file';
    input.accept = 'image/*';

    input.onchange = (event: Event) => {
      const target = event.target as HTMLInputElement; // Verificação do tipo
      if (target.files && target.files.length > 0) {
        const file = target.files[0]; // Pega o primeiro arquivo
        const reader = new FileReader();
        
        reader.onload = () => {
          this.imageSrc = reader.result as string; // Atualiza a imagem
        };
        
        reader.readAsDataURL(file); // Lê a imagem como URL
      }
    };

    input.click(); 
  }
}
