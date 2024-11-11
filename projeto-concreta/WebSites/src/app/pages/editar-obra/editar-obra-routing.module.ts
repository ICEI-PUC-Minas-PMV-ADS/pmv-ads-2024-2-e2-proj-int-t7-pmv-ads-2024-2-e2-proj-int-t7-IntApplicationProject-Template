import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EditarObraComponent } from './editar-obra.component';


const routes: Routes = [
    { path: '', component: EditarObraComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class EditarObraRoutingModule {}