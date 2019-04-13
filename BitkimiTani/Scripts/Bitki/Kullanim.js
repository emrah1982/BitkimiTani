function KullanimParametre()
{
    var kullanim = {};
    kullanim.bitki_ID=//TODO session dan alamya çalış
    kullanim.KullanimAlanlari = $("#txtKullanimAlani").val();
    kullanim.PeyzajdaKullanim = $("#txtPeyzajdaKullanim").val();
    kullanim.SecilenKullanim = $("").val();//TODO radio buton secimleri
}

function ListeleKullanim(bitki_ID) {
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
        alert("Kullanim alanı belirlemek için Bitkinizi Seçiniz...");
    }
} 

function EkleKullanim(bitki_ID) {
    var parKullanim = KullanimParametre();
    if (bitki_ID!==0) {
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID,parKullanim),
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
        alert("Kullanım Alanını Görebilmek için Bitkinizi Seçiniz...");
    }
} 

function GuncelleKullanim(bitki_ID) {
    var parKullanim = KullanimParametre();
    if (bitki_ID !== 0) {
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID, parKullanim),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Bitkinizin kullanım Alanlari Güncelleme İşi Başarısız oldu Lütfen Tekrar Deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }

    else {
        alert("Kullanım Alanını Güncelleye Bilmek için Bitkinizi Seçiniz...");
    }

}