# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/PMV-ADS-2024-1-E1-Proj-Direcionamento-Profissional/blob/main/documentos/02-Especificação%20do%20Projeto.md"> Especificação do Projeto</a></span>, <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/PMV-ADS-2024-1-E1-Proj-Direcionamento-Profissional/blob/main/documentos/04-Projeto%20de%20Interface.md"> Projeto de Interface</a>

Os requisitos para realização dos testes de software são:
<ul><li>Site publicado na internet;</li>
<li>Banco de dados configurado e acessível;</li>
<li>Ferramenta de testes unitários e integração;</li>
<li>Navegador para testes de interface e segurança(Chrome, Firefox ou Edge);</li>
<li>Ambiente de teste configurado.</li>
</ul>

Os testes funcionais a serem realizados na aplicação são descritos a seguir.

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-01 – Cadastrar nutricionista</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-001 - Cadastrar nutricionista como usuário, através da criação de um perfil com informações pessoais gerais ligadas a sua formação.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o nutricionista consegue criar um perfil na aplicação.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o navegador. <br>
            - Informar o endereço do site. <br>
            - Visualizar a página de "Inicio". <br>
            - Clicar em "Login". <br>
            - Clicar em "Cadastre-se". <br>
            - Selecionar a opção "Nutricionista". <br>
            - Preencher informações de cadastro. <br>
            - Clicar em "Confirmar".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>Mensagem "Cadastro realizado com sucesso" e redirecionamento para a página de login.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-02 – Cadastrar paciente</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-002 - Cadastrar um paciente como usuário, com informações pessoais em geral, objetivos e dados ligados a sua saúde (IMC, altura, idade, etc.).</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o paciente consegue criar um perfil na aplicação.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o navegador. <br>
            - Informar o endereço do site. <br>
            - Visualizar a página de "Inicio". <br>
            - Clicar em "Login". <br>
            - Clicar em "Cadastre-se". <br>
            - Selecionar a opção "Paciente". <br>
            - Preencher informações de cadastro. <br>
            - Clicar em "Confirmar".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>Mensagem "Cadastro realizado com sucesso" e redirecionamento para a página de login.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-03 – Cadastrar plano alimentar</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-003 - Cadastrar um plano alimentar pelo nutricionista para seu respectivo paciente, com receitas, ingredientes, valor nutricional básico (calorias, proteínas, gorduras, etc.).</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o nutricionista consegue cadastrar um plano alimentar.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Plano Alimentar". <br>
            - Clicar em "Cadastrar novo Plano Alimentar". <br>         
            - Preencher informações para o plano alimentar<br>
            - Clicar em "Cadastrar Plano".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>O plano alimentar aparece na lista de planos associados ao paciente.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-04 – Fazer comentário sobre o plano alimentar</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-004 - Fazer comentário sobre o plano alimentar pelo paciente.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o paciente consegue comentar em seu plano alimentar.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Plano Alimentar". <br>
            - Inserir comentário no campo específico. <br>
            - Clicar em "Enviar Comentário".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>Comentário aparece abaixo do plano alimentar e é visível para o nutricionista.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-05 – Fazer modificações no plano alimentar</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-005 - Fazer modificações no plano alimentar do paciente pelo nutricionista.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o nutricionista pode modificar o plano alimentar do paciente.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Plano Alimentar". <br>
            - Clicar em na ferramenta de "Editar Plano". <br>
            - Alterar detalhes da dieta (por exemplo, substituindo alimentos ou ajustando calorias). <br>
            - Salvar as modificações.
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>O plano alimentar é atualizado com sucesso, e o paciente visualiza as alterações.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-06 – Registrar diário alimentar</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-006 - Registrar o diário alimentar do paciente.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o paciente consegue registrar suas refeições no diário alimentar.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Diário Alimentar". <br>
            - Inserir detalhes da refeição (horário, ingredientes, calorias). <br>
            - Clicar em "Enviar".
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>A refeição aparece registrada no diário do paciente.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-07 – Propor dicas de receitas</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-007 - Propor dicas de receitas por nutricionistas e pacientes.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se nutricionistas e pacientes conseguem propor dicas de receitas.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Receitas". <br>
            - Clicar em "Cadastrar nova Receita". <br>
            - Preencher as informações da receita. <br>
            - Clicar em "Cadastrar Receita". <br>
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>A nova receita proposta é exibida na lista de dicas para outros usuários.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-08 – Registrar perda de peso do paciente e exibir histórico</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-008 - Registrar perda de peso do paciente ao longo do tempo e exibir o histórico desta informação.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o sistema permite registrar a perda de peso do paciente e exibe o histórico.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Meu Perfil". <br>
            - Inserir informações do "Histórico de Peso"
            - Clicar em "Adicionar". <br>
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>O peso é registrado corretamente, e o histórico é exibido com os dados passados.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-09 – Avaliar as receitas</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-009 - Avaliar as receitas propostas (like ou joinha).</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o paciente ou nutricionista pode avaliar as receitas propostas com um like ou joinha.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Receitas". <br>
            - Selecionar uma receita da lista. <br>
            - Clicar no ícone de "Coração". <br>
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>A avaliação (like ou joinha) é registrada corretamente e o número de avaliações é atualizado.</td>
    </tr>
</table>

<br>

<table>
    <tr>
        <th><strong>Caso de Teste</strong></th>
        <th><strong>CT-10 – Calcular IMC</strong></th>
    </tr>
    <tr>
        <td><strong>Requisito Associado</strong></td>
        <td>RF-010 - Calcular índice de massa corpórea para o usuário nutricionista.</td>
    </tr>
    <tr>
        <td><strong>Objetivo do Teste</strong></td>
        <td>Verificar se o sistema calcula o índice de massa corpórea (IMC) corretamente com base no peso e altura informados.</td>
    </tr>
    <tr>
        <td><strong>Passos</strong></td>
        <td>
            - Acessar o menu "Meu Perfil". <br>
            - Inserir informações do "IMC"
            - Clicar em "Calcularr". <br>
        </td>
    </tr>
    <tr>
        <td><strong>Critério de Êxito</strong></td>
        <td>O IMC é calculado corretamente.</td>
    </tr>
</table>
