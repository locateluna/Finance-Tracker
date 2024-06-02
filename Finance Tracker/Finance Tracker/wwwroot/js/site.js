// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function openPITInfo() {
    document.getElementById("PITForm").style.display = "block";
}

function closePITInfo() {
    document.getElementById("PITForm").style.display = "none";
}

function updatePIT() {
    var chaseChecking = document.getElementById("chaseChecking").value;
    var chaseCat = document.getElementById("chaseCat").value;
    var chaseGift = document.getElementById("chaseGift").value;

    document.write(chaseChecking);
    document.getElementById("PITForm").style.display = "none";
}

function updateMonth() {
    var form = document.getElementById("PITForm");
    document.getElementById("PITForm").style.display = "none";
}