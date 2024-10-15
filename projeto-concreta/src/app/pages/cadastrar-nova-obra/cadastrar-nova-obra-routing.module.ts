import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastrarNovaObraComponent } from './cadastrar-nova-obra.component';

const routes: Routes = [
  { path: '', component: CadastrarNovaObraComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CadastrarNovaObraRoutingModule {}
