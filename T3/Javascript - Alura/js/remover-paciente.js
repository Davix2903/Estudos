var pacientes = document.querySelectorAll(".paciente");
console.log(pacientes);
var tabela = document.querySelector("#tabela-pacientes");
console.log(tabela);
tabela.addEventListener("dblclick", function(event) {
    console.log("removeu");
    event.target.parentNode.classList.add("fadeOut");

    setTimeout(function() {
        event.target.parentNode.remove();
    }, 500);

});
