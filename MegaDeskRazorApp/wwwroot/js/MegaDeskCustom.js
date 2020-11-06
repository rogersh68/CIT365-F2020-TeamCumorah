//set the anchors inline styles
//set event listeners
var eles = document.getElementsByClassName("nav-link");

//for each item add the event listeners for mouseenter and mouseleave
var ele0 = eles[0];
eles[0].addEventListener('mouseenter', function () {
    ele0.setAttribute("style", "color:white !important");
});
eles[0].addEventListener('mouseleave', function () {
    ele0.setAttribute("style", "rgba(255,255,255,.5) !important");
});
eles[0].addEventListener('focus', function () {
    ele0.setAttribute("style", "color:white !important");
});
eles[0].addEventListener('blur', function () {
    ele0.setAttribute("style", "rgba(255,255,255,.5) !important");
});

var ele1 = eles[1];
eles[1].addEventListener('mouseenter', function () {
    ele1.setAttribute("style", "color:white !important");
});
eles[1].addEventListener('mouseleave', function () {
    ele1.setAttribute("style", "rgba(255,255,255,.5) !important");
});
eles[1].addEventListener('focus', function () {
    ele1.setAttribute("style", "color:white !important");
});
eles[1].addEventListener('blur', function () {
    ele1.setAttribute("style", "rgba(255,255,255,.5) !important");
});