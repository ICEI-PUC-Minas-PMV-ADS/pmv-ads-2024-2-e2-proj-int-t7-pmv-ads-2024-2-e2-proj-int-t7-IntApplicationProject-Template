import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from '../../footer/footer.module';
import { ObraEspecificaGestorComponent } from './obra-especifica-gestor.component';
import { ObraEspecificaGestorRoutingModule } from './obra-especifica-gestor-routing.module';



@NgModule({
    declarations: [ObraEspecificaGestorComponent],
    imports: [
    CommonModule,
    ObraEspecificaGestorRoutingModule,
    NavBarModule,
    FooterModule,
    ]
})
export class ObraEspecificaGestorModule { }