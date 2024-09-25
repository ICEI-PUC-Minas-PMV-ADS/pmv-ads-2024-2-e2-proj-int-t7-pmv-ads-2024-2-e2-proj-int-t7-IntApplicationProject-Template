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
  <td>CT-01:Testar inserção e recuperação de dados do(a) Paciente.
  </td>
  <td>
   <ul>
    <li>RF-01: A aplicação deve permitir o cadastro e recuperação de dados de Paciente.
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
  <td>CT-02: Testar inserção e recuperação de dados do(a) Nutricionista.
  </td>
  <td>
   <ul>
    <li>RF-02: A aplicação deve permitir o cadastro e recuperação de dados de Nutricionista.
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
  <td>CT-03: Testar inserção e recuperação de dados da entidade Plano Alimentar.
  </td>
  <td>
   <ul>
    <li>RF-03: A aplicação deve permitir o cadastro de planos alimentares associados a pacientes e nutricionistas.
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
  <td>CT-04: Testar a integração entre Paciente, Nutricionista e Plano Alimentar.
  </td>
  <td>
   <ul>
    <li>RF-04: A aplicação deve garantir a associação correta entre Paciente, Nutricionista e Plano Alimentar.
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
  <td>CT-05: Testar a exclusão de um paciente e verificar a remoção dos planos alimentares associados.
  </td>
  <td>
   <ul>
    <li>RF-05: A aplicação deve remover todas as informações associadas a um paciente quando ele for excluído.
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
