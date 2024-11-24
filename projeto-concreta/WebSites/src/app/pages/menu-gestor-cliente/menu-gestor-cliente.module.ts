import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuGestorClienteComponent } from './menu-gestor-cliente.component';
import { MenuGestorClienteRoutingModule } from './menu-gestor-cliente-routing.module';
import { NavBarModule } from '../../navbar/navbar.module';
import { MenuGestorComponent } from './menu-gestor/menu-gestor.component';
import { MenuClienteComponent } from './menu-cliente/menu-cliente.component';
import { FooterModule } from '../../footer/footer.module';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { FloatLabelModule } from 'primeng/floatlabel';

@NgModule({
  declarations: [MenuGestorClienteComponent, MenuGestorComponent, MenuClienteComponent],
  imports: [
    CommonModule,
    MenuGestorClienteRoutingModule,
    NavBarModule,
    FooterModule,
    ButtonModule,
    InputTextModule,
    FloatLabelModule
  ]
})
export class MenuGestorClienteModule { }
