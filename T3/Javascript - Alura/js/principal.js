var titulo = document.querySelector(".titulo");
titulo.textContent = "Testando Java escripto";

var paciente = document.querySelector("#primeiro-paciente");

var tdPeso = paciente.querySelector(".info-peso");
var peso = tdPeso.textContent;

var tdAltura = paciente.querySelector(".info-altura");
var altura = tdAltura.textContent;

var tdImc = paciente.querySelector(".info-imc");

var PesoValido = true;
var AlturaValida = true;

//Validação de Peso:
if (peso > 0 && peso < 500) {
    PesoValido = true;
} else if(peso <= 0 || peso > 500) {
    PesoValido = false;
    tdImc.textContent = "Peso Inválido!";
}

//Validação de Altura:
if (altura > 0 && altura < 3.00) {
    AlturaValida = true;
} else if(altura <= 0 || altura > 3.00) {
    AlturaValida = false;
    tdImc.textContent = "Altura Inválida!";
}

//Validação Final:
if (AlturaValida && PesoValido) {
    var imc = peso / (altura * altura);
    tdImc.textContent = imc;
}
