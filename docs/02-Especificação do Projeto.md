# Especificações do Projeto
<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>
<div align="justify">
A partir da documentação de contexto, passará a se definir o problema e a idéia de solução com base no usuário. Para isso, será definido abaixo o diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais, além das restrições do projeto. 
 <br/>
</div>

## Personas
<div align="justify">
 
**Persona 1 - Engenheiro civil:**
<br/><br/>
<div  align="center">
 
![image](https://github.com/user-attachments/assets/0196483c-e935-430c-a48d-bb0944316720)
</div>
<br/><br/>

**Persona 2 - Proprietária de imóvel:**
<br/><br/>
<div  align="center">

![image](https://github.com/user-attachments/assets/0195bff1-9679-44df-8151-c6459df60df5)

</div>
<br/><br/>

**Persona 3 - Gestor de obras:**
<br/><br/>
<div  align="center">

![image](https://github.com/user-attachments/assets/71d436a9-6ffd-4853-8a47-cc6a24a1061b)

</div>
<br/><br/>

## Histórias de Usuários
<div align="justify">

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Engenheiro Civil  | Usar a ferramenta para monitorar em tempo real o progresso de cada etapa da obra que estou gerenciando, com acesso detalhado ao progresso percentual de cada tarefa e aos recursos alocados.           | dentificar rapidamente quaisquer desvios do cronograma, ajustar as operações de forma ágil, otimizar recursos e garantir que os prazos acordados com os clientes sejam cumpridos, minimizando riscos de atrasos e assegurando a satisfação do cliente e a rentabilidade do projeto.               |
|Proprietária de imóveis.    | Usar a ferramenta para acompanhar remotamente o progresso detalhado de cada fase da reforma, visualizando o progresso percentual e recebendo atualizações semanais com fotos em alta resolução.                 | er uma visão clara e confiável do andamento dos trabalhos, ser notificada sobre problemas ou atrasos, e garantir que a reforma esteja sendo conduzida conforme planejado, mantendo o estilo e integridade do imóvel, e assegurando a conclusão do projeto dentro do cronograma. |
|Gestor de Obras   | De uma ferramenta que forneça atualizações semanais detalhadas sobre o andamento de cada projeto, com gráficos de progresso, índices de desempenho, e alertas para áreas problemáticas.                 | Identificar riscos de retrabalho, mitigar problemas, ajustar a alocação de recursos, e assegurar que todos os projetos sejam entregues dentro do prazo e do orçamento previsto, mantendo a qualidade e eficiência e garantindo a comunicação eficaz com as equipes e clientes. |
|Gestor de Obras   | Monitorar o progresso de cada etapa das obras em tempo real                 | Identificar rapidamente o status das tarefas (no prazo, atrasadas ou concluídas) e garantir a entrega dentro do prazo e do orçamento. |
|Supervisor de Obras   | Ajustar rapidamente as operações com base nas informações em tempo real.                 | Evitar atrasos e garantir que a obra continue avançando de maneira eficiente. |
|Clientes   | Acompanhar o progresso percentual das etapas da obra e receber fotos atualizadas da execução.                 | Ter uma visão clara do andamento e tranquilidade sem precisar estar presente fisicamente no local. |
|Arquiteta   | Receber notificações automáticas sobre mudanças no cronograma.                 | Ajustar o planejamento e garantir que o projeto se mantenha dentro dos prazos estabelecidos. |
|Engenheira de Controle de Qualidade   | Obter relatórios detalhados com indicadores de desempenho.                 | ealizar uma análise aprofundada da qualidade da execução e implementar melhorias contínuas no processo. |
|Gerente de Projetos   | Preciso que o sistema integre dados de diferentes fontes e facilite a comunicação entre todos os envolvidos no projeto.                 | Garantir uma colaboração eficiente e execução harmoniosa do projeto, minimizando mal-entendidos e atrasos.. |


Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

## Requisitos
<div align="justify">
As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.
<br/>
</div>

### Requisitos Funcionais

| ID    | Descrição do Requisito                                                                                                                                                           | Prioridade |
|-------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RF-01 | O sistema deve permitir aos gestores das obras monitorarem o progresso em tempo real de cada etapa da obra, exibindo o progresso percentual de cada tarefa.                        | ALTA       |
| RF-02 | O sistema deve permitir o cadastro de usuarios.     | ALTA       |
| RF-03 | O sistema deve permitir ajustes rápidos nas operações com base nas informações em tempo real, evitando atrasos e garantindo o andamento eficiente da obra.                       | ALTA       |
| RF-04 | O sistema deve oferecer funcionalidades de controle de custos para arquitetos, permitindo o acompanhamento do orçamento durante a execução da obra.                               | MÉDIA      |
| RF-05 | O sistema deve permitir o login e acesso de usuarios                                               | MÉDIA      |
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
<div align="justify">
Através do modelo gráfico, segue as relações de casos de uso e dos atores,  com o detalhamento dos requisitos funcionais e sua associação e relacionamento com os atores. 
<br/><br/>
<div  align="center">
 
![Diagrama de caso de uso](https://github.com/user-attachments/assets/10794817-4701-4c87-9d9a-128acab881c5)

</div>
<br/><br/>
