var strng = ["test"];


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
var cars = [];
    var text = [];
    var i;
function frlp(lst) {

    function append(a, b, c) {

        cars.push(a.toString + b.toString + c.toString);
        for (i = 0; i < cars.length; i++) {
            text += [(cars[i] + "<br>")];

        }
        document.getElementById("result").innerHTML = text;
    }
    function remove() {
        cars.splice(cars[0], 1);
        document.getElementById("result").innerHTML = cars;
    }

    function fuckAcDc() {
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







    
    
function transfer() {
            var text = [];
            var i;
            var t;
            var s;
            var b;
            var range = ["EBGDAEA"]

            for (s = 0; s < 8; s++) {
                text += [`
<!--Individual Line-->
        <div id="div2">`];
            @*for (i = 0; i < 7; i++) {

                text += [`<div style="clear:left; background-image:url('/Content/Images/TbPpr.png')">
                    <!--Tab strings-->
                    <p style="float:left"><b>(` + i + ` + 1) :</b></p><p style="float:left">` + range[i] + `</p><p style="float:left">|</p>`];

                for (b = 0; b < 23; b++) {
                    text += [`
                        <!--Tab timeline-->
                        <p style="float:left">&#8213</p>` +

                        `div style="float:left" id="div1" ondrop="copy(event,` + s + "," + i + "," + b + `)" ondragover="allowDrop(event)">
                        </div>


                        <p style="float:left">|</p>


                    `];
                }
                text += [`</div>`];


            }
            text += ['<div style="clear:left" ondragover="allowDrop(event)" ondrop="delete (event)">' +
                '<!--Note Values:-->'];*@

                for (t = 0; t < 32; t++) {
                    text +=
                        ['<img id="drag' + t.ToString() + '" src="/Content/Images/Int_Square_Blank(' + t + ').png" style="float:left" height="20px" width="20px" draggable="true" ondragstart="drag(event)" dropzone="BinDiv"><b style="float:left"> | </b>']
                        ;
                }
                text += ['</div>' +
                    '<div id="BinDiv" ondragover="allowDrop(event)" ondrop="drop(event)"></div>' + '</div>'];


            }
            document.getElementById("zzzz").innerHTML = text.length;

        }