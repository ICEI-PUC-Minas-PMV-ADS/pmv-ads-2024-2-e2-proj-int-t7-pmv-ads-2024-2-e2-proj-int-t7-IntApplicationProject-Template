import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { FooterComponent } from './footer/footer.component';
import { HomeComponent } from './pages/home/home.component';
import { MenuGestorClienteComponent } from './pages/menu-gestor-cliente/menu-gestor-cliente.component';
import { ObraAndamentoComponent } from './pages/obra-andamento/obra-andamento.component';
import { ObraFinalizadaComponent } from './pages/obra-finalizada/obra-finalizada.component';

@NgModule({
  declarations: [
    AppComponent,
    ObraFinalizadaComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
