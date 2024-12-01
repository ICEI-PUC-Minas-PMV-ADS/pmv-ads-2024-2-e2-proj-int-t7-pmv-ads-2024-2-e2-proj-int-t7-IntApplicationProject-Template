import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SolicitarEsqueceuSenhaComponent } from './solicitar-esqueceu-senha.component';

const routes: Routes = [
  { path: '', component: SolicitarEsqueceuSenhaComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SolicitarEsqueceuSenhaRoutingModule {}