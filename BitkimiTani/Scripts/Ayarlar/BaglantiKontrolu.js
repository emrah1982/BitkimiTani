//TODO master page de body de ononline ve onofline kütüpnesini cagýrcaksýn
function BaglantiVarMi() {
    var methodAdi = null;
    url: "<%=Page.ResolveUrl('http://localhost:xxxx/ api /'" + methodAdi + "')%>";
    if (window.navigator.onLine) {
        //$("#BaglantiKontrolu").innerHTML = "internet Baglantýsý Var"
        alert("Ýnternet Baglantisi Var");
        //console.log("Ýnternet Baglantisi Var");
    }
    else {
        // $("#BaglantiKontrolu").innerHTML = "internet Baglantisi Yok"
        alert("Ýnternet Baglantisinizi Kontrol Ediniz.");
    }
}
