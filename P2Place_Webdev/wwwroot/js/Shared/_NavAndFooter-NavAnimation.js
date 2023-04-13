var navContainer = document.getElementById("nav-container");
var links = navContainer.getElementsByClassName("nav-link");
var navLinkNumber = document.getElementById("pageSelector").innerHTML;
var currentSelected = document.getElementsByClassName("selected");
currentSelected[0].className = currentSelected[0].className.replace(" selected", "");
links[navLinkNumber].className += " selected";

//const logoText = document.getElementById("logo-text");

//// Add an event listener to the menu icon for click events
//logoText.addEventListener('click', function () {
//    // Toggle the active class on the menu icon
//    logoText.classList.toggle('active');

//    // Toggle the display property of the menu
//    if (navContainer.style.display === 'flex') {
//        navContainer.style.display = 'none';
//    } else {
//        navContainer.style.display = 'flex';
//    }
//});