import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObraAndamentoComponent } from './obra-andamento.component';

describe('ObraAndamentoComponent', () => {
  let component: ObraAndamentoComponent;
  let fixture: ComponentFixture<ObraAndamentoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ObraAndamentoComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ObraAndamentoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
