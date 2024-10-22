import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ObraAndamentoComponent } from './obra-andamento.component';


const routes: Routes = [
  { path: '', component: ObraAndamentoComponent } 
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class obra_andamentoRoutingModule {}