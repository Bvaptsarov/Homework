; (function () {
    "use strict";//actually this one is good ONLY if we're at debugging stage, normally works fine without it

    var addScroll = false;
    var browserAppName = navigator.appName;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    if (browserAppName == "Netscape") {
        document.captureEvents(Event.MOUSEMOVE);
    }

    var possitionX = 0, possitionY = 0;
    var layer;
    document.onmousemove = mouseMove;
   
    function mouseMove(eventTriggerer) {
        if (browserAppName == "Netscape") {
            possitionX = eventTriggerer.pageX - 5;
            possitionY = eventTriggerer.pageY;

            if (document.layers['ToolTip'].visibility == 'show') {
                PopTip();
            }
        }
        else {
            possitionX = event.x - 5;
            possitionY = event.y;

            if (document.all['ToolTip'].style.visibility == 'visible') {
                PopTip();
            }
        }
    }

    function PopTip() {
        if (browserAppName == "Netscape") {
            layer = eval('document.layers[\'ToolTip\']');

            if ((possitionX + 120) > window.innerWidth) {
                possitionX = window.innerWidth - 150;
            }

            layer.left = possitionX + 10;
            layer.top = possitionY + 15;
            layer.visibility = 'show';
        }
        else {
            layer = eval('document.all[\'ToolTip\']');

            if (layer) {
                possitionX = event.x - 5;
                possitionY = event.y;

                if (addScroll) {
                    possitionX = possitionX + document.body.scrollLeft;
                    possitionY = possitionY + document.body.scrollTop;
                }

                if ((possitionX + 120) > document.body.clientWidth) {
                    possitionX = possitionX - 150;
                }

                layer.style.pixelLeft = possitionX + 10;
                layer.style.pixelTop = possitionY + 15;
                layer.style.visibility = 'visible';
            }
        }
    }

    function HideTip() {
        if (browserAppName == "Netscape") {
            document.layers['ToolTip'].visibility = 'hide';
        }
        else {
            document.all['ToolTip'].style.visibility = 'hidden';
        }
    }

    function HideMenu1() {
        if (browserAppName == "Netscape") {
            document.layers['menu1'].visibility = 'hide';
        }
        else {
            document.all['menu1'].style.visibility = 'hidden';
        }
    }

    function ShowMenu1() {
        if (browserAppName == "Netscape") {
            layer = eval('document.layers[\'menu1\']');
            layer.visibility = 'show';
        }
        else {
            layer = eval('document.all[\'menu1\']');
            layer.style.visibility = 'visible';
        }
    }

    function HideMenu2() {
        if (browserAppName == "Netscape") {
            document.layers['menu2'].visibility = 'hide';
        }
        else {
            document.all['menu2'].style.visibility = 'hidden';
        }
    }

    function ShowMenu2() {
        if (browserAppName == "Netscape") {
            layer = eval('document.layers[\'menu2\']');
            layer.visibility = 'show';
        }
        else {
            layer = eval('document.all[\'menu2\']');
            layer.style.visibility = 'visible';
        }
    }
})();