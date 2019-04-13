function Sistematik()
{
    var sistematik = {};
    sistematik.Alem = $("#txtAlem").val();
    sistematik.Bolum = $("#txtBolum").val();
    sistematik.Sinif = $("#txtSinif").val();
    sistematik.Takim = $("#txtTakim").val();
    sistematik.Familya = $("#txtFamilya").val();
    sistematik.Cins = $("#txtCins").val();
    sistematik.Tur= $("#txtTur").val();
    sistematik.AltTurleri = $("#txtAltTurleri").val();
}

function ListeleSistematik(bitki_ID) {
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
                alert('Bitkinizin Sistematik Alanlari Listeleme İşi Başarısız oldu Lütfen Tekrar Deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitki Sistematik Bilgilerini Listeyebilmek İçin Bitkinizi Seçiniz...");
    }
} 
function EkleSistematik(bitki_ID) {
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
                alert('Bitkinizin Sistematik Alanlari Ekleme İşi Başarısız oldu Lütfen Tekrar Deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitki Sistematik Bilgilerini Eklemek İçin Bitkinizi Seçiniz...");
    }
} 
function GuncelleSistematik(bitki_ID) {
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
                alert('Bitkinizin Sistematik Alanlari Güncelleme İşi Başarısız oldu Lütfen Tekrar Deneyiniz');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitki Sistematik Bilgilerini Güncellemek İçin Bitkinizi Seçiniz...");
    }
}