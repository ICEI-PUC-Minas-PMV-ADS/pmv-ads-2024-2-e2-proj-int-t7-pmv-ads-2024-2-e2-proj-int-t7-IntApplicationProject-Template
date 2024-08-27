# Introdução
<div align="justify">
O setor da Construção Civil possui previsões extremamente positivas para o ano de 2024. A Câmara Brasileira da Indústria da Construção (CBIC) revisou de 1,3% para 2,3% o crescimento do Produto Interno Produto (PIB) para o setor. Inclusive, com índices acima das previsões para o PIB Brasil deste ano (CBIC, 2024). 
<br/><br/>
Com o aumento exponencial, também se prevê mais contratações, lançamentos de empreendimentos e compras no setor.
<br/><br/>
Entretanto, as condições financeiras e de mercado não são os únicos desafios a serem enfrentados diariamente pela categoria. Muito embora se tenha um cenário positivo de crescimento, é necessário estar atento às condições externas que podem atrasar ou até impedir a concretização das obras. 
<br/><br/>
Á título de exemplo, tem-se as condições climáticas (chuvas severas e estiagem), que no contexto atual representam obstáculos para cronogramas assertivos, bem como para as previsões repassadas aos clientes. Cientistas do Instituto de Ciências Marinhas de Barcelona demostraram como as mudanças climáticas aceleram o ciclo hidrológico, gerando tempestades cada vez mais intensas e instabilidades (KUEBLER, 2024). 
<br/><br/>
Cientistas do Instituto de Ciências Marinhas de Barcelona, Espanha, demonstraram como a mudança climática está acelerando o ciclo através de uma análise da salinidade da superfície oceânica – a qual aumenta à medida que a evaporação se intensifica.
<br/><br/>
Em resposta à crescente demanda, faz-se necessário o desenvolvimento de um sistema de gestão de obras, que possibilite que gestores e construtoras monitorem o progresso de suas atividades e obtenham uma visão ampla e conectada de obras e de empreendimentos. 
<br/>
</div>

## Problema
<div align="justify">
A problemática identificada neste contexto reside na ausência de uma ferramenta eficaz que permita aos usuários realizarem um controle e gerenciamento efetivo do andamento de obras.
<br/><br/>
A ausência de ferramentas simples e com uma interface prática figura como um empecilho para que profissionais do ramo utilizem ferramentas específicas para o cadastro e monitoramento das etapas das obras. 
<br/><br/>
Além disso, a ausência de uma ferramenta voltada especificamente para essa finalidade gera uma lacuna entre clientes e construtoras, prejudicando a transparência e o acompanhamento em tempo real do estágio de desenvolvimento. 
<br/>
</div>

## Objetivos
<div align="justify">
O objetivo geral deste projeto é o desenvolvimento de uma ferramenta, denominada como “Concreta”, que permita com que gestores de obras, proprietários de construtoras e demais stakeholders obtenham informações claras e acessíveis sobre os estágios de cada etapa em uma obra. Ao promover a transparência da informação e possibilitar o cadastro e acompanhamento da execução de empreendimentos, a ferramenta Concreta não apenas auxiliará a ter melhores previsões, como possibilitará previsões que auxiliem na tomada de decisões. 
<br/><br/>
Como objetivos específicos, é possível destacar:	
<br/><br/>
 
+ Permitir ao usuário cadastrar novos empreendimentos, bem como as etapas que o compõe e o prazo inicial e final de sua realização;

+ Permitir a atualização diária, semanal ou mensal do andamento das obras; bem como a opção de dar a obra como concluída

+ Permitir a emissão de relatórios detalhados ou gerais com base no empreendimento escolhido;

+ Fornecer alertas aos usuários sobre obras que estejam com prazo diverso do cronograma previsto, bem como sobre condições que podem afetar o andamento da obra (exemplo: cadastramento de etapas em épocas previstas como chuvosas);

+ Ter uma interface amigável e de fácil navegação, tornando-o acessível aos usuários, independentemente do seu nível de experiência tecnológica.
 
 </div>

## Justificativa
<div align="justify">
Através de uma pesquisa conduzida via Google Forms, verificou-se os principais apontamentos do público-alvo sobre o desenvolvimento da ferramenta. 
Nesse sentido, sobre o que esperavam de uma plataforma de gestão de obras, os entrevistados em sua grande maioria (44,4%) apontaram como necessário o recebimento de notificações automáticas sobre atualizações e mudanças nos cronogramas. A seguir, apontou-se como importante o monitoramento em tempo real do progresso das etapas nas obras:
<br/><br/>
<div  align="center">
 
