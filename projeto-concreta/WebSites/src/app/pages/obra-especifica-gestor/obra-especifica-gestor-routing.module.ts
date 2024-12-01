import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ObraEspecificaGestorComponent } from './obra-especifica-gestor.component';


const routes: Routes = [
    { path: '', component: ObraEspecificaGestorComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ObraEspecificaGestorRoutingModule {}