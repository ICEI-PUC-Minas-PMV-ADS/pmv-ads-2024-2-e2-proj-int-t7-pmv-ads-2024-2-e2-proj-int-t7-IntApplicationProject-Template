import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CadastroUserRoutingModule } from './cadastro-user-routing.module';
import { CadastroUserComponent } from './cadastro-user.component';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from "../../footer/footer.module";
import { RadioButtonModule } from 'primeng/radiobutton';
import { FormsModule } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { FloatLabelModule } from 'primeng/floatlabel';

@NgModule({
  declarations: [CadastroUserComponent],
  imports: [
    CommonModule,
    CadastroUserRoutingModule,
    NavBarModule,
    FooterModule,
    RadioButtonModule,
    FormsModule,
    ButtonModule,
    InputTextModule,
    FloatLabelModule,
  ]
})
export class CadastroUserModule { }
