import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConfirmarRedefinicaoSenhaRoutingModule } from './confirmar-redefinicao-senha-routing.module';
import { ConfirmarRedefinicaoSenhaComponent } from './confirmar-redefinicao-senha.component';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from "../../footer/footer.module";
import { FormsModule } from '@angular/forms';
import { ToastModule } from 'primeng/toast';

@NgModule({
  declarations: [ConfirmarRedefinicaoSenhaComponent],
  imports: [
    CommonModule,
    ConfirmarRedefinicaoSenhaRoutingModule,
    NavBarModule,
    FooterModule,
    FormsModule,
    ToastModule,
  ]
})
export class ConfirmarRedefinicaoSenhaModule { }
