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
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
 <tr>
  <td>CT-01: Testar inserção e recuperação de dados do(a) Nutricionista.
  </td>
  <td>
   <ul>
    <li>RF-01: A aplicação deve permitir o cadastro e recuperação de dados de Nutricionista.
    </li>
   </ul>
  </td>
  <td>Verificar a inserção e recuperação dos dados de um nutricionista.
  </td>
  <td>
   <ol>
    <li>Inserir um novo nutricionista no sistema.</li>
    <li>Recuperar os dados do nutricionista cadastrado.</li>
    <li>Comparar os dados inseridos com os recuperados.</li>
   </ol>
  </td>
  <td>Os dados devem ser idênticos aos inseridos.
  </td>
  <td>XXXXXXXXXXXXXXXXXXXXX
  </td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
 <tr>
  <td>CT-02: Testar o cadastro de um novo paciente pelo nutricionista.
  </td>
  <td>
   <ul>
    <li>RF-02:A aplicação deve permitir que o nutricionista cadastre um novo paciente fornecendo e-mail, CPF e um código de convite.
    </li>
    <li>RF-02:O paciente poderá usar o código de convite para completar seu cadastro na base de dados.
    </li>
   </ul>
  </td>
  <td>Verificar se o nutricionista consegue cadastrar um novo paciente fornecendo e-mail, CPF e código de convite, e se o paciente pode usar essas informações para se cadastrar na base de dados.
  </td>
  <td>
   <ol>
    <li>Autenticar o nutricionista no sistema.</li>
    <li>Acessar a funcionalidade de cadastro de novo paciente.</li>
    <li>Inserir os dados do paciente: e-mail, CPF e gerar um código de convite.</li>
    <li>Submeter o formulário de cadastro.</li>
    <li>Verificar se o sistema registra o paciente provisoriamente e envia o código de convite por e-mail.</li>
    <li>Usar o código de convite para acessar o formulário de cadastro do paciente.</li>
    <li>O paciente preenche o restante dos dados pessoais e confirma o cadastro.</li>
   </ol>
  </td>
  <td>
   <ul>
    <li>O sistema deve permitir ao nutricionista cadastrar um paciente com e-mail, CPF e gerar um código de convite válido.</li>
    <li>O código de convite deve ser enviado por e-mail ao paciente.</li>
    <li>O paciente deve ser capaz de usar o código de convite para acessar o formulário de cadastro e concluir o processo com sucesso.</li>
   </ul>
  </td>
  <td>XXXXXXXXXXXXXXXXXXXXX
  </td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
 <tr>
  <td>CT-03:Testar inserção e recuperação de dados do(a) Paciente.
  </td>
  <td>
   <ul>
    <li>RF-03: A aplicação deve permitir o cadastro e recuperação de dados de Paciente.
    </li>
   </ul>
  </td>
  <td>Verificar a inserção e recuperação dos dados de um paciente no sistema.
  </td>
  <td>
   <ol>
    <li>Inserir um novo paciente no banco de dados.</li>
    <li>Recuperar os dados do paciente recém-cadastrado.</li>
    <li>Verificar se os dados retornados são os mesmos que os inseridos.</li>
   </ol>
  </td>
  <td>Os dados inseridos devem ser corretamente armazenados e recuperados do banco.
  </td>
  <td>XXXXXXXXXXXXXXXXXXXXX
  </td>
 </tr>
</table>


