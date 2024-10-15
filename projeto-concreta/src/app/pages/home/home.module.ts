import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { NavbarComponent } from '../../navbar/navbar.component';
import { NavBarModule } from '../../navbar/navbar.module';
import { FooterModule } from "../../footer/footer.module";



@NgModule({
  declarations: [HomeComponent],
  imports: [
    CommonModule,
    HomeRoutingModule,
    NavBarModule,
    FooterModule,
]
})
export class HomeModule { }