**Figura 01 - Principal funcionalidade esperada de uma plataforma de controle de obras**
<br/><br/>
![image](https://github.com/user-attachments/assets/bed4ecbc-31c8-4843-b5c5-aaddd06cc664)
<br/>
**Fonte: Os autores.**
</div>
<br/><br/>

Ademais, em relação a utilização de uma ferramenta para a gestão de empreendimentos, os entrevistados apontaram uma utilização ocasional (44,4%) seguida de rara, para empreendimentos específicos (22,2%):
<br/><br/>
<div  align="center">

**Figura 02 - Frequência de acesso às ferramentas de gestão de obras**
<br/><br/>

![image](https://github.com/user-attachments/assets/d1a5a74f-adcc-4605-92dc-2a02d3f7b398)

**Fonte: Os autores**
</div>
<br/>

<div align="justify">
A baixa aderência a ferramentas de gestão pode decorrer, sobretudo, pela dificuldade dos usuários em utilizar as ferramentas atualmente disponíveis no mercado. Assim, dentre as principais reclamações registradas pelos entrevistados, é possível destacar: 
<br/><br/>

 + Desafio em acompanhar a obra em tempo real;
   
 + Comunicação entre estágios de curto e médio prazo;
   
 + Controle do tempo executado numa determinada tarefa;
 
 + Plataforma com erros e bugs;

<br/><br/>
A exemplo de algumas ferramentas existentes hoje no mercado (obrafit [https://www.obrafit.com.br/]; gerenciaobras [https://gerenciaobras.com.br/]; sênior-mega [https://www.mega.com.br/sobre-a-mega]), é possível verificar que parte das demandas registradas pelos entrevistados não são atendidas, sobretudo porque não há uma priorização específica para o gerenciamento das etapas de obras e cronogramas. 
<br/><br/>
<table>
  <tr>
    <th>Obrafit</th>
    <th>Gerenciaobras</th>
    <th>Senior-mega</th>
    <th>Concreta</th>
  </tr>
  <tr>
    <td>Enfoque prioritário em relatórios de pagamentos, medições de serviços, gerenciamento de pendências, controle financeiro e mapa de cotações.</td>
    <td>Enfoque prioritário em medições, arquivos e visitas técnicas, suprimentos e financeiro.</td>
    <td>Enfoque em orçamentos de obras, compras e contratações, gestão de equipamentos, contrato de empreiteiros, gestão de documentos e planejamentos físico-econômicos.</td>
    <td>Enfoque principal em fornecer uma ferramenta simples e prática que permita gerenciar as etapas e uma obra, emitindo alertas de  atrasos (inclusive sobre épocas de cheias), bem como permitir a impressão de relatórios gerais e específicos a depender do objetivo do usuário. </td>
  </tr>
</table>
<br/>
Desta maneira, a Concreta é uma resposta a essa demanda crescente por ferramentas que possibilitem o controle efetivo das etapas das obras. Este serviço visa fornecer aos usuários uma ferramenta prática e eficaz para gerenciar empreendimentos e fornecer previsões mais acertadas, além de relatórios detalhados e gerais. 
<br/>
</div>

## Público-Alvo
<div align="justify">
Através de uma pesquisa conduzida via Google Form, identificamos o perfil principal do público-alvo deste projeto:
<br/><br/>
 
* Os usuários são predominantemente engenheiros e clientes de construtoras
* Idades variando de 25 a 55+ anos
* A maioria acessa plataformas online por meio de smartphones ou computadores.

<br/>
Este grupo busca melhorar a eficiência na gestão de tempo e recursos durante o processo de obras, aumentando a interatividade com os clientes. Segue abaixo gráficos da pesquisa, em que é possível verificar que o público alvo se insere entre engenheiros, arquitetos, gestores de obras e clientes.
<br/><br/>

<div  align="center">
 
**Figura 03 - Área de atuação dos entrevistados.**
<br/><br/>
<img  src="https://github.com/user-attachments/assets/6f9ba446-80e9-43e3-9cad-88358727a3f4" width="400">
<br/>
**Fonte os autores.**
</div>
<br/><br/>
Ademais, é possível relacionar a faixa etária dos entrevistados com o conhecimento prévio em plataformas de controle similares ao do projeto:
<br/><br/>

<div  align="center">
 
**Figura 04 - Conhecimento Prévio em Plataformas de Controle.**
<br/><br/>
<img  src="https://github.com/user-attachments/assets/f85ed2a0-8429-40d3-90a5-f1723467ca2c" width="400">
<br/>
**Fonte os autores.**
</div>
<br/><br/>

<div  align="center">
 
**Figura 05 - Faixa etária dos entrevistados.**
<br/><br/>
<img  src="https://github.com/user-attachments/assets/def5c075-10b5-4084-879b-c99b018a61fa" width="400">
<br/>
**Fonte os autores.**
</div>
<br/><br/>

Nesse sentido, justamente em razão da profissão (que exige um perfil mais prático) e também da faixa etária, se obserovu a opção por dispositivos que seriam utilizados para acessar a plataforma
</div>
<br/><br/>

<div  align="center">
 
**Figura 06 - Tipo de Dispositivo utilizados para acessar plataformas.**
<br/><br/>
<img  src="https://github.com/user-attachments/assets/4f64802e-613b-4c24-ac58-d9190ab4841d" width="400">
<br/>
**Fonte os autores.**
</div>
<br/><br/>
Desta maneira, com base na pesquisa acima foi possível identificar, através dos entrevistados, os princpais perfis de usuário que nortearão a aplicação. 
