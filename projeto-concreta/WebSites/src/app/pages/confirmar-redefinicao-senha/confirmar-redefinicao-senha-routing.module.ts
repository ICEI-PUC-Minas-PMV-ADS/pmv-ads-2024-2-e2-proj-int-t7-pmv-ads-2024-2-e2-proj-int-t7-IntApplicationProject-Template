import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConfirmarRedefinicaoSenhaComponent } from './confirmar-redefinicao-senha.component';

const routes: Routes = [
  { path: '', component: ConfirmarRedefinicaoSenhaComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ConfirmarRedefinicaoSenhaRoutingModule {}