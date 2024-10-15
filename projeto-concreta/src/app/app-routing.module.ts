import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'home',  
    pathMatch: 'full'
  },
  { 
    path: 'home',
    loadChildren: () => import('./pages/home/home.module').then(m => m.HomeModule)
  },
  {
    path: 'menu-gestor-cliente',
    loadChildren: () => import('./pages/menu-gestor-cliente/menu-gestor-cliente.module').then(m => m.MenuGestorClienteModule)
  }, { 
    path: 'obra-andamento',
    loadChildren: () => import('./pages/obra-andamento/obra-andamento.module').then(m => m.obra_andamentoModule)
  },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
