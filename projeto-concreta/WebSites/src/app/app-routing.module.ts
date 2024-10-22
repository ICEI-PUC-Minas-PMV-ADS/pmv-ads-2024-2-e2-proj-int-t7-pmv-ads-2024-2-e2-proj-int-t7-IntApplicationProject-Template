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
  },
  {
    path: 'obra-andamento',
    loadChildren: () => import('./pages/obra-andamento/obra-andamento.module').then(m => m.obra_andamentoModule)
  },
  {
    path: 'obra-finalizada',
    loadChildren: () => import('./pages/obra-finalizada/obra-finalizada.module').then(m => m.obra_finalizadaModule)
  },
  {
    path: 'cadastrar-obra',
    loadChildren: () => import('./pages/cadastrar-nova-obra/cadastrar-nova-obra.module').then(m => m.CadastrarNovaObraModule)
  },
  {
    path: 'cadastro-user',
    loadChildren: () => import('./pages/cadastro-user/cadastro-user.module').then(m => m.CadastroUserModule)
  },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
