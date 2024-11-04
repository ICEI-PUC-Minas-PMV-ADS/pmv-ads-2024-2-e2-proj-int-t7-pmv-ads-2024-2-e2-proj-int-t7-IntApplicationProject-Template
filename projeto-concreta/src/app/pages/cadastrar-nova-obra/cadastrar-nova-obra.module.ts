import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CadastrarNovaObraComponent } from './cadastrar-nova-obra.component';
import { CadastrarNovaObraRoutingModule } from './cadastrar-nova-obra-routing.module';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from '../../footer/footer.module';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { FloatLabelModule } from 'primeng/floatlabel';



@NgModule({
  declarations: [CadastrarNovaObraComponent],
  imports: [
    CommonModule,
    CadastrarNovaObraRoutingModule,
    NavBarModule,
    FooterModule,
    ButtonModule,
    InputTextModule,
    FloatLabelModule,
  ]
})
export class CadastrarNovaObraModule { }
