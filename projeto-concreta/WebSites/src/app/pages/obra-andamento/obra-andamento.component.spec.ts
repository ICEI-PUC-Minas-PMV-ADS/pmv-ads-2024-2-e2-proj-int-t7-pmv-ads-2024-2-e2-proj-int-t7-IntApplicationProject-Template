import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObraAndamentoComponent } from './obra-andamento.component';

@Component({
  selector: 'app-obra-andamento',
  templateUrl: './obra-andamento.component.html',
  styleUrls: ['./obra-andamento.component.scss']
})
export class ObraAndamentoComponent implements OnInit {

  obrasEmAndamento: any[] = [];  // Variável para armazenar as obras em andamento

  constructor(private obrasService: ObrasService) {}

  ngOnInit(): void {
    this.getObrasEmAndamento();  // Carregar as obras em andamento quando a página for carregada
  }

  // Método para buscar as obras em andamento da API
  getObrasEmAndamento(): void {
    this.obrasService.getObrasEmAndamento().subscribe(
      (data) => {
        this.obrasEmAndamento = data;  // Preenche a variável com os dados recebidos
      },
      (error) => {
        console.error('Erro ao carregar obras em andamento:', error);
      }
    );
  }
}
