/*
    This Javascript is for my Finance Tracker
*/

// This function pops up input form for Point In Time information
function openPITInfo() {
    document.getElementById("PITForm").style.display = "block";
    document.getElementById("wrapper").style.display = "none";
}

// This function closes input form for Point In Time information
function closePITInfo() {
    document.getElementById("PITForm").style.display = "none";
    document.getElementById("wrapper").style.display = "block";
}

function resetPITForm() {
    // resetting interface
    document.getElementById("chaseChecking").value = "";
    document.getElementById("chaseCat").value = "";
    document.getElementById("chaseGift").value = "";
}

function collectPITInfo() {
    // collecting form inputs
    var chaseChecking = document.getElementById("chaseChecking").value;
    var chaseCat = document.getElementById("chaseCat").value;
    var chaseGift = document.getElementById("chaseGift").value;
}

// This function collects Point In Time information from form and closes form
function updatePIT(checking, savings, investments, debts) {
    
    console.log(chaseChecking);

    // do something with input? add to DB?

    //resetting interface
    resetPITForm();
    closePITInfo();
}

// This function collects Point In Time information from form and closes form
function updateMonth() {
    var form = document.getElementById("PITForm");

    //resetting interface
    resetPITForm();
    closePITInfo();
}

function openAddAccountForm() {
    document.getElementById("PITForm").style.display = "none";
    document.getElementById("accountForm").style.display = "block";
    document.getElementById("accountType").style.display = "block";

    var dropdown = document.getElementById("dropdown").value;
    console.log(dropdown);
}

function displayElements(elements, className) {
    for (var i = 0; i < elements.length; i++) {
        elements[i].style.display = "block";
    }
}

function removeElements(elements, className) {
    for (var i = 0; i < elements.length; i++) {
        elements[i].style.display = "none";
    }
}

function selectType() {
    var dropdown = document.getElementById("dropdown").value;
    console.log(dropdown);
    document.getElementById("accountInfo").style.display = "block";
    
    if (dropdown == "savings") {
        document.getElementById("interestRates").style.display = "block";
    }
    else if (dropdown == "investment") {
        document.getElementById("interestRates").style.display = "block";
        document.getElementById("isRetirement").style.display = "block";
    }
    else if (dropdown == "loan") {
        document.getElementById("interestRates").style.display = "block";
        document.getElementById("isLoan").style.display = "block";
    }
    else if (dropdown == "creditCard") {
        document.getElementById("isCreditCard").style.display = "block";
    }

    document.getElementById("accountType").style.display = "none";
    document.getElementById("dropdown").value = "default";
}

function closeSelectType() {
    document.getElementById("accountForm").style.display = "none";
    document.getElementById("accountType").style.display = "none";
    document.getElementById("accountInfo").style.display = "none";
    document.getElementById("interestRates").style.display = "none";
    document.getElementById("isRetirement").style.display = "none";
    document.getElementById("isCreditCard").style.display = "none";
    document.getElementById("isLoan").style.display = "none";
    document.getElementById("dropdown").value = "default";
    document.getElementById("PITForm").style.display = "block";
}

function addAccount() {
    closeSelectType();
    closeAddAccount();
}

function closeAddAccount() {
    document.getElementById("PITForm").style.display = "block";
    document.getElementById("accountForm").style.display = "none";
    closeSelectType();
}