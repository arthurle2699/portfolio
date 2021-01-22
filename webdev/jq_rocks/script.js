/*  JavaScript 6th Edition 
    Chapter 12 
    Chapter case 
    Life on Rocks Wildlife Cruises 
    Author: Tien Le
    Date: 12/4/2020
    Filename: script.js 
*/

//$("ul.mainmenu li").children("ul").addClass("show"); 
function display(event) {
    //   $(event.currentTarget).children("ul").addClass("show"); 
    //   $(event.currentTarget).children("ul").show(); 
    $(event.currentTarget).children("ul").slideDown("fast");
}
function hide(event) {
    //   $(event.currentTarget).children("ul").removeClass("show"); 
    $(event.currentTarget).children("ul").hide();
}
$("ul.mainmenu li").hover(display, hide);