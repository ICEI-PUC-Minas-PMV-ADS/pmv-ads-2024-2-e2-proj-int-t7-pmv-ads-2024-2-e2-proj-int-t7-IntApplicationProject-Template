import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuGestorClienteComponent } from './menu-gestor-cliente.component';
import { MenuGestorClienteRoutingModule } from './menu-gestor-cliente-routing.module';



@NgModule({
  declarations: [MenuGestorClienteComponent],
  imports: [
    CommonModule,
    MenuGestorClienteRoutingModule
  ]
})
export class MenuGestorClienteModule { }
