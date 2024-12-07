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
    path: 'menu-gestor-cliente/gestor',
    loadChildren: () => import('./pages/menu-gestor-cliente/menu-gestor/menu-gestor.component').then(m => m.MenuGestorComponent)
  },
  {
    path: 'menu-gestor-cliente/cliente',
    loadChildren: () => import('./pages/menu-gestor-cliente/menu-cliente/menu-cliente.component').then(m => m.MenuClienteComponent)
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
  {
    path: 'login',
    loadChildren: () => import('./pages/login/login.module').then(m => m.LoginModule)
  },
  {
    path: 'obra-especifica-gestor/:id',
    loadChildren: () => import('./pages/obra-especifica-gestor/obra-especifica-gestor.module').then(m => m.ObraEspecificaGestorModule)
  },
  {
    path: 'editar-obra/:id',
    loadChildren: () => import('./pages/editar-obra/editar-obra.module').then(m => m.EditarObraModule)
  },
  {
    path: 'esqueceu-senha',
    loadChildren: () => import('./pages/solicitar-esqueceu-senha/solicitar-esqueceu-senha.module').then(m => m.SolicitarEsqueceuSenhaModule)
  },

];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
