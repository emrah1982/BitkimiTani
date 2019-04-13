function MorfolojiDegiskenler()
{
    var morfoloji = {};
    morfoloji.FamilyaHakkindaBilgi = $("#txtFamilyaHakkindaBilgi").val();
    morfoloji.CiceklenmeZamani = $("#txtCiceklenmeZamani").val();
    morfoloji.YaprakTipi = $(".")//TODO checkbox seçimini yapmaya çalış
    morfoloji.Kokusu = $("#txtKokusu").val();
    morfoloji.EnYuksekRakim = $("#txtEnYuksekRakim").val();
    morfoloji.EnDusukRakim = $("#txtEnDusukRakim").val();
    morfoloji.EnUzunBoy = $("#txtEnUzunBoy").val();
    morfoloji.YaprakDizilisi = $("#txtYaprakDizilisi").val();
    morfoloji.Budama = $("#txtBudama").val();
    morfoloji.MeyveTipi = $("txtMeyveTipi").val();
    morfoloji.DalFormu = $("txtDalFormu").val();
    morfoloji.Cicek = $("txtCicek").val();
    morfoloji.CicekRengi = $("txtCicekRengi").val();
    morfoloji.CiceklilikSuresi = $("#txtCiceklilikSuresi").val();
}

function ListeleMorfoloji(bitki_ID) {
    if (bitki_ID!==0) {
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Bitkinizin kullanım Alanlari Listeleme İşi Başarısız oldu Lütfen Tekrar D eneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Morfoloji Bilgilerini Listelemek İçin Bitkinizi Seçiniz...");
    }
} 

function EkleMorfoloji(bitki_ID) {
    if (bitki_ID !== 0) {
        var parMorfoloji = MorfolojiDegiskenler();
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID, parMorfoloji),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Bitkinizin Morfoloji Bilgilerini Ekleme İşi Başarısız Oldu Lütfen Tekrar Deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Morfoloji Bilgilerini Listelemek İçin Bitkinizi Seçiniz...");
    }
}

function GuncelleMorfoloji(bitki_ID) {
    if (bitki_ID !== 0) {
        var parMorfoloji = MorfolojiDegiskenler();
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID, parMorfoloji),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Bitkinizin Morfoloji Bilgilerini Güncelleme İşi Başarısız Oldu Lütfen Tekrar Deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Morfoloji Bilgilerini Listelemek İçin Bitkinizi Seçiniz...");
    }
}