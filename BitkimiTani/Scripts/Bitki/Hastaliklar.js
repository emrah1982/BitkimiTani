function HastaliklarParametre() {
    var hastaliklar = {};
    //<input type="radio" name="hastalikSinifi"

    hastaliklar.HastalikSinifi = $('input[name=hastalikSinifi]:checked', '#bitkiHastalikSinifi').val();
    hastaliklar.HastalikAdi = $("#txtHastalikAdi").val();
    hastaliklar.HastalikBelirtileri = $("#txtHastalikBelirtileri").val();
    //TODO radio butonunda show ve hide özellikleirni ayarla
    hastaliklar.BesinEksikligi = $('input[name=hastalikSinifi]:checked', '#bitkiHastalikSinifi').val();;
    hastaliklar.Resimleri = $("").val();//TODO Resim ekleme
}

var MineralEksikligi = $(function () {
    $('.iradio_square-grey').click(function () {
        if ($(this).is(':checked')) {
            $("#besinEksikligiMineralListesi").show();
        }
        else {
            $("#besinEksikligiMineralListesi").hide();
        }
    })
});

function ListeleHastaliklari(bitki_ID) {

    if (bitki_ID !== 0) {
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
                alert('Ekoloji Listeleme İşi Başarısız oldu Kütfen tekrar deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitki Hastaliklarini Listelemek için Bitkiyi Seçiniz...");
    }
}

function EkleHastaliklar(bitki_ID) {
    var parBitkiHastaliklari = HastaliklarParametre();
    if (bitki_ID !== 0) {
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID, parBitkiHastaliklari),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Bitki Hastaliklari Ekleme İşi Başarısız oldu Lütfen tekrar deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitki Hastaliklarini Ekleme İçin Bitkiyi Seçiniz...");
    }
}

function GuncelleHastaliklari(bitki_ID) {
    var parBitkiHastaliklari = HastaliklarParametre();
    if (bitki_ID !== 0) {
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID, parBitkiHastaliklari),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Bitki Hastaliklari Güncelleme İşi Başarısız oldu Kütfen tekrar deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitki Hastaliklarini Listelemek için Bitkiyi Seçiniz...");
    }
}

function SilHastaliklari(bitki_ID) {
    if (bitki_ID !== 0) {
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
                alert('Bitki Hastaliklari Silme İşi Başarısız oldu Lütfen Tekrar Deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitki Hastaliklarini Silmek için Bitkiyi Seçiniz...");
    }
}