import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ObraAndamentoComponent } from './obra-andamento.component';
import { obra_andamentoRoutingModule } from './obra-andamento-routing.module';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from '../../footer/footer.module';



@NgModule({
  declarations: [ObraAndamentoComponent],
  imports: [
    CommonModule, 
    obra_andamentoRoutingModule,
    NavBarModule,
    FooterModule,
  ]
})
export class obra_andamentoModule { }