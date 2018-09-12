var titulo = document.querySelector(".titulo");
titulo.textContent = "Testando Java escripto";

var paciente = document.querySelector("#primeiro-paciente");

var tdPeso = paciente.querySelector(".info-peso");
var peso = tdPeso.textContent;

var tdAltura = paciente.querySelector(".info-altura");
var altura = tdAltura.textContent;

console.log(paciente);
console.log(tdPeso);
console.log(peso);
console.log(altura);