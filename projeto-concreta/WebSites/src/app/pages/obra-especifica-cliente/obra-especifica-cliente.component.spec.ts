import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObraEspecificaClienteComponent } from './obra-especifica-cliente.component';

describe('ObraEspecificaClienteComponent', () => {
  let component: ObraEspecificaClienteComponent;
  let fixture: ComponentFixture<ObraEspecificaClienteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ObraEspecificaClienteComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ObraEspecificaClienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
