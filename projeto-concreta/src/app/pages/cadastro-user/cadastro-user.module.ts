import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CadastroUserRoutingModule } from './cadastro-user-routing.module';
import { CadastroUserComponent } from './cadastro-user.component';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from "../../footer/footer.module";
import { RadioButtonModule } from 'primeng/radiobutton';



@NgModule({
  declarations: [CadastroUserComponent],
  imports: [
    CommonModule,
    CadastroUserRoutingModule,
    NavBarModule,
    FooterModule,
    RadioButtonModule,
]
})
export class CadastroUserModule { }
