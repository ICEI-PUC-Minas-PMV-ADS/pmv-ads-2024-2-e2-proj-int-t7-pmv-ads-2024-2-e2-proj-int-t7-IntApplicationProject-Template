# Registro de Testes de Software

# Informações Gerais #
Data do Registro: 27 de outubro de 2024
Versão do Software: 1.0
Responsável pelo Teste: Ariane Moura

| **Registro de Teste** 	| **CT-01 – Login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir que os usuários realizem login. |
|Objetivo: | Garantir que os usuários possam realizar login. |
|Critérios de Aceitação: | Usuários devem conseguir logar. |
|Método: | Teste funcional. |
|Critérios de Aceitação: | Usuários devem conseguir logar com credenciais válidas e recuperar senhas. |
|Resultado: | Todos os usuários conseguiram realizar o login. |

| **Registro de Teste** 	| **CT-02 – Recuperação de Senha** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve fornecer uma página de recuperação de senha que permita o envio de um link de redefinição para o email do usuário cadastrado. |
|Objetivo: | Garantir que os usuários possam recuperar suas senhas. |
|Critérios de Aceitação: | Usuários devem conseguir recuperar senhas. |
|Método: | Teste funcional. |
|Resultado: | Leve dificuldade em alguns casos de recuperação. |

| **Registro de Teste** 	| **CT-03 – Gerenciamento de Usinas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - O sistema deve permitir ao administrador gerenciar informações completas sobre usinas e fontes de energia, incluindo a criação, edição, exclusão e visualização de dados de produção para cada usina. |
|Objetivo: | Verificar se todas as operações do gerenciador de usinas estão funcionando corretamente. |
|Critérios de Aceitação: | Usuários devem conseguir adicionar, editar, excluir e visualizar usinas sem erros. |
|Método: | Teste funcional. |
|Resultado: | Todos os testes foram concluídos com sucesso, foi recomendado fornecer mais opções de filtros.|

| **Registro de Teste** 	| **CT-04 – Gerenciamento Fontes de Energia** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - O sistema deve permitir ao administrador gerenciar informações completas sobre usinas e fontes de energia, incluindo a criação, edição, exclusão e visualização de dados de produção para cada usina. |
|Objetivo: | Testar as funcionalidades relacionadas ao gerenciamento das fontes de energia. |
|Critérios de Aceitação: | Usuários devem conseguir adicionar, editar, excluir e visualizar fontes de energia. |
|Método: | Teste funcional. |
|Resultado: | Todos os usuários conseguiram realizar as operações, com feedback positivo sobre a interface.|

| **Registro de Teste** 	| **CT-05 – Gerenciador de Produção de Energia** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - O sistema deve permitir ao administrador gerenciar informações completas sobre usinas e fontes de energia, incluindo a criação, edição, exclusão e visualização de dados de produção para cada usina. |
|Objetivo: | Avaliar o funcionamento do gerenciador de produção de energia. |
|Critérios de Aceitação: | Usuários devem conseguir adicionar, editar, excluir e visualizar registros de produção. |
|Resultado: | Os testes foram bem-sucedidos; todos os usuários conseguiram realizar as operações sem problemas.|

| **Registro de Teste** 	| **CT-06 – Teste de Consultas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-008 - O sistema deve fornecer recomendações de melhorias na eficiência energética com base na análise de dados registrados e desempenho atual. |
|Critérios de Aceitação: | Usuários devem conseguir realizar consultas específicas e obter resultados precisos.|
|Método: | Teste funcional. |
|Resultado: | A maioria dos usuários conseguiu realizar consultas sem dificuldades. |

| **Registro de Teste** 	| **CT-07 – Teste de Visualização** 	|
|:---:	|:---:	|
|	Requisito Associado 	|RF-006 - O sistema deve gerar relatórios detalhados e gráficos sobre o desempenho energético. |
|Objetivo: | Avaliar a clareza e a eficácia das visualizações de dados na aplicação.|
|Critérios de Aceitação: | Usuários devem conseguir visualizar dados de forma clara e compreensível.|
|Método: | Teste funcional. |
|Resultado: | Os usuários relataram uma experiência positiva, mas sugeriram melhorias na estética de alguns gráficos.|

# Avaliação/Conclusões #

Os testes de software realizados na aplicação 'EcoLogic' indicam que as funcionalidades estão funcionando conforme esperado. No entanto, foram identificadas algumas áreas para melhorias, especialmente em relação à recuperação de senha e à estética das visualizações.

Próximas Etapas:
Implementar melhorias sugeridas pelos usuários.
Repetir os testes após a implementação das melhorias para assegurar a qualidade do software.