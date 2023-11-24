// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function checkInputData() {
    var name = document.getElementById("clientName");
    var number = document.getElementById("clientNumber");
    var from = document.getElementById("adresFrom");
    var to = document.getElementById("adresTo");
    var price = document.getElementById("price");
    var type = document.getElementById("type");
    var car = document.getElementById("car");
    if (name && number && from && to && price && type && car) {
        alert("Данные добавлены");
        return true;
    }
    else {
        alert("Проверьте правильность заполнения");
        return false;
    }
}
