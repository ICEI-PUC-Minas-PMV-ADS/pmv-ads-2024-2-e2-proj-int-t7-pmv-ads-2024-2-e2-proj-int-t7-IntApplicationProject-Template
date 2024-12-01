import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SolicitarEsqueceuSenhaRoutingModule} from './solicitar-esqueceu-senha-routing.module';
import { SolicitarEsqueceuSenhaComponent } from './solicitar-esqueceu-senha.component';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from "../../footer/footer.module";
import { FormsModule } from '@angular/forms';
import { ToastModule } from 'primeng/toast';

@NgModule({
  declarations: [SolicitarEsqueceuSenhaComponent],
  imports: [
    CommonModule,
    SolicitarEsqueceuSenhaRoutingModule,
    NavBarModule,
    FooterModule,
    FormsModule,
    ToastModule
  ]
})
export class SolicitarEsqueceuSenhaModule { }