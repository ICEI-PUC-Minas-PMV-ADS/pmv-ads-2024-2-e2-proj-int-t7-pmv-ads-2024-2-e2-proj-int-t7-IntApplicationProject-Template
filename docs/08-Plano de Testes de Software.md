# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastro na Plataforma** 	|
|:---:	|:---:	|
|	**Requisito Associado** 	| RF-01 - O sistema deve permitir o cadastro de novos usuários, incluindo gestores da obra e clientes, com a coleta de informações básicas como nome, e-mail, senha e tipo de usuário. |
| **Objetivo do Teste** 	| Validar o processo de cadastro na plataforma para os dois tipos de usuários (Gestor da Obra e Cliente da Obra), garantindo que o sistema colete e armazene as informações corretamente. |
| **Passos** 	| - Acesse a página de cadastro da plataforma. <br> - Preencha os campos obrigatórios: nome, e-mail, senha e tipo de usuário (Gestor ou Cliente).<br> - Confirme os dados e envie o formulário. <br> - Verifique a obtenção de confirmação de cadastro via e-mail. <br> - Acesse a conta recém-criada com as credenciais fornecidas. |
|**Critério de Êxito** | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| CT-02 – Login na Plataforma com Caracteres/Senhas Incorretas	|
|**Requisito Associado** | RF-02 - O sistema deve permitir que os usuários façam login utilizando suas credenciais (e-mail e senha) e devem exibir mensagens de erro caso as informações estejam incorretas ou incompletas. |
| **Objetivo do Teste** 	| Validar o sistema de login, garantindo que ele reconheça senhas incorretas ou caracteres inválidos, e que mensagens de erro sejam exibidas melhor. |
| **Passos** 	| - Acesse a página de login da plataforma. <br> - Insira um e-mail válido e uma senha incorreta. <br> - Tente fazer login e verifique a mensagem de erro. <br> - Insira um e-mail válido com caracteres especiais na senha. <br> - Tente fazer login novamente e verifique a mensagem de erro. <br> - Insira um e-mail válido e uma senha correta. <br> - Confirme que o login foi realizado com sucesso. |
| **Critério de Êxito** | - O sistema exibe mensagens de erro corretas para tentativa de login com credenciais incorretas, e o login é realizado com sucesso quando as informações corretas são inseridas. |
|  	|  	|
| **Caso de Teste** 	| CT-03 - Esqueceu a Senha - Redefinição de Senha	|
|**Requisito Associado** | RF-03 - O sistema deve permitir que o usuário solicite a redefinição de senha através de um link enviado para o e-mail cadastrado, com a capacidade de criar uma nova senha e acessar uma conta novamente. |
| **Objetivo do Teste** 	| Validar o processo de recuperação de senha, garantindo que o sistema envie corretamente o e-mail de redefinição e permita a criação de uma nova senha. |
| **Passos** 	| - Acesse a página de login da plataforma. <br> - Clique na opção "Esqueceu a Senha". <br> - Insira o e-mail cadastrado. <br> - Verifique o recebimento do e-mail com o link de redefinição de senha. <br> - Clique no link e seja direcionado para a página de criação de nova senha. <br> - Insira e confirme uma nova senha. <br> - Tente acessar uma conta com uma nova senha. |
| **Critério de Êxito** | - O usuário recebe o e-mail de redefinição de senha corretamente, é capaz de criar uma nova senha, e consegue acessar sua conta com a nova senha criada. |
|  	|  	|
| **Caso de Teste** 	| CT-04 - Cadastro de Obra - Validação de Prazo e Caracteres Especiais	|
|**Requisito Associado** | RF-04 - O sistema deve permitir o cadastro de novas obras, com informações fornecidas como nome da obra, descrição, prazo estimado e outros dados relevantes, e deve validar a inserção correta dos campos, incluindo a liberdade ou exclusão de caracteres especiais, conforme necessário. |
| **Objetivo do Teste** 	| Validar o processo de cadastro de uma obra, verificando se o sistema aceita o nome da obra, prazo estimado e outras informações, além de verificar o comportamento ao tentar inserir caracteres especiais nos campos. |
| **Passos** 	| - Acesse a área de cadastro de obras na plataforma. <br> - Preencher os campos obrigatórios como nome da obra, descrição, e prazo estimado. <br> - Inserir caracteres especiais nos campos de nome da obra e descrição. <br> - Tentar concluir o cadastro da obra. <br> - Verifique se o sistema permite ou rejeita os caracteres especiais conforme regras matemáticas. <br> - Confirme o cadastro da obra e verifique se o prazo foi registrado corretamente. |
| **Critério de Êxito** | - O sistema cadastra a obra com sucesso, aceitando ou rejeitando caracteres especiais conforme a validação, e registra corretamente o prazo estimado da obra. |
|  	|  	|
| **Caso de Teste** 	|  CT-05 - Cadastro de Etapas - Validação de Prazos e Alertas de Inconsistência	|
|**Requisito Associado** | RF-05 - O sistema deve permitir o cadastro de etapas de uma obra, incluindo a definição de prazos para cada etapa. O sistema deve gerar um alerta caso haja inconsistências entre os prazos das etapas e o prazo total da obra. |
| **Objetivo do Teste** 	| Validar o processo de cadastro de etapas e prazos dentro de uma obra, garantindo que o sistema identifique e alerte sobre possíveis inconsistências entre o prazo total da obra e os prazos das etapas. |
| **Passos** 	| - Acesse uma área de cadastro de etapas para uma obra existente. <br> - Preencha os campos obrigatórios para cadastrar uma nova etapa, incluindo nome da etapa e prazo estimado. <br> - Insira um prazo para a etapa que você está dentro do prazo total da obra. <br> - Verifique se o sistema cadastra a etapa corretamente. <br> - Tente cadastrar uma nova etapa com um prazo que exceda o prazo total da obra. <br> - Verifique se o sistema gera um alerta sobre a inconsistência do prazo. <br> - Confirme o cadastro correto das etapas e seus prazos. |
| **Critério de Êxito** | - O sistema permite o cadastro das etapas com prazos válidos, gera alertas adequados para prazos inconsistentes, e cadastra as etapas corretamente dentro dos limites estabelecidos. |
|  	|  	|
| **Caso de Teste** 	|  CT-06 - Edição de Etapas - Validação da Capacidade de Edição	|
|**Requisito Associado** | RF-06 - O sistema deve permitir que os usuários editem as etapas de uma obra após seu cadastro inicial, incluindo a possibilidade de alteração do nome, descrição e prazo de cada etapa. |
| **Objetivo do Teste** 	| Validar a funcionalidade de edição das etapas já cadastradas, garantindo que o usuário consiga alterar as informações de cada etapa e que o sistema armazene corretamente essas alterações. |
| **Passos** 	| - Acesse uma área de gerenciamento de obras e selecione uma obra existente. <br> - Localizar a etapa previamente cadastrada. <br> - Clique na opção de edição da etapa. <br> - Modifique as informações da etapa, como nome, descrição e prazo. <br> - Salvar as alterações. <br> - Verifique se o sistema atualizou os dados da etapa corretamente. <br> - Validar se as novas informações, incluindo o prazo alterado, foram refletidas no sistema. |
| **Critério de Êxito** | - O sistema permite que as etapas sejam editadas com sucesso, atualize as informações corretamente e reflita as mudanças de prazo e detalhes de forma precisa. |
|  	|  	|
| **Caso de Teste** 	|  CT-07 - Consulta de Obras - Validação do Acesso e Exibição de Informações	|
|**Requisito Associado** | RF-07 - O sistema deve permitir que os usuários consultem as obras cadastradas, exibindo todas as informações relevantes, como nome, descrição, status, etapas e prazos, de forma clara e acessível. |
| **Objetivo do Teste** 	| Validar a funcionalidade de consulta de obras, garantindo que o usuário consiga acessar uma obra específica de seu interesse e que todas as informações sobre a obra sejam exibidas corretamente. |
| **Passos** 	| - Acesse a área de consulta de obras na plataforma. <br> - Localizar uma obra específica pela lista de obras ou através da funcionalidade de busca. <br> - Clique na obra de interesse. <br> - Verifique se todas as informações relacionadas à obra, como nome, descrição, status, etapas e prazos, estão sendo exibidas corretamente. <br> - Confirme que as etapas da obra e seus prazos estão visíveis e corretamente associados à obra.  |
| **Critério de Êxito** | - O sistema permite que as etapas sejam editadas com sucesso, atualize as informações corretamente e reflita as mudanças de prazo e detalhes de forma precisa. |
|  	|  	|
| **Caso de Teste** 	|  CT-08 - Visualização da Obra - Validação de Progresso e Etapas Concluídas	|
|**Requisito Associado** | RF-08 - O sistema deve permitir que os usuários visualizem o progresso de uma obra, exibindo claramente o percentual de conclusão e quais etapas já foram finalizadas. |
| **Objetivo do Teste** 	| Validar a funcionalidade de visualização de uma obra, garantindo que o usuário possa ver o progresso total, identificar quais etapas foram concluídas e o quanto ainda falta para a conclusão total da obra. |
| **Passos** 	| - Acesse a área de consulta de obras na plataforma. <br> - Selecionar uma obra específica para visualizar. <br> - Verifique o progresso total da obra, exibido em formato percentual ou gráfico. <br> - Verifique a lista de etapas da obra.
<br> - Confirmar que as etapas já concluídas estão marcadas como finalizadas e as etapas pendentes ainda estão indicadas como em andamento. <br> - Validar que o sistema calcula corretamente o percentual de conclusão com base nas etapas finalizadas.  |
| **Critério de Êxito** | -  O usuário consegue visualizar o progresso total da obra, ver claramente as etapas finalizadas e o quanto ainda falta para a conclusão, com os dados exibidos de maneira clara e precisa. |
|  	|  	|
| **Caso de Teste** 	|  CT-09 - Verificação de Alertas Sobre Atrasos no Cronograma	|
|**Requisito Associado** | RF-09 - O sistema deve gerar alertas automáticos para o usuário em caso de atrasos nas etapas ou no cronograma geral da obra, exibindo notificações claras sobre as etapas afetadas e o impacto no prazo total da obra. |
| **Objetivo do Teste** 	| Validar a funcionalidade de alerta sobre atrasos no cronograma, garantindo que o sistema notifique os usuários de maneira clara e oportuna quando houver atrasos em etapas ou no prazo total da obra. |
| **Passos** 	| - Acessar a área de gerenciamento de obras na plataforma. <br> - Simula o atraso de uma ou mais etapas, excedendo o prazo previamente estipulado. <br> - Verifique se o sistema gera um alerta automático informando sobre o atraso nas etapas. <br> - Confirmar se o alerta inclui detalhes sobre o impacto no cronograma geral da obra. <br> - Verifique se o alerta é exibido de forma visível na interface principal do usuário. <br> - Validar se o sistema envia notificações adicionais, como por e-mail, para informar sobre o atraso. |
| **Critério de Êxito** | -  O sistema gera alertas claros e detalhados sobre atrasos nas etapas, incluindo informações sobre o impacto no prazo total da obra, e as notificações são exibidas de maneira visível e enviadas corretamente. |
|  	|  	|
| **Caso de Teste** 	|  CT-10 - Emissão de Relatório - Validação de Relatórios Simples e Complexos	|
|**Requisito Associado** | RF-10 - O sistema deve permitir a emissão de relatórios simples e complexos sobre o andamento da obra. O relatório simples deve incluir um resumo do progresso geral, enquanto o relatório complexo deve conter detalhes das etapas, prazos e indicadores de desempenho. O sistema deve disponibilizar diferentes formas de acesso aos relatórios. |
| **Objetivo do Teste** 	| Validar a funcionalidade de envio de relatórios, garantindo que o usuário possa gerar tanto relatórios simples quanto complexos e que eles sejam acessíveis por diferentes meios (download, visualização on-line, e-mail). |
| **Passos** 	| - Acesse a área de relatórios da plataforma. <br> - Selecionar a opção de gerar um relatório simples. <br> - Verifique se o relatório simples inclui um resumo do progresso geral da obra. <br> - Selecionar a opção de gerar um relatório complexo. <br> - Verifique se o relatório complexo inclui detalhes das etapas, prazos e indicadores de desempenho. <br> - Confirmar se o relatório pode ser acessado de diversas formas, como download direto, visualização online ou envio por e-mail. <br> - Validar se os relatórios são gerados corretamente e se os dados exibidos estão completos e precisos. |
| **Critério de Êxito** | -  O sistema permite o envio de relatórios simples e complexos com sucesso, e os relatórios são acessíveis de diversas formas, com todos os dados relevantes sendo exibidos corretamente. |
|  	|  	|
| **Caso de Teste** 	|  CT-11 - Emissão de Relatório - Validação de Relatórios Simples e Complexos	|
|**Requisito Associado** | RF-11 - O sistema deve permitir que os usuários entrem em contato com a equipe de suporte da plataforma por meio de um formulário de contato ou outros meios disponibilizados, como e-mail ou chat. |
| **Objetivo do Teste** 	| Validar a funcionalidade de contato com a plataforma, garantindo que o usuário consiga enviar uma mensagem de suporte ou dúvida e que o sistema encaminhe corretamente a solicitação à equipe responsável. |
| **Passos** 	| - Acesse a área de "Contato" na plataforma. <br> - Preencha o formulário de contato com nome, e-mail e mensagem. <br> - Verifique se o sistema valida os campos obrigatórios (nome, e-mail e mensagem). <br> - Envie uma mensagem e verifique se há uma confirmação de envio. <br> -  Verifique se a mensagem foi enviada corretamente e se o usuário recebe uma confirmação por e-mail. <br> - Teste outros meios de contato, como e-mail direto ou chat, se disponíveis, para garantir o funcionamento adequado. |
| **Critério de Êxito** | -  O usuário consegue enviar uma mensagem de contato com sucesso, recebe uma confirmação de envio e a plataforma encaminha corretamente uma solicitação para a equipe de suporte. |
|  	|  	|




 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
