function OnClientPopulating(sender, e) {
    sender._element.className = "loading";
}
function OnClientCompleted(sender, e) {
    sender._element.className = "";
}
function CallClick() {
    document.getElementById('view').click(); 
}
function hourglass() {
    document.body.style.cursor = 'wait';
}
    function killBackSpace(e) {
        e = e ? e : window.event;
        var t = e.target ? e.target : e.srcElement ? e.srcElement : null;
        if (t && t.tagName && (t.type && /(password)|(text)|(file)/.test(t.type.toLowerCase())) || t.tagName.toLowerCase() == 'textarea')
            return true;
        var k = e.keyCode ? e.keyCode : e.which ? e.which : null;
        if (k == 8) {
            if (e.preventDefault)
                e.preventDefault();
            return false;
        };
        return true;
    };
    if (typeof document.addEventListener != 'undefined')
        document.addEventListener('keydown', killBackSpace, false);
    else if (typeof document.attachEvent != 'undefined')
        document.attachEvent('onkeydown', killBackSpace);
    else {
        if (document.onkeydown != null) {
            var oldOnkeydown = document.onkeydown;
            var oldOnkeypress = document.onkeypress;
            document.onkeydown = function(e) {
                oldOnkeydown(e);
                killBackSpace(e);
            };
            document.onkeypress = function(e) {
                oldOnkeypress(e);
                killBackSpace(e);
            };
        }
        else
            document.onkeydown = killBackSpace;
            document.onkeypress = killBackSpace;
    }
