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

var ele = document.getElementById("woodType");

var e = ele;
if (!(ele === null)) {
    ele.addEventListener('change', function () {

        var child = e.children;
        for (var i = 0; i < child.length; i++) {
            if (child[i].selected == true && child[i].value == 50) {
                e.setAttribute("style", "background-image: linear-gradient(rgba(255, 255, 255, .5), rgba(255, 255, 255, .5)), url(../images/PineWood.PNG); background-size: 100% auto;");
            }
            else if (child[i].selected == true && child[i].value == 100) {
                e.setAttribute("style", "background-image: linear-gradient(rgba(255, 255, 255, .5), rgba(255, 255, 255, .5)), url(../images/LaminateWood.PNG); background-size: 100% auto;");
            }
            else if (child[i].selected == true && child[i].value == 125) {
                e.setAttribute("style", "background-image: linear-gradient(rgba(255, 255, 255, .5), rgba(255, 255, 255, .5)), url(../images/VeneerWood.PNG); background-size: 100% auto;");
            }
            else if (child[i].selected == true && child[i].value == 200) {
                e.setAttribute("style", "background-image: linear-gradient(rgba(255, 255, 255, .5), rgba(255, 255, 255, .5)), url(../images/OakWood.PNG); background-size: 100% auto;");
            }
            else if (child[i].selected == true && child[i].value == 300) {
                e.setAttribute("style", "background-image: linear-gradient(rgba(255, 255, 255, .5), rgba(255, 255, 255, .5)), url(../images/RoseWood.PNG); background-size: 100% auto;");
            }
        }

    });

}

var eleEdit = document.getElementById("Quote_desktopMaterial");

var eEdit = eleEdit;
if (!(eleEdit === null)) {
    eleEdit.addEventListener('change', function () {

        var child = eEdit.children;
        for (var i = 0; i < child.length; i++) {
            if (child[i].selected == true && child[i].value == 50) {
                eEdit.setAttribute("style", "background-image: linear-gradient(rgba(255, 255, 255, .5), rgba(255, 255, 255, .5)), url(../images/PineWood.PNG); background-size: 100% auto;");
            }
            else if (child[i].selected == true && child[i].value == 100) {
                eEdit.setAttribute("style", "background-image: linear-gradient(rgba(255, 255, 255, .5), rgba(255, 255, 255, .5)), url(../images/LaminateWood.PNG); background-size: 100% auto;");
            }
            else if (child[i].selected == true && child[i].value == 125) {
                eEdit.setAttribute("style", "background-image: linear-gradient(rgba(255, 255, 255, .5), rgba(255, 255, 255, .5)), url(../images/VeneerWood.PNG); background-size: 100% auto;");
            }
            else if (child[i].selected == true && child[i].value == 200) {
                eEdit.setAttribute("style", "background-image: linear-gradient(rgba(255, 255, 255, .5), rgba(255, 255, 255, .5)), url(../images/OakWood.PNG); background-size: 100% auto;");
            }
            else if (child[i].selected == true && child[i].value == 300) {
                eEdit.setAttribute("style", "background-image: linear-gradient(rgba(255, 255, 255, .5), rgba(255, 255, 255, .5)), url(../images/RoseWood.PNG); background-size: 100% auto;");
            }
        }

    });
}
