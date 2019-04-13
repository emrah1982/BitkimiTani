function Uretim()
{
    var uretim = {};
    uretim.VideoLink = $("#txtVideoLink").val();
    uretim.TohumlaUretim = $("#txtTohumlaUretim").val();
    uretim.UretimYontemleri = $("#txtUretimYontemleri").val();
    uretim.TohumlaCimlenmeSicakligi = $("#txtTohumlaCimlenmeSicakligi").val();
    uretim.TohumDikimDerinligiMin = $("#txtTohumDikimDerinligiMin").val();
    uretim.TohumDikimDerinligiMax = $("#txtTohumDikimDerinligiMax").val();
    uretim.GelisimHizi = $("#txtGelisimHizi").val();
    uretim.SogukKusak = $("#txtSogukKusak").val();
    uretim.SicakKusak = $("#txtSicakKusak").val();
    uretim.YillikSicaklikGunSayisi = $("#txtYillikSicaklikGunSayisi").val();
    uretim.SogukKusakResmi = $("#").val();//TODO resim ekleme
    uretim.SicakKusakResmi = $("#").val();//TODO resim ekleme
    uretim.SogugaDayaniklilikSicaklikAraligi = $("#txtSogugaDayaniklilikSicaklikAraligi").val();//TODO ekle detay sayfasına
    uretim.Sulama = $("#txtSulama").val();//TODO checkBox cevir
    uretim.BakimIhtiyaci = $("#txtBakimIhtiyaci").val();//TODO checkbox olacak
    uretim.MevsimineGore = $("#").val();//TODO dönemleri checkbox ile secilecek Detay asp syf da degistir

}

function ListeleUretim(bitki_ID) {
    if (bitki_ID!==0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleGubreTakibi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(parGubreEkle),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Üretim Yöntemleri Listeleme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitkinizin Üretimi Hakkında Bilgi Almak için Bitkinizi Seçiniz...");
    }
} 
function EkleUretim(bitki_ID) {
    if (bitki_ID !== 0) {
        var parUretim = Uretim();
        $.ajax({
            //TODO url'in yazım şekli dogru mu?

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleGubreTakibi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID,parUretim),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Üretim Yöntemleri Ekleme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitkinizin Üretimi Hakkında Bilgi Eklmek İçin Bitkinizi Seçiniz...");
    }
}
function GuncelleUretim(bitki_ID) {
    if (bitki_ID !== 0) {
        var parUretim = Uretim();
        $.ajax({
            //TODO url'in yazım şekli dogru mu?

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleGubreTakibi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID, parUretim),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Üretim Yöntemleri Güncelleme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitkinizin Üretimi Güncellemek İçin Bitkinizi Seçiniz...");
    }
}