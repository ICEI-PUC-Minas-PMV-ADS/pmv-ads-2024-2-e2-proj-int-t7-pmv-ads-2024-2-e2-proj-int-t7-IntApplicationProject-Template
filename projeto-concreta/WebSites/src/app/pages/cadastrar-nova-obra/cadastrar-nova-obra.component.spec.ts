import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastrarNovaObraComponent } from './cadastrar-nova-obra.component';

describe('CadastrarNovaObraComponent', () => {
  let component: CadastrarNovaObraComponent;
  let fixture: ComponentFixture<CadastrarNovaObraComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CadastrarNovaObraComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CadastrarNovaObraComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
