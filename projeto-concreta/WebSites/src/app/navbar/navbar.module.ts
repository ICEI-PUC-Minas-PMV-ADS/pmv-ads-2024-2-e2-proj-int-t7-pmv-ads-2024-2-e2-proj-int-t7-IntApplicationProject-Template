import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './navbar.component';
import { LoginRoutingModule } from '../pages/login/login-routing.module';
import { CadastroUserRoutingModule } from '../pages/cadastro-user/cadastro-user-routing.module';

@NgModule({
  declarations: [NavbarComponent],
  imports: [
    CommonModule,
    LoginRoutingModule,
    CadastroUserRoutingModule,

  ], exports: [
    NavbarComponent
  ]
})
export class NavBarModule { }
