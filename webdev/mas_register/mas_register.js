"use strict";
/*
   New Perspectives on HTML5, CSS3, and JavaScript 6th Edition
   Tutorial 13
   Case Problem 3


   Filename: mas_register.js

   Author:  Tien Le
   Date:    11/13/2020
   
   Function List
   =============
   
   sessionTest()
      Performs a validation test on the selection of the conference
      session package and the conference discount number
   
   calcCart()
      Calculates the cost of the registration and saves data
      in session storage
      
   writeSessionValues()
      Writes data values from session storage in to the
      registration summary form


*/
window.onload = function () { //step 4
    calcCart();
    document.getElementById("regSubmit").onclick = sessionTest;
    document.getElementById("fnBox").onblur = calcCart;
    document.getElementById("lnBox").onblur = calcCart;
    document.getElementById("groupBox").onblur = calcCart;
    document.getElementById("mailBox").onblur = calcCart;
    document.getElementById("phoneBox").onblur = calcCart;
    document.getElementById("banquetBox").onblur = calcCart;
    document.getElementById("sessionBox").onchange = calcCart;
    document.getElementById("mediaCB").onclick = calcCart;
}

function sessionTest() { //step 5
    if (sessionBox.selectedIndex == -1) {
        sessionBox.setCustomValidity("Select a Session Package.");
    } else {
        sessionBox.setCustomValidity("");
    }
}

function calcCart() { //step 6
    sessionStorage.confName = document.getElementById("fnBox").value + " " + document.getElementById("lnBox").value;
    sessionStorage.confGroup = document.getElementById("groupBox").value;
    sessionStorage.confMail = document.getElementById("mailBox").value;
    sessionStorage.confPhone = document.getElementById("phoneBox").value;
    sessionStorage.confBanquet = document.getElementById("banquetBox").value;
    sessionStorage.confBanquetCost = Number(sessionStorage.confBanquet) * 55;
    var index = sessionBox.selectedIndex;
    if (index != -1) {
        sessionStorage.confSession = sessionBox[index].text;
        sessionStorage.confSessionCost = sessionBox.value;
    } else {
    sessionStorage.confSession = "";
    sessionStorage.confSessionCost = 0;
    }
    if (mediaCB.checked) {
        sessionStorage.confPack = "Yes";
        sessionStorage.confPackCost = 115;
    } else {
    sessionStorage.confPack = "No";
    sessionStorage.confPackCost = 0;
    }
    sessionStorage.confTotal = parseFloat(sessionStorage.confPackCost) + parseFloat(sessionStorage.confSessionCost) + parseFloat(sessionStorage.confBanquetCost);
    writeSessionValues();
}

function writeSessionValues() { //step 7
    document.getElementById("regName").textContent = sessionStorage.confName;
    document.getElementById("regGroup").textContent = sessionStorage.confGroup;
    document.getElementById("regEmail").textContent = sessionStorage.confMail;
    document.getElementById("regPhone").textContent = sessionStorage.confPhone;
    document.getElementById("regSession").textContent = sessionStorage.confSession;
    document.getElementById("regBanquet").textContent = sessionStorage.confBanquet;
    document.getElementById("regPack").textContent = sessionStorage.confPack;
    document.getElementById("regTotal").textContent = sessionStorage.confTotal;
}