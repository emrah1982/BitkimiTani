function ZararlilarParametre()
{
    var zararlilar = {};
    zararlilar.ZararliSinifi = $("").val();
    zararlilar.ZararliAdi = $("#txtZararliAdi").val();
    zararlilar.ZararliHakkindaAciklama = $("#txtZararliHakkindaAciklama").val();
    zararlilar.ZararliResim = $("").val();//TODO zararli resim ekleme
}

function ListeZararlilar(bitki_ID) {
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
                alert('Bitki Zararlıları Hakkında Listeleme  İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitki Zararlıları Hakkında Listeleme Yapmak için Bitkinizi Seçiniz...");
    }
} 

function EkleZararlilar(bitki_ID) {
    if (bitki_ID !== 0) {
        var parEkleZararli = ZararlilarParametre();
        $.ajax({
            //TODO url'in yazım şekli dogru mu?
            
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleGubreTakibi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID, parEkleZararli),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Bitki Zararlıları Hakkında Ekleme   İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }

    else {
        alert("Bitki Zararliları Eklemek için Bitkinizi Seçiniz");
    }
} 

function GuncelleZararlilar(bitki_ID) {
    if (bitki_ID !== 0) {
        var parGuncelleZararli = ZararlilarParametre();
        $.ajax({
            //TODO url'in yazım şekli dogru mu?

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleGubreTakibi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID, parGuncelleZararli),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Bitki Zararlıları Hakkında Güncelleme   İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }

    else {
        alert("Bitki Zararliları Güncellemek için Bitkinizi Seçiniz");
    }
} 