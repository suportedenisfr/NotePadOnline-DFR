 function SaveTxt() {
	 //extraindo valores digitados
	 var Sessao = document.getElementById("txtsessao").value;
	 var Texto = document.getElementById("txtarea").value;
	 
	 if (!Sessao)
	 {
	 	document.getElementById("txtsessao").value = "";
		document.getElementById("txtsessao").focus();
		
		alert("Atenção!! Não é possível gravar/atualizar uma Sessão vazia! Verifique!");
	 }
	 else
	 {
		 //gravar sessão e texto 
		 $.getJSON("http://localhost/wcfnotepad/Service1.svc/SaveText", {id:Sessao,texto:Texto},
		   function (data) {
		   }
		 );
			  
		 window.location.href = window.location.href.split('?')[0]+"?id="+Sessao;
	 }
 }
 
 function ReturnTxt() {
	//extraindo valores digitados
	var Sessao = getParameterByName('id');
	 
    //gravar sessão e texto 
	$.getJSON("http://localhost/wcfnotepad/Service1.svc/ReturnText", {id:Sessao},
        function (data) {
			 document.getElementById("txtarea").value = data.ReturnTextResult;
			 document.getElementById("txtsessao").value = Sessao;
        }
	);
 }	

 function getParameterByName(name, url) {
    if (!url) {
      url = window.location.href;
    }
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
 }	
