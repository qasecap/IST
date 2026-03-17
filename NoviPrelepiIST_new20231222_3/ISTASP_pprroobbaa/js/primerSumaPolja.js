1. suma polja
function Suma6(sab1, sab2, sab3, izlaznasuma) {
	//ako je sab1 TextBox
	s1 = parseFloat(document.getElementById(sab1).value);
	if (isNaN(s1) == true) {
		s1 = 0;
	}

	//ako je sab1 Labela
	s1 = Number(document.getElementById(sab1).textContent);   
	if (isNaN(s1) == true) {
		s1 = 0;
	}


	var s2 = parseFloat(document.getElementById(sab2).value);
	if (isNaN(s2) == true) {
		s2 = 0;
	}
	var s3 = parseFloat(document.getElementById(sab3).value);
	if (isNaN(s3) == true) {
		s3 = 0;
	}
	
	//ako je izlaznasuma TextBox
	document.getElementById(izlaznasuma).value = s1 + s2 + s3;

	//ako je izlaznasuma Labela
	document.getElementById(izlaznasuma).innerHTML = s1 + s2 + s3;
	
}


poziv funkcije ide u VB na load strane
TP_P12_1_1.Attributes.Add("onKeyUp", "Suma6('TP_P12_1_1','TP_P12_2_1','TP_P12_3_1','TP_P12_0_1')")
TP_P12_2_1.Attributes.Add("onKeyUp", "Suma6('TP_P12_1_1','TP_P12_2_1','TP_P12_3_1','TP_P12_0_1')")
TP_P12_3_1.Attributes.Add("onKeyUp", "Suma6('TP_P12_1_1','TP_P12_2_1','TP_P12_3_1','TP_P12_0_1')")

Ako korisnik ne sme da menja zbirno polje koristiti:

KORISTITI: TP_P12_0_1.Attributes.Add("readonly", "true"), NE KORISTITI: TP_P12_0_1.Attributes.Add("disabled", "true")







