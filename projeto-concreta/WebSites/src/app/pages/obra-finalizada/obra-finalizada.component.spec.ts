import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObraFinalizadaComponent } from './obra-finalizada.component';

describe('ObraAndamentoComponent', () => {
  let component: ObraFinalizadaComponent;
  let fixture: ComponentFixture<ObraFinalizadaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ObraFinalizadaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ObraFinalizadaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
