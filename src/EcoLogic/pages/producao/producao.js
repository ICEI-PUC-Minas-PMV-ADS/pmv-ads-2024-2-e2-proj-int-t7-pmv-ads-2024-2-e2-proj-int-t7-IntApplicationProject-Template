<script>
        function calcularEnergia() {
            const areaPainel = 1.6; // Área em m²
            const eficiencia = 0.15; // 15% de eficiência
            const irradiação = 5; // Média de horas de sol

            // Obter dados do formulário
            const data = document.getElementById('data').value;
            const usina = document.getElementById('usina').value;

            // Cálculo da energia
            const energia = irradiação * areaPainel * eficiencia * 24; // kWh

            // Exibir resultado
            document.getElementById('resultado').innerText = `Produção estimada: ${energia.toFixed(2)} kWh`;

            // Adicionar registro à tabela
            const registroTabela = document.getElementById('registro');
            const novaLinha = registroTabela.insertRow();
            novaLinha.innerHTML = `
                <td>${data}</td>
                <td>${usina}</td>
                <td>${energia.toFixed(2)}</td>
            `;

            // Limpar campos
            document.getElementById('data').value = '';
            document.getElementById('usina').value = '';
        }
    </script>