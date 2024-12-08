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
 
![image](https://github.com/user-attachments/assets/25e2002e-e9ed-4852-81f5-d33d6689a40d)

</div>
<br/><br/>

**Persona 2 - Proprietária de imóvel:**
<br/><br/>
<div  align="center">

![image](https://github.com/user-attachments/assets/1feb95d8-47cd-4767-9804-ee98f5bcd71b)

</div>
<br/><br/>

**Persona 3 - Gestor de obras:**
<br/><br/>
<div  align="center">

![image](https://github.com/user-attachments/assets/20ab2afc-ea31-4d05-ae07-ac262dbf20da)

</div>
<br/><br/>

## Histórias de Usuários
<div align="justify">

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... | QUERO/PRECISO ...  |PARA ...     |
|--------------------|------------------------------------|----------------------------------------|
|Engenheiro Civil  | Usar a ferramenta para monitorar em tempo real o progresso de cada etapa da obra que estou gerenciando, com acesso detalhado ao progresso percentual de cada tarefa.          | Identificar quaisquer desvios do cronograma, ajustar as operações de forma ágil, garantir que os prazos acordados com os clientes sejam cumpridos, minimizando riscos de atrasos e assegurando a satisfação do cliente e a rentabilidade do projeto.               |
|Cliente/proprietário do imóvel.    | Usar a ferramenta para acompanhar remotamente o progresso detalhado de cada fase da reforma, visualizando o progresso percentual e recebendo atualizações em forma de relatórios gerais ou detalhados com fotos.           | Ter uma visão clara e confiável do andamento dos trabalhos, ter acesso às informações sobre eventuais atrasos, e garantir que a reforma esteja sendo conduzida conforme planejado, mantendo o estilo e integridade do imóvel, e assegurando a conclusão do projeto dentro do cronograma. |
|Gestor de Obras   | Que meu usuário cadastrado seja capaz de inserir e editar obras permitindo o monitoramento e ajustes do progresso em cada etapa. Também quero esclarecer dúvidas com a plataforma sobre cadastros de obras e etapas. | Identificar  o status das tarefas (no prazo, atrasadas ou concluídas), evitando atrasos e garantindo a entrega dentro do prazo. |
|Gerente de Projetos   | Preciso que o sistema integre dados e permita o acompanhamento das obras que tenho interesse          | Garantir uma colaboração eficiente e execução harmoniosa do projeto, minimizando mal-entendidos e atrasos.. |


## Requisitos
<div align="justify">
As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.
<br/>
</div>

### Requisitos Funcionais

| ID    | Descrição do Requisito                                                                                                                                                           | Prioridade |
|-------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RF-01 | Permitir o cadastro e login de usuarios. | ALTA  |
| RF-02 | Possibilitar ajustes rápidos nas operações com base nas informações em tempo real, evitando atrasos e garantindo o andamento eficiente da obra.  | ALTA  |
| RF-03 | Permitir aos gestores das obras monitorarem o progresso em tempo real de cada etapa da obra, exibindo o progresso de cada tarefa.   | ALTA     |
| RF-04 | Enviar notificações automáticas sobre mudanças nos cronogramas, garantindo que o projeto se mantenha dentro dos prazos estabelecidos. | MÉDIA   |
| RF-05 | Possibilitar aos clientes acompanhar o progresso das etapas da obra. | MEDIA  |
| RF- 06 | Enviar alertas para gestores sobre atrasos e inconsistências de prazos.  | ALTA  |
| RF-07 | Fornecer relatórios detalhados permitindo uma análise aprofundada da qualidade da execução. | MÉDIA      |
| RF-08 | Integrar dados cadastrados pelo usuário gestor aos clientes que desejam acompanhar | ALTA    |
| RF-09 | Permitir que o usuário entre em contato com a plataforma. | MÉDIA    |

### Requisitos Não Funcionais

| ID     | Descrição do Requisito                                                                                                                                                           | Prioridade |
|--------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RNF-01 | O sistema deve ser capaz de processar e exibir as informações em tempo real sem causar lentidão.               | ALTA  |
| RNF-02 | Todas as informações sensíveis, como dados de projetos e credenciais dos usuários, devem ser armazenadas, garantindo a confidencialidade e integridade dos dados. | ALTA   |
| RNF-03 | A interface do sistema deve ser intuitiva e fácil de usar, permitindo que os diferentes perfis de usuários (engenheiros, arquitetos, gestores, clientes) possam navegar e realizar suas tarefas sem dificuldades. | ALTA       |
| RNF-04 | O sistema deve ser compatível com os principais navegadores do mercado, como Google Chrome, Firefox e Microsoft Edge, garantindo uma experiência consistente em todas as plataformas. | MÉDIA      |
| RNF-05 | O sistema deve ser responsivo, adaptando-se automaticamente a diferentes tamanhos de tela, incluindo desktops, tablets e smartphones, sem comprometer a usabilidade ou a apresentação dos dados. | MÉDIA      |
| RNF-06 |  Permitir o download de relatórios e documentos em formatos PDF e HTML, garantindo que esses arquivos sejam gerados de forma rápida e acessível para os usuários. | MÉDIA      |
| RNF-07 |  Ter um plano de contingência em caso de falha, incluindo backups regulares e procedimentos para recuperação rápida dos dados, minimizando o impacto de possíveis problemas técnicos. | BAIXA      |
| RNF-08 | O sistema deve ser escalável, permitindo a adição de novos módulos e funcionalidades sem comprometer a performance existente.                                                     | MÉDIA      |
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
 
![Diagrama de caso de uso (1)](https://github.com/user-attachments/assets/0d88d7c6-53c5-4658-ae85-ec1e84659e7f)


</div>
<br/><br/>
