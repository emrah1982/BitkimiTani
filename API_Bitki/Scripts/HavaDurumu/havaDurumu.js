//function havaDurumuParametre() {
//    var havaDurumu = {};
//    havaDurumu.İl = $("#").val();
//    havaDurumu.İlce = $("#").val();
//}

function HavaDurumuSonuc(Kullanici_ID) {
    var parHavaDurumu = havaDurumuParametre();
    if (Kullanici_ID !== 0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / HavaDurumunuListele')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(parHavaDurumu, Kullanici_ID),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Bölgenize Ait Hava Durumu Görüntüleme İşlemi İsteğiniz Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Lütfen Kullanıcı Girişinizi Yapınız");
    }

}