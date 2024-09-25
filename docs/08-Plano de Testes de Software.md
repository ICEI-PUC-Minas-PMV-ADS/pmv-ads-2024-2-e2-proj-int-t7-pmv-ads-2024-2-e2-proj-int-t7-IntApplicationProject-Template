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

| **Caso de Teste**          | **CT-01 – Login** |
|:---:                       |:---:              |
| Requisito Associado     | RF-001 - A aplicação deve permitir que os usuários realizem login. |
| Objetivo do Teste       | Verificar se o usuário consegue realizar login na aplicação. |
| Passos                 | 01-Acessar a Página de Login. <br> 02-Preencher os campos _E-mail_ e _Senha_ com os respectivos dados de acesso. <br> 03-Clicar no botão _Login_. |
| Critério de Êxito       | - Mensagem _Bem-vindo_. |

| **Caso de Teste**          | **CT-02 – Recuperação de Senha** |
|:---:                       |:---:                             |
| Requisito Associado     | RF-002 - A aplicação deve fornecer uma página de recuperação de senha que permita o envio de um link de redefinição para o email do usuário cadastrado. |
| Objetivo do Teste       | Verificar se o usuário consegue solicitar a recuperação de senha. |
| Passos                 | 01-Acessar a _Página de Login_. <br> 02-Clicar no botão _"Esqueceu a senha?"_ <br> 03-Inserir o email cadastrado para receber o link de recuperação. <br> 04-Clicar no botão _Enviar link de Recuperação_. |
| Critério de Êxito       | - Mensagem _Link de recuperação enviado para email_. |

| **Caso de Teste**          | **CT-03 – Página de Contato** |
|:---:                       |:---:                          |
| Requisito Associado     | RF-003 - A aplicação deve disponibilizar uma página de contato que permita ao usuário enviar mensagens diretamente ao administrador, com campos para nome, empresa, localização, email, telefone e mensagem. |
| Objetivo do Teste       | Verificar se o usuário consegue enviar uma mensagem de contato. |
| Passos                 | 01-Acessar a Página de Contato. <br> 02-Preencher os campos obrigatórios. <br> 03-Clicar em _Enviar_. |
| Critério de Êxito       | - Mensagem _Recebemos sua solicitação de contato! Retornaremos em breve_. |

| **Caso de Teste**          | **CT-04 – Cadastro de Clientes** |
|:---:                       |:---:                             |
| Requisito Associado     | RF-004 - O administrador deve ser capaz de cadastrar novos clientes e editá-los no sistema. |
| Objetivo do Teste       | Verificar se o administrador consegue cadastrar clientes no sistema. |
| Passos                 | 01-O administrador deverá estar logado. <br> 02-Acessar a página _Clientes_. <br> 03-Clicar em _Adicionar Cliente_. <br> 04-Preencher os dados do cliente. <br> 05-Clicar em _Cadastrar_. |
| Critério de Êxito       | - Cliente aparece cadastrado na página. |

| **Caso de Teste**          | **CT-05 – Gerenciamento Usinas** |
|:---:                       |:---:                             |
| Requisito Associado     | RF-005 - O sistema deve permitir ao administrador gerenciar informações completas sobre usinas e fontes de energia, incluindo a criação, edição, exclusão e visualização de dados de produção para cada usina. |
| Objetivo do Teste       | Verificar se o administrador consegue gerenciar usinas no sistema. |
| Passos                 | 01-O administrador deverá estar logado. <br> 02-Acessar a página _Usinas_. <br> 03-Clicar em _Adicionar Nova Usina_. <br> 04-Preencher os dados obrigatórios. <br> 05-Clicar no botão _Cadastrar_. |
| Critério de Êxito       | - Número de usinas cadastradas é atualizado. |

| **Caso de Teste**          | **CT-06 – Gerenciamento Fontes de Energia** |
|:---:                       |:---:                                        |
| Requisito Associado     | RF-005 - O sistema deve permitir ao administrador gerenciar informações completas sobre usinas e fontes de energia, incluindo a criação, edição, exclusão e visualização de dados de produção para cada usina. |
| Objetivo do Teste       | Verificar se o administrador consegue gerenciar fontes de energia no sistema. |
| Passos                 | 01-O administrador deverá estar logado. <br> 02-Acessar a página _Fontes de Energia_. <br> 03-Clicar em _Adicionar Nova Fonte Energética_. <br> 04-Preencher os dados obrigatórios. <br> 05-Clicar no botão _Cadastrar_. |
| Critério de Êxito       | - Número de fontes de energia cadastradas é atualizado. |

| **Caso de Teste**          | **CT-07 – Relatórios** |
|:---:                       |:---:                   |
| Requisito Associado     | RF-006 - O sistema deve gerar relatórios detalhados e gráficos sobre o desempenho energético. |
| Objetivo do Teste       | Verificar se o usuário consegue visualizar os relatórios gerados. |
| Passos                 | 01-O usuário deverá estar logado. <br> 02-Acessar a página _Relatórios_. |
| Critério de Êxito       | - Relatório está visível e detalhado na página. |

| **Caso de Teste**          | **CT-08 – Alertas** |
|:---:                       |:---:                |
| Requisito Associado     | RF-007 - O sistema deve emitir alertas e notificações em tempo real sobre acontecimentos importantes na produção, eficiência energética e outros eventos. |
| Objetivo do Teste       | Verificar se o administrador recebe alertas gerados no sistema. |
| Passos                 | 01-O usuário deverá estar logado como _Administrador_. <br> 02-Acessar a página _Produção_. <br> 03-Clicar no botão _Gerar Evento_. <br> 04-Monitorar se o alerta foi recebido. |
| Critério de Êxito       | - Alerta recebido. |

| **Caso de Teste**          | **CT-09 – Melhorias** |
|:---:                       |:---:                  |
| Requisito Associado     | RF-008 - O sistema deve fornecer recomendações de melhorias na eficiência energética com base na análise de dados registrados e desempenho atual. |
| Objetivo do Teste       | Verificar se o sistema gera recomendações de melhorias com base nos dados. |
| Passos                 | 01-O usuário deverá estar logado. <br> 02-Acessar a página _Produção_. <br> 03-Analisar os dados apresentados. <br> 04-Verificar as recomendações geradas. |
| Critério de Êxito       | - Recomendações são geradas com base nos dados. |

| **Caso de Teste**          | **CT-10 – Exportar Relatórios** |
|:---:                       |:---:                            |
| Requisito Associado     | RF-008 - Permitir que clientes visualizem e exportem relatórios. |
| Objetivo do Teste       | Verificar se o usuário consegue exportar relatórios do sistema. |
| Passos                 | 01-O usuário deverá estar logado. <br> 02-Acessar a página _Relatórios_. <br> 03-Clicar no botão _Exportar Relatório_. |
| Critério de Êxito       | - Relatório gerado em PDF. |

> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
