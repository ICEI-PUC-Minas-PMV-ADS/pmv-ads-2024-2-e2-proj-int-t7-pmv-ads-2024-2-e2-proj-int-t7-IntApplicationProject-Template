interface ObraResponse {
    mensagem: string;
    id: number;
    obraDto: {
      idObra: number;
      nome: string;
      construtora: string;
      localizacao: string;
      descricao: string;
      dataInicio: string;
      dataFim: string;
      idGestor: number;
      idUf: number;
      estaConcluido: boolean;
      idUsuario: number;
    };
  }
  