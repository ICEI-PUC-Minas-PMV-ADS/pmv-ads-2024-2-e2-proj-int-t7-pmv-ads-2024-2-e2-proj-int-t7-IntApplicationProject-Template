import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from '../../footer/footer.module';
import { ObraFinalizadaComponent } from './obra-finalizada.component';
import { obra_finalizadaRoutingModule } from './obra-finalizada-routing.module';



@NgModule({
  declarations: [ObraFinalizadaComponent],
  imports: [
    CommonModule,
    obra_finalizadaRoutingModule,
    NavBarModule,
    FooterModule,
  ]
})
export class obra_finalizadaModule { }
