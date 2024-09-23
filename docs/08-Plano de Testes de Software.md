# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
---
<!-- | **Caso de Teste** 	| **CT-01 – Registro** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-001 -  ⁠A aplicação deve permitir que os usuários realizarem o login/registro. |
| Objetivo do Teste 	| Verificar se o usuário consegue se registrar no site. |
| Passos 	| 01-Acessar a página de registro. <br> 02-Inserir um e-mail no campo _E-mail_. <br> 03-Inserir uma senha no campo _Senha_. <br> 04-Clicar em _Registrar_. |
|Critério de Êxito | Mensagem _Registro realizado com sucesso_. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Login** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-001 -  ⁠A aplicação deve permitir que os usuários realizarem o login/registro. |
| Objetivo do Teste 	| Verificar se o usuário consegue efetuar login no site. |
| Passos 	| 01-Acessar a página de login/registro. <br> 02-Inserir um e-mail no campo _E-mail_. <br> 03-Inserir uma senha no campo _Senha_. <br> 04-Clicar em _Login_. |
|Critério de Êxito | Redirecionamento para a página inicial do site. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Recuperação de Acesso** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-003 -  Na tela de login deverá ter o “esqueceu a senha?” no qual redirecionará para uma nova página para recuperação de senha. |
| Passos 	| 01-Acessar a página de login/registro. <br> 02-Clicar no link _Esqueci minha senha_. <br> 03-Inserir seu e-mail no campo _Confirme seu E-mail_. <br> 04-Clicar em _Receber código de acesso por E-mail_. |
|Critério de Êxito | Redirecionamento para uma página solicitando código de acesso recebido. Após inserir o código, direcionar para a página inicial. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Informações sobre Fontes de Energia Renovável** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-004 -  A aplicação web deve apresentar na dashboard principal informações sobre as fontes de energia renovável. |
| Passos 	| 01-Acessar a página inicial. <br> 02-Acessar a dashboard principal. <br> 03-Acessar o link _Fontes de Energia Renovável_. <br> 04-Clicar no link correspondente ao tipo de energia que o usuário quer a informação. |
|Critério de Êxito | _Mostrar a informação_. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Confirmar funcionamento dos links da página inicial** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-005 -  A aplicação web deve apresentar na dashboard principal menus de navegação. |
| Passos 	| 01-Acessar a página inicial. <br> 02-Clicar na dashboard principal. <br> 03-Clicar em cada um dos links do menu. |
|Critério de Êxito | _Redirecionar o usuário para a página correspondente_. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Usinas Cadastradas** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-006 -  O sistema deve apresentar a tela de usinas cadastradas. |
| Passos 	| 01-Acessar a página inicial. <br> 02-Clicar na dashboard principal. <br> 03-Clicar no link _Usinas_. |
|Critério de Êxito | _Redirecionar o usuário para a página de usinas, aos quais o mesmo terá acesso às principais informações sobre elas_. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – Fontes de Energia Cadastradas** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-007 -  O sistema deve apresentar a tela de fontes de energia cadastradas. |
| Passos 	| 01-Acessar a página inicial. <br> 02-Clicar na dashboard principal. <br> 03-Clicar no link _Usinas_. <br> 04-Redirecionar o usuário para a página de usinas. <br> 05-Clicar no link _Fontes de Energia_. |
|Critério de Êxito | _Mostrar as fontes de energia_. |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – Produção de Energia** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-008 -  O sistema deve apresentar a tela de produção de energia. |
| Passos 	| 01-Acessar a página inicial. <br> 02-Clicar na dashboard principal. <br> 03-Clicar no link _Usinas_. <br> 04-Redirecionar o usuário para a página de usinas. <br> 05-Clicar no link _Produção de Energia_. |
|Critério de Êxito | _Mostrar um gráfico/dados sobre a produção_. |
|  	|  	|
| **Caso de Teste** 	| **CT-09 – Relatórios** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-009 -  A aplicação web deve apresentar uma página de relatórios. |
| Passos 	| 01-Acessar a página inicial. <br> 02-Clicar na dashboard principal. <br> 03-Clicar no link _Usinas_. <br> 04-Redirecionar o usuário para a página de usinas. <br> 05-Clicar no link _Relatórios_. <br> Clicar no link _Gerar Relatórios_. |
|Critério de Êxito | Mensagem _Relatório Gerado!_ e posteriormente o mesmo sendo mostrado em tela. |
|  	|  	|
| **Caso de Teste** 	| **CT-10 – Página de Administrador** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-010 -  A aplicação web deve apresentar uma página de administrador do site. |
| Passos 	| 01-Acessar a página de login. <br> 02-Entrar com nome e senha pré-determinados. <br> 03-Redirecionamento para página inicial do administrador_.
|Critério de Êxito | Visualização da página com funcionalidades específicas do administrador. |
|  	|  	| -->
| **Caso de Teste** 	| **CT-01 – Login** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-001 -  |⁠A aplicação deve permitir que os usuários realizem login.| ALTA |
| Passos 	| 01-Acessar a Página de Login. <br> 02-Preencher os campos _E-mail_ e _Senha_ com os respectivos dados de acesso. <br> 03-Clicar no botão _Login_.
|Critério de Êxito | Mensagem _Bem-vindo_. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Recuperação de Senha** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-002 -  |A aplicação deve fornecer uma página de recuperação de senha que permita o envio de um link de redefinição para o email do usuário cadastrado.| ALTA |
| Passos 	| 01-Acessar a _Página de Login_. <br> 02-Clicar no botão _Esqueceu a senha?"_ <br> 03-Inserir o email cadastrado para receber o link de recuperação. <br> 04-Clicar no botão _Enviar link de Recuperação_.
|Critério de Êxito | Mensagem _Link de recuperação enviado para email_. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Página de Contato** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-003 -  |A aplicação deve disponibilizar uma página de contato que permita ao usuário enviar mensagens diretamente ao administrador, com campos para nome, empresa, localização, email, telefone e mensagem.| ALTA |
| Passos 	| 01-Acessar a Página de Contato. <br> 02-Preencher os campos obrigatórios. <br> 03-Clicar em _Enviar_. 
|Critério de Êxito | Mensagem _Recebemos sua solicitação de contato! Retornaremos em breve_. |
|  	|  	|
<!-- \/ VERIFICAR VIABILIDADE \/ -->
| **Caso de Teste** 	| **CT-04 – Cadastro de Clientes** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-004 -  |O administrador deve ser capaz de cadastrar novos clientes e editá-los no sistema.| ALTA |
| Passos 	| 01-O administrador deverá estar logado. <br> 02-Acessar a página _Clientes_. <br> 03-Clicar em _Cadastrar_. <br> 04-Preencher os dados do cliente. 
|Critério de Êxito | Cliente aparece cadastrado na página.  |
|  	|  	| 
| **Caso de Teste** 	| **CT-05 – Gerenciamento** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-005 -  |O sistema deve permitir ao administrador gerenciar informações completas sobre usinas e fontes de energia, incluindo a criação, edição, exclusão e visualização de dados de produção para cada usina.| ALTA |
| Passos 	| 01-O administrador deverá estar logado. <br> 02-Acessar a página _Usinas_. <br> 03-Clicar em _Adicionar Nova Usina_. <br> 04-Preencher os dados obrigatórios. <br> 05-Clicar no botão _Cadastrar_. 
|Critério de Êxito | Número de usinas cadastradas é atualizado. |
|  	|  	|
|	Requisito Associado 	| RF-005 -  |O sistema deve permitir ao administrador gerenciar informações completas sobre usinas e fontes de energia, incluindo a criação, edição, exclusão e visualização de dados de produção para cada usina.| ALTA |
| Passos 	| 01-O administrador deverá estar logado. <br> 02-Acessar a página _Fontes de Energia_. <br> 03-Clicar em _Adicionar Nova Fonte Energética_. <br> 04-Preencher os dados obrigatórios. <br> 05-Clicar no botão _Cadastrar_. 
|Critério de Êxito | Número de fontes de energia cadastradas é atualizado. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Relatórios** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-006 -  |O sistema deve gerar relatórios detalhados e gráficos sobre o desempenho energético.| ALTA |
| Passos 	| 01-O usuário deverá estar logado. <br> 02-Acessar a página _Relatórios_.
|Critério de Êxito | Relatório está visível e detalhado na página. |
|  	|  	|
<!-- \/ VERIFICAR VIABILIDADE \/ -->
| **Caso de Teste** 	| **CT-07 – Alertas** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-007 -  |O sistema deve emitir alertas e notificações em tempo real sobre acontecimentos importantes na produção, eficiência energética e outros eventos.| ALTA |
| Passos 	| 01-O usuário deverá estar logado como _Administrador_. <br> 02-Acessar a página _Produção_. <br> 03-Clicar no botão _Gerar Evento_. <br> 03-Monitorar se o alerta foi recebido.
|Critério de Êxito | Alerta recebido. |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – Melhorias** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-008 -  |O sistema deve fornecer recomendações de melhorias na eficiência energética com base na análise de dados registrados e desempenho atual.| ALTA |
| Passos 	| 01-O usuário deverá estar logado. <br> 02-Acessar a página _Produção_. <br> 03-Analisar os dados apresentados. <br> 04-Verificar as recomendações geradas.
|Critério de Êxito | Recomendações são geradas com base nos dados. |
|  	|  	|
<!-- \/ VERIFICAR VIABILIDADE \/ -->
| **Caso de Teste** 	| **CT-09 – Exportar Relatórios** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-008 -  |Permitir que clientes visualizem e exportem relatórios.| ALTA |
| Passos 	| 01-O usuário deverá estar logado. <br> 02-Acessar a página _Relatórios_. <br> 03-Clicar no botão _Exportar Relatório_. 
|Critério de Êxito | Relatório gerado em PDF. |
|  	|  	|


> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
