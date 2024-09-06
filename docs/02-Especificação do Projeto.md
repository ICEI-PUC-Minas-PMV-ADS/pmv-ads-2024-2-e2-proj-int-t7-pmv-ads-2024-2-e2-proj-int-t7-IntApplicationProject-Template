# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Nesta seção, será apresentada a solução e a definição detalhada do problema que a aplicação visa resolver, a partir da perspectiva dos usuários. O objetivo é garantir que o Sistema de Gerenciamento de Produção de Energia Renovável (EcoLogic) seja desenvolvido com base em necessidades reais e específicas de seus usuários, promovendo uma experiência eficiente e intuitiva.

<br/><br/>

## Personas


<p align="center">
  <img src= "../docs/img/persona1.png" width="1000">
</p>
<h4 align="center">FIGURA 01</h4>

<br/><br/>

<p align="center">
  <img src= "../docs/img/persona2.png" width="1000">
</p>
<h4 align="center">FIGURA 02</h4>

<br/><br/>

<p align="center">
  <img src= "../docs/img/persona3.png" width="1000">
</p>
<h4 align="center">FIGURA 03</h4>

<br/><br/>

<p align="center">
  <img src= "../docs/img/persona4.png" width="1000">
</p>
<h4 align="center">FIGURA 04</h4>

<br/><br/>

<p align="center">
  <img src= "../docs/img/persona5.png" width="1000">
</p>
<h4 align="center">FIGURA 05</h4>

<br/><br/>

## Histórias de Usuários

Com base na análise das personas foram identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Bernardo (Gestor de Usinas de Energia)|Preciso monitorar em tempo real a produção de energia em várias usinas e acessar relatórios detalhados de desempenho e também quero a capacidade de comparar o desempenho entre as usinas e identificar rapidamente quaisquer desvios nos parâmetros operacionais.|Para garantir que todas as operações estejam otimizadas e em conformidade com as regulamentações.|
|Patricia (Analista de Sustentabilidade)|Preciso acessar dados atualizados sobre a produção de energia de fontes renováveis e ter acesso a ferramentas que permitam filtrar e analisar esses dados.|Para criar relatórios detalhados sobre o impacto ambiental das operações e sugerir melhorias, garantindo que a empresa esteja alinhada com suas metas de sustentabilidade.|
|Jorge (Operador de Usina)|Quero ter acesso rápido e confiável a dados operacionais diários, receber alertas em tempo real sobre qualquer anomalia e poder visualizar os dados de produção em um painel de controle intuitivo que o ajude a garantir que a produção esteja sempre dentro dos parâmetros estabelecidos.|Para monitorar as operações e identificar falhas imediatamente.|
|Carlos (Investidor em Energia Renovável)|Preciso acessar relatórios financeiros claros e dados sobre o desempenho das usinas nas quais investi e quero visualizar comparações entre diferentes fontes de energia.|Para tomar decisões mais informadas sobre futuros investimentos.|
|Tereza (Consultora de Energia)|Preciso de acesso a ferramentas que permitam a análise de dados de produção de energia e a previsão de tendências.|Para ajudar seus clientes a migrar para fontes renováveis e sugerir tecnologias e práticas que melhorem a eficiência energética.|

<br/><br/>

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário avalie uma agência de intercâmbio com base na sua experiência| ALTA | 
|RF-002| A aplicação deve permitir que o usuário inclua comentários ao fazer uma avaliação de uma agência de intercâmbio    | ALTA |
|RF-003| A aplicação deve permitir que o usuário consulte todas as agências de intercâmbio cadastradas ordenando-as com base em suas notas | ALTA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

<br/><br/>

> **Ferramentas utilizadas para o desenvolvimento das Especificações do Projeto**:
> - Site: https://br.hubspot.com/make-my-persona
> - Site: https://app.diagrams.net/
