function EkolojiParametre()
{
    var ekoloji = {};
    ekoloji.Iklim = $("#txtIklim").val();
    ekoloji.IsikSeviyesi = $("#txtIsikSeviyesi").val();
    ekoloji.Sicaklik = $("#txtSicaklik").val();
    ekoloji.Nem = $("#txtNem").val();
    ekoloji.Gorunus = $("#txtGorunus").val();
    ekoloji.Ca = $("#txtCa").val();
    ekoloji.P = $("#txtP").val();
    ekoloji.SOC = $("#txtSOC").val();
    ekoloji.ToprakYapisi = $("#txtToprakYapisi").val();
    ekoloji.ToprakPh = $("#txtToprakPh").val();
    ekoloji.SuIhtiyaci = $("#txtSuIhtiyaci").val();//TODO checkBox kullanımı olacak
}

function ListeleEkoloji(bitki_ID) {
    if (bitki_ID !== 0) {
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(parEkoloji),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Ekoloji Listeleme İşi Başarısız oldu Kütfen tekrar deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Ekoloji Bilgileri Listelemek İçin Lütfen Bitki Seçiniz");
    }

}
function EkleEkoloji(bitki_ID)
{
    var parEkoloji = EkolojiParametre();
    if (bitki_ID!==0) {
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(parEkoloji),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Ekoloji Ekleme İşi Başarısız oldu Kütfen tekrar deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Ekoloji Bilgileri Ekleyebilmek İçin Lütfen Bitki Seçiniz");
    }

} 
function GuncelleEkoloji(bitki_ID) {
    var parEkoloji = EkolojiParametre();
    if (bitki_ID!==0) {
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID, parEkoloji),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Ekoloji Ekleme İşi Başarısız oldu Kütfen tekrar deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Ekoloji Bilgileri Ekleyebilmek İçin Lütfen Bitki Seçiniz");
    }

} 
