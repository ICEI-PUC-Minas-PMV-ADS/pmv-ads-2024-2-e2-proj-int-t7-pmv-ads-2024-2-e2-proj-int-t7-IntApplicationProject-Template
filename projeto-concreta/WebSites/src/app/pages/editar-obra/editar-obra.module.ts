import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from '../../footer/footer.module';
import { EditarObraComponent  } from './editar-obra.component';
import { EditarObraRoutingModule } from './editar-obra-routing.module';
import { FormsModule } from '@angular/forms';



@NgModule({
    declarations: [EditarObraComponent ],
    imports: [
    CommonModule,
    EditarObraRoutingModule,
    NavBarModule,
    FormsModule,
    FooterModule,
    ]
})
export class EditarObraModule { }