Korisne stvari iz JS:

	var suma = 0;
	suma =s1 + s2 + s3;
1)	//zaokruzivanje   
	document.getElementById(LABELAnaFORMI).innerHTML = parseFloat(Math.max(0, Math.round(suma)));	
        document.getElementById(TEXTBOXnaFORMI).value = parseFloat(Math.max(0, Math.round(suma)));	
    	
2)	//poruka
	alert(suma); 

3)	//pitanje da li je objD<> ""     objD.value != "" ili isNaN(a) == true    (NaN 	je "Not-a-Number" value)
	if (objD.value != "") {
        	kod...
    	}

	
4)	//<> je !=
	//=  je ==

5)	//Number() 	Converts an object's value to a number
	//parseFloat() 	Parses a string and returns a floating point number
	//parseInt() 	Parses a string and returns an integer
	//String() 	Converts an object's value to a string



6) Disabled attribute
    Disabled form fields or elements values don’t post to the server for processing.
    Some browsers (Like IE) provide default style (Gray out or emboss text) for disabled form fields or elements.
   Read Only Attribute
    Read Only form fields or elements values post to the server for processing.
    Some browsers do not provide default style for Read-Only form fields or elements.


7) Aritmetički operatori:

+ 	Addition 			x = y + 2 	y = 5 	x = 7 	
- 	Subtraction 			x = y - 2 	y = 5 	x = 3 
* 	Multiplication 			x = y * 2 	y = 5 	x = 10
/ 	Division 			x = y / 2 	y = 5 	x = 2.5 
% 	Modulus (division remainder) 	x = y % 2 	y = 5 	x = 1 	

8) Poređenja:

ako je x=5

== 	equal to 				x == 8 		false ;	x == 5 		true 	 
=== 	equal value and equal type 		x === "5" 	false ;	x === 5 	true 	
!= 	not equal 				x != 8 		true 	
!== 	not equal value or not equal type 	x !== "5" 	true  ;	x !== 5 	false 
> 	greater than 				x > 8 		false 	
< 	less than 				x < 8 		true 	
>= 	greater than or equal to 		x >= 8 		false 	 
<= 	less than or equal to 			x <= 8 		true 


9) IIF ili case when... then...else...end

	variablename = (condition) ? value1:value2 	voteable = (age < 18) ? "Too young":"Old enough";

10) Logički operatori

	&& 	and 	(x < 10 && y > 1) is true
	|| 	or 	(x == 5 || y == 5) is false
	! 	not 	!(x == y) is true

11) IF ...THEN...ELSE

 if (condition) {
    block of code to be executed if the condition is true
}


if (condition) {
    block of code to be executed if the condition is true
} else {
    block of code to be executed if the condition is false
}


if (condition1) {
    block of code to be executed if condition1 is true
} else if (condition2) {
    block of code to be executed if the condition1 is false and condition2 is true
} else {
    block of code to be executed if the condition1 is false and condition2 is false
}


var time = new Date().getHours();
if (time < 20) {
    greeting = "Good day";
} else {
    greeting = "Good evening";
} 



12) da prebacite fokus tamo gde vi hoćete, a ne gde vas IST vodi (on sa enter ide na sledeće polje preko JS opet)

           window.setTimeout(function () {

                   document.getElementById('CBO_LOKACIJA').focus();

               }, 10);

