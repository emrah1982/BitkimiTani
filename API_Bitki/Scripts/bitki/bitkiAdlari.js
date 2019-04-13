function BitkiAdDegiskenleri() {
    var BitkiAdi = {};

    BitkiAdi.TurkceAdi = $("#txtTurkceAdi").val();
    BitkiAdi.LatinceAdi = $("#txtLatinceAdi").val();
    BitkiAdi.SinonimAdi = $("#txtSinonimAdi").val();
    BitkiAdi.YerelAdi = $("#txtYerelAdi").val();
    BitkiAdi.IngilizceAdi = $("#txtIngilizceAdi").val();
}

function EkleBitkiAdlari() {
    //Bu mantık dogrumu functionda degişken tanımlayıp burd afunction olarak olmak
    var degerler = BitkiAdDegiskenleri();

    $.ajax({
        //TODO url'in yazım şekli dogru mu?
        
        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleBitkiAdi')%>",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(degerler),
        dataType: "json",
        success: function (response) {
            alert("Sonuç :" + response);
        },
        error: function (x, e) {
            alert('Bitki Adı Ekleme İşi Başarısız oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })

}

function GuncelleBitkiAdlari(bitki_ID) {
    var BitkiAdi = {};

    BitkiAdi.TurkceAdi = $("#txtTurkceAdi").val();
    BitkiAdi.LatinceAdi = $("#txtLatinceAdi").val();
    BitkiAdi.SinonimAdi = $("#txtSinonimAdi").val();
    BitkiAdi.YerelAdi = $("#txtYerelAdi").val();
    BitkiAdi.IngilizceAdi = $("#txtIngilizceAdi").val();


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
                alert('Bitki Adı Silme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }

    else {
        alert("Güncellemek İçin Bitki Adınız Seçiniz");
    }
}

function SilBitkiAdlari(bitki_ID)
{
    if (bitki_ID !==0) {
        $.ajax({
            //TODO url kısmını düzenle

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / SilBitkiAdi')%>",
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
    else {
        alert("Silmek istediğiniz bitki adını seçiniz lütfen");
    }
}

function ListeleBitkiAdlari() {
    $.ajax({
        //TODO url kısmını ve listeleme için düzenleme yapılacak

        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / ListelemeBitkiAdi')%>",
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

function GetirBitkiAdi() {
    if (bitki_ID !== 0) {
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GetirBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Seçilen Bitki Adı Getirilme İşlemi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Görüntülemek istediğiniz bitki adını seçiniz lütfen");
    }

}