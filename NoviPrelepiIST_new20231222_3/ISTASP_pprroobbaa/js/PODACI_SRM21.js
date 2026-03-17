function selTP_LAZNIDDLVRPLOV(source, eventArgs) {
     document.getElementById('TP_VRPLOV').value = eventArgs.get_value();
}


function c_vrednosti_DaNe_TK_SIF(oSrc, args) {
args.IsValid = true;
if (args.Value == 0000) {args.IsValid = false;}
}
