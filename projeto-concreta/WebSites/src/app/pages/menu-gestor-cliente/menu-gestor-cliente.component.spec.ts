import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuGestorClienteComponent } from './menu-gestor-cliente.component';

describe('MenuGestorClienteComponent', () => {
  let component: MenuGestorClienteComponent;
  let fixture: ComponentFixture<MenuGestorClienteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MenuGestorClienteComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MenuGestorClienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
