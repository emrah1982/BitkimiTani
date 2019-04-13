function EkBilgilerParametre()
{
    var ekBilgiler = {};
    ekBilgiler.EkonomikOnemi = $("#txtEkonomikOnemi").val();
    ekBilgiler.Notlar = $("#txtNotlar").val();
    ekBilgiler.Kaynaklar = $("#txtKaynaklar").val();
    ekBilgiler.KokBilgisi = $("#txtKokBilgisi").val();
    ekBilgiler.Govde = $("#txtGovdeBilgisi").val();
    ekBilgiler.Yaprak = $("txtYaprakBilgisi").val();
    ekBilgiler.Cicek = $("txtCicekBilgisi").val();
}

function ListeleEkBilgiler(bitki_ID) {
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
            alert('Bitki Adı Silme İşi Başarısız oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })
} 
function EkleEkBilgiler()
{
    var parEkBilgiler = EkBilgilerParametre();

    $.ajax({
        //TODO url kısmını düzenle
        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(parEkBilgiler),
        dataType: "json",
        success: function (response) {
            alert("Sonuç :" + response);
        },
        error: function (x, e) {
            alert('Bitki Adı Silme İşi Başarısız oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })


}
function GuncelleEkBilgiler(bitki_ID)
{
    if (bitki_ID!==0) {
        var parEkBilgiler = EkBilgilerParametre();

        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID,parEkBilgiler),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Ek Bilgi Güncelleme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })

    }
    else {
        alert("Ek Bilgi Girişi için Bitkiyi Seçiniz...");
    }

}