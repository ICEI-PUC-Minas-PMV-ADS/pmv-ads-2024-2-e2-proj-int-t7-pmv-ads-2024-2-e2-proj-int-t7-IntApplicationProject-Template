import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObraEspecificaGestorComponent } from './obra-especifica-gestor.component';

describe('ObraEspecificaGestorComponent', () => {
  let component: ObraEspecificaGestorComponent;
  let fixture: ComponentFixture<ObraEspecificaGestorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ObraEspecificaGestorComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ObraEspecificaGestorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
