var strng = ["test"];
var ID = "I";

function allowDrop(ev) {
    ev.preventDefault();
}

function drag(ev) {

    ev.dataTransfer.setData("text", ev.target.id);

}

function copy(ev, num) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    var nodeCopy = document.getElementById(data).cloneNode(true);
    nodeCopy.id = ID;
    ID += "I";
    ev.target.appendChild(nodeCopy);


}
function drop(ev) {


    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    document.getElementById(data).parentNode.removeChild(document.getElementById(data));


}
function addEv() {
    if (typeof Storage !== "undefined") {
        if (localStorage.clickcount) {
            localStorage.clickcount = sessionStorage.clickcount + "1";
        } else {
            localStorage.clickcount = null;
        }

    } else {
        document.getElementById("result").innerHTML = "Sorry, your browser does not support web storage...";
    }
}
function retrieve() {
    document.getElementById("result").innerHTML = localStorage.clickcount.toString();
}
function clickCounter() {
    if (typeof Storage !== "undefined") {
        if (localStorage.clickcount) {
            localStorage.clickcount = Number(localStorage.clickcount) + 1;
        } else {
            localStorage.clickcount = 1;
        }
        document.getElementById("result").innerHTML = "You have clicked the button " + localStorage.clickcount + " time(s) in this session.";
    } else {
        document.getElementById("result").innerHTML = "Sorry, your browser does not support web storage...";
    }
}



