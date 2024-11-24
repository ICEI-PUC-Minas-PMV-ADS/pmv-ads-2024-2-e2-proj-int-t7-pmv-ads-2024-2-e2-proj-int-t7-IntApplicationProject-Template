import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { NavbarComponent } from '../../navbar/navbar.component';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from "../../footer/footer.module";
import {ContatoComponent} from "../../contato/contato.component";
import { ContatoModule } from '../../contato/contato.module';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [HomeComponent],
  imports: [
    CommonModule,
    HomeRoutingModule,
    NavBarModule,
    FooterModule,
    ContatoModule,
    HttpClientModule,
    FormsModule
]
})
export class HomeModule { }