<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
 <tr>
  <td>CT-04: Testar login com e-mail e senha.
  </td>
  <td>
   <ul>
    <li>RF-04: A aplicação deve permitir que o usuário faça login utilizando e-mail e senha.
    </li>
   </ul>
  </td>
  <td>Verificar se o login com e-mail e senha está funcionando corretamente, validando as credenciais fornecidas.
  </td>
  <td>
   <ol>
    <li>Inserir um e-mail e senha válidos.</li>
    <li>Submeter os dados no formulário de login.</li>
    <li>Verificar se o sistema autentica o usuário corretamente.</li>
   </ol>
  </td>
  <td>O usuário deve ser autenticado com sucesso quando fornecer um e-mail e senha corretos. Caso a combinação esteja errada, o sistema deve exibir uma mensagem de erro e não permitir o       login.
  </td>
  <td>XXXXXXXXXXXXXXXXXXXXX
  </td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
 <tr>
  <td>CT-05: Testar recuperação de senha.
  </td>
  <td>
   <ul>
    <li>RF-05: A aplicação deve permitir que o usuário recupere a senha através do e-mail registrado.
    </li>
   </ul>
  </td>
  <td>Verificar se o processo de recuperação de senha está funcionando corretamente e se o e-mail de redefinição é enviado.
  </td>
  <td>
   <ol>
    <li>Inserir o e-mail de um usuário registrado no campo de recuperação de senha.</li>
    <li>Solicitar a recuperação de senha.</li>
    <li>Verificar se o e-mail de recuperação de senha foi enviado.</li>
    <li>Acessar o link de redefinição de senha.</li>
    <li>Redefinir a senha através do formulário disponibilizado.</li>
   </ol>
  </td>
  <td>   
   <ul>
    <li>O sistema deve enviar um e-mail com o link de redefinição de senha para o endereço fornecido.</li>
    <li>O link deve permitir ao usuário acessar um formulário para definir uma nova senha.</li>
    <li>Após redefinir a senha, o usuário deve conseguir fazer login com a nova senha.</li>
   </ul>
  </td>
  <td>XXXXXXXXXXXXXXXXXXXXX
  </td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
 <tr>
  <td>CT-06: Testar inserção e recuperação de dados do Plano Alimentar.
  </td>
  <td>
   <ul>
    <li>RF-06: A aplicação deve permitir o cadastro de planos alimentares associados a pacientes e nutricionistas.
    </li>
   </ul>
  </td>
  <td>Garantir que os dados do Plano Alimentar sejam armazenados e recuperados corretamente.
  </td>
  <td>
   <ol>
    <li>Inserir um novo plano alimentar vinculado a um paciente e um nutricionista.</li>
    <li>Recuperar os dados do plano alimentar.</li>
   </ol>
  </td>
  <td>O plano alimentar deve estar corretamente vinculado ao paciente e nutricionista e os dados devem ser consistentes.
  </td>
  <td>XXXXXXXXXXXXXXXXXXXXX
  </td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
 <tr>
  <td>CT-07:Testar a adição de comentário ao plano alimentar por paciente e nutricionista.
  </td>
  <td>
   <ul>
    <li>RF-07: A aplicação deve permitir que tanto o paciente quanto o nutricionista possam adicionar comentários ao plano alimentar.
    </li>
    <li>RF-07:Os comentários devem ser armazenados no sistema e exibidos na interface de visualização do plano alimentar.
    </li>
   </ul>
  </td>
  <td>Verificar se o paciente e o nutricionista conseguem adicionar comentários a um plano alimentar e se os comentários são exibidos corretamente.
  </td>
  <td>
   <ol>
    <li>Autenticar o paciente no sistema.</li>
    <li>Acessar o plano alimentar correspondente.</li>
    <li>Inserir um comentário no campo designado.</li>
    <li>Submeter o comentário.</li>
    <li>Verificar se o comentário foi armazenado e está visível na página do plano alimentar.</li>
    <li>Repetir o processo autenticando-se como nutricionista.</li>
    <li>Verificar se ambos os comentários (do paciente e do nutricionista) aparecem corretamente associados ao plano alimentar.</li>
   </ol>
  </td>
  <td>
   <ul>
     <li>O sistema deve permitir que tanto o paciente quanto o nutricionista adicionem comentários ao plano alimentar.</li>
     <li>Os comentários devem ser corretamente armazenados e exibidos na interface do plano alimentar, distinguindo o autor (paciente ou nutricionista).</li>
     <li>Os comentários devem estar visíveis imediatamente após serem submetidos e armazenados de maneira persistente.</li>
   </ul>
  </td>
  <td>XXXXXXXXXXXXXXXXXXXXX
  </td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
 <tr>
  <td>CT-08: Testar a integração entre Paciente, Nutricionista e Plano Alimentar.
  </td>
  <td>
   <ul>
    <li>RF-08: A aplicação deve garantir a associação correta entre Paciente, Nutricionista e Plano Alimentar.
    </li>
   </ul>
  </td>
  <td>Verificar se a relação entre (Paciente, Nutricionista e Plano Alimentar) é corretamente estabelecida.
  </td>
  <td>
   <ol>
    <li>Inserir um paciente, nutricionista e um plano alimentar associado aos dois.</li>
    <li>Verificar se o plano alimentar aparece corretamente para o paciente e nutricionista cadastrados.</li>
   </ol>
  </td>
  <td>O plano alimentar deve ser exibido corretamente na interface dos pacientes e nutricionistas.
  </td>
  <td>XXXXXXXXXXXXXXXXXXXXX
  </td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
  <th>Responsável</th>
 </tr>
 
 <tr>
  <td>CT-09: Testar a exclusão de um paciente e verificar a remoção dos planos alimentares associados.
  </td>
  <td>
   <ul>
    <li>RF-09: A aplicação deve remover todas as informações associadas a um paciente quando ele for excluído.
    </li>
   </ul>
  </td>
  <td>Garantir que, ao excluir um paciente, os planos alimentares relacionados sejam também removidos.
  </td>
  <td>
   <ol>
    <li>Cadastrar um paciente, nutricionista e um plano alimentar associado.</li>
    <li>Excluir o paciente do sistema.</li>
    <li>Verificar se o plano alimentar vinculado ao paciente também foi removido.</li>
   </ol>
  </td>
  <td>O plano alimentar deve ser removido após a exclusão do paciente.
  </td>
  <td>XXXXXXXXXXXXXXXXXXXXX
  </td>
 </tr>
</table>
