//TODO master page de body de ononline ve onofline k�t�pnesini cag�rcaks�n
function BaglantiVarMi() {
    var methodAdi = null;
    url: "<%=Page.ResolveUrl('http://localhost:xxxx/ api /'" + methodAdi + "')%>";
    if (window.navigator.onLine) {
        //$("#BaglantiKontrolu").innerHTML = "internet Baglant�s� Var"
        alert("�nternet Baglantisi Var");
        //console.log("�nternet Baglantisi Var");
    }
    else {
        // $("#BaglantiKontrolu").innerHTML = "internet Baglantisi Yok"
        alert("�nternet Baglantisinizi Kontrol Ediniz.");
    }
}
