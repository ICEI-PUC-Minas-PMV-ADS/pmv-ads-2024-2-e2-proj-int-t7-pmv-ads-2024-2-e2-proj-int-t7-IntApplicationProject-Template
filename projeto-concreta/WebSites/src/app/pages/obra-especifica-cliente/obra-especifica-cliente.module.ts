import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from '../../footer/footer.module';
import { ObraEspecificaClienteComponent } from './obra-especifica-cliente.component';
import { ObraEspecificaClienteRoutingModule } from './obra-especifica-cliente-routing.module';



@NgModule({
    declarations: [ObraEspecificaClienteComponent],
    imports: [
    CommonModule,
    ObraEspecificaClienteRoutingModule,
    NavBarModule,
    FooterModule,
    ]
})
export class ObraEspecificaClienteModule { }