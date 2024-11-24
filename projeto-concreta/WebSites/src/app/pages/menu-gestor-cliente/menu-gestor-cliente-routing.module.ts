import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MenuGestorClienteComponent } from './menu-gestor-cliente.component';
import { MenuGestorComponent } from './menu-gestor/menu-gestor.component';
import { MenuClienteComponent } from './menu-cliente/menu-cliente.component';

const routes: Routes = [
  {
    path: '',
    component: MenuGestorClienteComponent,
    children: [
      {
        path: 'gestor',
        component: MenuGestorComponent
      },
      {
        path: 'cliente',
        component: MenuClienteComponent
      },
      {
        path: '', 
        redirectTo: 'gestor',
        pathMatch: 'full'
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MenuGestorClienteRoutingModule {}
