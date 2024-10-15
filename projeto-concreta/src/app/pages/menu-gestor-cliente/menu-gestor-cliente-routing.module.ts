import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MenuGestorClienteComponent } from './menu-gestor-cliente.component';

const routes: Routes = [
  { path: '', component: MenuGestorClienteComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule] 
})
export class MenuGestorClienteRoutingModule {}
