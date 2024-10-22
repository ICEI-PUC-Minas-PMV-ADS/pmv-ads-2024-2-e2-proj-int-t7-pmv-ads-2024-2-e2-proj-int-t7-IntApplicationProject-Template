import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ObraFinalizadaComponent } from './obra-finalizada.component';


const routes: Routes = [
  { path: '', component: ObraFinalizadaComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class obra_finalizadaRoutingModule {}
