let listaCadastro = [];

document.getElementById('btn-cadastrar').addEventListener('click', function(event) {
    event.preventDefault();

    const nome = document.getElementById('nome').value.trim();
    const localidade = document.getElementById('localidade').value.trim();
    const eficiencia = document.getElementById('eficiencia').value.trim();
    const descricao = document.getElementById('descricao').value.trim();
    const tipo = document.getElementById('tipo').value.trim();
    const estado = document.getElementById('estado').value.trim();
    const capacidade = document.getElementById('capacidade').value.trim();
    const data = document.getElementById('data').value.trim();

    if (!nome || !localidade || !eficiencia || !descricao || !tipo || !estado || !capacidade || !data) {
        alert('Preencha todos os campos!');
        return;
    }

    const item = {
        nome,
        localidade,
        eficiencia,
        descricao,
        tipo,
        estado,
        capacidade,
        data
    };

    listaCadastro.push(item);

    document.querySelectorAll('input, textarea').forEach(element => {
        element.value = '';
    });

    atualizarLista();
});

function atualizarLista() {
    const lista = document.getElementById('lista-usinas');
    lista.innerHTML = '';

    listaCadastro.forEach((item, index) => {
        const div = document.createElement('div');
        div.classList.add('lista-usinas');
        div.innerHTML = `
            <2>${item.nome}</h2>
            <p>Localidade: ${item.localidade}</p>
            <p>Eficiência: ${item.eficiencia}</p>
            <p>Descrição: ${item.descricao}</p>
            <p>Tipo: ${item.tipo}</p>
            <p>Estado: ${item.estado}</p>
            <p>Capacidade: ${item.capacidade}</p>
            <p>Data: ${item.data}</p>
        `;
        lista.appendChild(div);
    });
}
