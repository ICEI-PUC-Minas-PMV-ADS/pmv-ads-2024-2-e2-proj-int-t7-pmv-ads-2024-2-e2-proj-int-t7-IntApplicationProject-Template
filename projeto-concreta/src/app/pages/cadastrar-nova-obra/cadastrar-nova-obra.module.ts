import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CadastrarNovaObraComponent } from './cadastrar-nova-obra.component';
import { CadastrarNovaObraRoutingModule } from './cadastrar-nova-obra-routing.module';



@NgModule({
  declarations: [CadastrarNovaObraComponent],
  imports: [
    CommonModule,
    CadastrarNovaObraRoutingModule
  ]
})
export class CadastrarNovaObraModule { }
