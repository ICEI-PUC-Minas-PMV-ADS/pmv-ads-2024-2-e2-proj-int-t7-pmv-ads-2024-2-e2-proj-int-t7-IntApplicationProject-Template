export interface ObrasModel {
    idObra: number;
    nome: string;
    construtora: string;
    localizacao: string;
    descricao: string;
    dataInicio: Date;
    dataFim: Date;
    idGestor: number;
    idUsuario: number
    idUf: number;
    estaConcluido: boolean;
  }