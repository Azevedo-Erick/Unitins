function add(){
    console.log("funcionando")
    let topico = [
        ["titulo", document.getElementById("topicname").value],
        ["nome",document.getElementById("name").value],
        ["email", document.getElementById("email").value],
        ["texto", document.getElementById("problem").value]
    ];

    let criarDiv = document.createElement('div');
    criarDiv.setAttribute('class', 'problema');

    for(topicitem of topico){
        if(topicitem[1] === ""){
            return alert(`Por favor, informe o ${topicitem[0]}`);
        }
        let text = document.createTextNode(topicitem[1]);
        let p = document.createElement("p");
        p.appendChild(text);
        p.setAttribute('class', topicitem[0]);
        criarDiv.appendChild(p);
    }

    let elementoPai = document.getElementById("problemas");

    let referencia = elementoPai.lastChild;

    elementoPai.insertBefore(criarDiv, referencia.nextElementSibling);
}
let botao = document.getElementById("botao");
botao.addEventListener("click", add);