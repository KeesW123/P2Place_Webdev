var navContainer = document.getElementById("nav-container");
var links = navContainer.getElementsByClassName("nav-link");
var navLinkNumber = document.getElementById("pageSelector").innerHTML;
var currentSelected = document.getElementsByClassName("selected");
currentSelected[0].className = currentSelected[0].className.replace(" selected", "");
links[navLinkNumber].className += " selected";