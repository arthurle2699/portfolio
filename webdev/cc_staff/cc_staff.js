"use strict";

/*
   New Perspectives on HTML5, CSS3, and JavaScript 6th Edition
   Tutorial 14
   Case Problem 2

   Author: Tien Le
   Date:   12/4/2020
   
   Filename: cc_staff.js
   
      
*/


/* Constructor function for the employee class */
function employee(id, firstName, lastName, dept, position, email, phone, photo) {
    this.id = id;
    this.firstName = firstName;
    this.lastName = lastName;
    this.dept = dept;
    this.position = position;
    this.email = email;
    this.phone = phone;
    this.photo = photo;
}

/* Object literal for search results */
var searchResult = {
    employees: [],
    sortById: function () {
        this.employees.sort(function (a, b) {
            if (a.id < b.id) { return -1; }
            else { return 1; }
        });
    }
};


/* Event listener to retrieve and display employee records matching the search condition */
document.getElementById("searchButton").addEventListener("click", function () {
    var tableBody = document.querySelector("table#staffTable tbody");
    var tableCaption = document.querySelector("table#staffTable caption");
    tableBody.removeChildren();
    searchResult.employees = [];
    staff.directory.forEach(function (record) {
        var nameSearch = document.getElementById('nameSearch').value;
        var nameSearchType = document.getElementById('nameSearchType').selectedValue();
        switch (nameSearchType) {
            case 'contains':
                var nameRegExp = new RegExp(nameSearch, 'i');
                break;
            case 'beginsWith':
                var nameRegExp = new RegExp('^' + nameSearch, 'i');
                break;
            case 'exact':
                var nameRegExp = new RegExp('^' + nameSearch + '$', 'i');
                break;
        }
        var foundName = nameRegExp.test(record.lastName);

        var positionSearch = document.getElementById('positionSearch').value
        var positionSearchType = document.getElementById('positionSearchType').selectedValue();
        switch (positionSearchType) {
            case 'contains':
                var positionRegExp = new RegExp(positionSearch, 'i');
                break;
            case 'beginsWith':
                var positionRegExp = new RegExp('^' + positionSearch, 'i');
                break;
            case 'exact':
                var positionRegExp = new RegExp('^' + positionSearch + '$', 'i');
                break;
        }
        var foundPosition = positionRegExp.test(record.position);

        var deptSearch = document.getElementById('deptSearch').selectedValue();
        if (deptSearch == '' || deptSearch == record.dept) { var foundDept = true; }
        else { var foundDept = false; }
        console.log(foundName + " " + foundPosition + " " + foundDept);
        if (foundName == true && foundPosition == true && foundDept == true) {
            var newEmployee = new employee;
            newEmployee.id = record.id;
            newEmployee.firstName = record.firstName;
            newEmployee.lastName = record.lastName;
            newEmployee.dept = record.dept;
            newEmployee.position = record.position;
            newEmployee.email = record.email;
            newEmployee.phone = record.phone;
            newEmployee.photo = record.photo;
            searchResult.employees.push(newEmployee);
        }
    });

    tableCaption.textContent = searchResult.employees.length + ' total record(s) found';
    searchResult.sortById();
    searchResult.employees.forEach(function (record) {
        var row = document.createElement('tr');
        row.innerHTML += '<td><img src = "' + record.photo + '" /></td>';
        row.innerHTML += '<td>' + record.firstName + ' ' + record.lastName + '</td>';
        row.innerHTML += '<td>' + record.dept + '</td>';
        row.innerHTML += '<td>' + record.position + '</td>';
        row.innerHTML += '<td><a href ="mailto:' + record.email + '"</a></td>';
        row.innerHTML += '<td><a href ="tel:' + record.phone + '"></a></td>';
        tableBody.appendChild(row);
    });
});








    /* --- Methods added to native objects ---*/

    /* Method added to any DOM element that removes all child nodes of element */
    HTMLElement.prototype.removeChildren = function () {
        while (this.firstChild) {
            this.removeChild(this.firstChild);
        }
    };

    /* Method added to the select element to return the value of the selected option */
    HTMLSelectElement.prototype.selectedValue = function () {
        var sIndex = this.selectedIndex;
        return this.options[sIndex].value;
    };