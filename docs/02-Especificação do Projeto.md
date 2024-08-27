# Especificações do Projeto
<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>
<div align="justify">
A partir da documentação de contexto, passará a se definir o problema e a idéia de solução com base no usuário. Para isso, será definido abaixo o diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais, além das restrições do projeto. 
 <br/>
</div>

## Personas

Identifique, em torno de, 5 personas. Para cada persona, lembre-se de descrever suas angústicas, frustrações e expectativas de vida relacionadas ao problema. Além disso, defina uma "aparência" para a persona. Para isso, você poderá utilizar sites como [https://this-person-does-not-exist.com/pt#google_vignette](https://this-person-does-not-exist.com/pt) ou https://thispersondoesnotexist.com/ 

Utilize também como referência o exemplo abaixo:

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/AnaClara1.png" alt="Persona1"/>

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> 
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Ana Clara  | Uma forma de identificar se uma agência é realmente confiável           | Me sentir mais segura ao contratar seus serviços               |
|Ana Clara       | Ter um mecanismo eficiente e rápido de comunicação                 | Que eu possa sanar todas as minhas dúvidas rapidamente |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos
<div align="justify">
As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.
<br/>
</div>

### Requisitos Funcionais

| ID    | Descrição do Requisito                                                                                                                                                           | Prioridade |
|-------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RF-01 | O sistema deve permitir aos gestores das obras monitorarem o progresso em tempo real de cada etapa da obra, exibindo o progresso percentual de cada tarefa.                        | ALTA       |
| RF-02 | O sistema deve permitir a visualização dos recursos alocados a cada tarefa, como materiais e mão de obra, para facilitar o gerenciamento eficiente dos recursos disponíveis.     | ALTA       |
| RF-03 | O sistema deve permitir ajustes rápidos nas operações com base nas informações em tempo real, evitando atrasos e garantindo o andamento eficiente da obra.                       | ALTA       |
| RF-04 | O sistema deve oferecer funcionalidades de controle de custos para arquitetos, permitindo o acompanhamento do orçamento durante a execução da obra.                               | MÉDIA      |
| RF-05 | O sistema deve permitir a gestão eficiente de recursos durante todo o processo de construção, incluindo materiais e mão de obra.                                                 | MÉDIA      |
| RF-06 | O sistema deve enviar notificações automáticas sobre mudanças no cronograma para os arquitetos, garantindo que o projeto se mantenha dentro dos prazos estabelecidos.            | MÉDIA      |
| RF-07 | O sistema deve fornecer atualizações semanais para gestores de obras, incluindo gráficos de progresso, índices de desempenho, e avaliação da eficiência do trabalho.              | MÉDIA      |
| RF-08 | O sistema deve permitir a identificação de áreas que necessitam de melhorias e a detecção de riscos de retrabalho.                                                                  | MÉDIA      |
| RF-09 | O sistema deve permitir aos clientes acompanhar o progresso percentual das etapas da obra, proporcionando um acompanhamento detalhado do desenvolvimento do projeto.               | BAIXA      |
| RF-10 | O sistema deve permitir o envio de fotos atualizadas da execução da obra para os clientes, permitindo uma visão clara do andamento sem a necessidade de presença física no local. | BAIXA      |
| RF-11 | O sistema deve permitir o acompanhamento remoto do desenvolvimento da reforma pelos clientes, oferecendo uma experiência conveniente e eficaz.                                   | BAIXA      |
| RF-12 | O sistema deve enviar alertas instantâneos para engenheiros de controle de qualidade sobre qualquer desvio de padrão ou erro detectado durante a execução da obra.                 | ALTA       |
| RF-13 | O sistema deve fornecer relatórios detalhados com indicadores de desempenho para engenheiros de controle de qualidade, permitindo uma análise aprofundada da qualidade da execução. | MÉDIA      |
| RF-14 | O sistema deve permitir a minimização de retrabalhos, permitindo que engenheiros de controle de qualidade ajam rapidamente para garantir a qualidade em todos os estágios da obra. | ALTA       |
| RF-15 | O sistema deve integrar dados de diferentes fontes e facilitar a comunicação entre todos os envolvidos no projeto, incluindo engenheiros, arquitetos, gestores de obras, clientes e engenheiros de controle de qualidade. | MÉDIA      |

### Requisitos Não Funcionais

| ID     | Descrição do Requisito                                                                                                                                                           | Prioridade |
|--------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RNF-01 | O sistema deve ser capaz de processar e exibir as informações em tempo real sem causar lentidão, suportando até 500 usuários simultâneos sem perda de performance.                | ALTA       |
| RNF-02 | Todas as informações sensíveis, como dados de projetos e credenciais dos usuários, devem ser armazenadas e transmitidas de forma criptografada, garantindo a confidencialidade e integridade dos dados. | ALTA       |
| RNF-03 | A interface do sistema deve ser intuitiva e fácil de usar, permitindo que os diferentes perfis de usuários (engenheiros, arquitetos, gestores, clientes) possam navegar e realizar suas tarefas sem dificuldades. | ALTA       |
| RNF-04 | O sistema deve ser compatível com os principais navegadores do mercado, como Google Chrome, Firefox e Microsoft Edge, garantindo uma experiência consistente em todas as plataformas. | MÉDIA      |
| RNF-05 | O sistema deve ser responsivo, adaptando-se automaticamente a diferentes tamanhos de tela, incluindo desktops, tablets e smartphones, sem comprometer a usabilidade ou a apresentação dos dados. | MÉDIA      |
| RNF-06 | O sistema deve permitir o download de relatórios e documentos em formatos PDF e HTML, garantindo que esses arquivos sejam gerados de forma rápida e acessível para os usuários. | MÉDIA      |
| RNF-07 | O tempo de resposta do sistema deve ser inferior a 3 segundos para todas as operações, assegurando uma experiência ágil para os usuários.                                           | ALTA       |
| RNF-08 | O sistema deve ter um suporte técnico acessível por chat e e-mail, disponível durante o horário comercial para resolver qualquer problema que possa surgir.                         | MÉDIA      |
| RNF-09 | O sistema deve ter um plano de contingência em caso de falha, incluindo backups regulares e procedimentos para recuperação rápida dos dados, minimizando o impacto de possíveis problemas técnicos. | ALTA       |
| RNF-10 | O sistema deve ser escalável, permitindo a adição de novos módulos e funcionalidades sem comprometer a performance existente.                                                     | MÉDIA      |
</div>

## Restrições
<div align="justify">
O projeto está restrito pelos itens apresentados na tabela a seguir.
<br/><br/>

|ID   | Restrição                                                |
|-----|-------------------------------------------------------|
|RE-01| A equipe deve realizar todas as etapas do projeto de forma colaborativa, garantindo que todos os membros participem ativamente das decisões e do desenvolvimento das tarefas.|
|RE-02| Todo o conteúdo utilizado no site deve ser original ou de fontes de domínio público, sem violação de direitos autorais.|
|RE-03| O projeto deve ser desenvolvido utilizando ferramentas e softwares acessíveis gratuitamente ou com licenças acadêmicas, garantindo a viabilidade do uso por todos os integrantes da equipe.|
|RE-04|  Cada integrante da equipe ficará responsável pelo desenvolvimento (Back-End e Front-End) das funcionalidades pelas quais ficou responsável.|
|RE-05| O site não pode conter conteúdos de caráter ofensivo, discriminatório ou que viole o código de ética da instituição.|

<br/>
</div>

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
