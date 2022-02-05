    const calcular = document.getElementById('calcular');

    function media (){
    const nome = document.getElementById('nome').value;
    const nota1 = document.getElementById('nota1').value;
    const nota2 = document.getElementById('nota2').value;
    const nota3 = document.getElementById('nota3').value;
    const nota4 = document.getElementById('nota4').value;

    const valorMedia = ((nota1 + nota2 + nota3 + nota4)).toFixed(1);

    resultado.textContent = `${nome} sua nota e ${valorMedia}`;

    }
    
calcular.addEventListener('click', media);