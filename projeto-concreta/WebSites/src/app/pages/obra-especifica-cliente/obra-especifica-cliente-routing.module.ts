import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ObraEspecificaClienteComponent } from './obra-especifica-cliente.component';


const routes: Routes = [
    { path: '', component: ObraEspecificaClienteComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ObraEspecificaClienteRoutingModule {}