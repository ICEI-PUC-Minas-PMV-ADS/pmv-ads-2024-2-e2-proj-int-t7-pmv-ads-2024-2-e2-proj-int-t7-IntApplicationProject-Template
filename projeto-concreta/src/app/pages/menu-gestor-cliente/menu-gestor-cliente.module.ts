import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuGestorClienteComponent } from './menu-gestor-cliente.component';
import { MenuGestorClienteRoutingModule } from './menu-gestor-cliente-routing.module';
import { NavBarModule } from '../../navbar/navbar.module';
import { MenuGestorComponent } from './menu-gestor/menu-gestor.component';
import { MenuClienteComponent } from './menu-cliente/menu-cliente.component';
import { FooterModule } from '../../footer/footer.module';

@NgModule({
  declarations: [MenuGestorClienteComponent, MenuGestorComponent, MenuClienteComponent],
  imports: [
    CommonModule,
    MenuGestorClienteRoutingModule,
    NavBarModule,
    FooterModule
  ]
})
export class MenuGestorClienteModule { }
