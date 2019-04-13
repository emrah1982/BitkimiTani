function BitkiTanimaParametre()
{
    var bitkiTanima = {};

    bitkiTanima.BitkiTipi = $("#txtBitkiTipi").val();
    bitkiTanima.ArsizlikDurumu = $("#txtArsizlikDurumu").val();
    bitkiTanima.AnavataniDogalYayilisAlanlariIhtiyac = $("#txtAnavataniDogalYayilisAlanlariIhtiyac").val();
    bitkiTanima.YetistigiSehir = $("#txtYetistigiSehir").val();
    bitkiTanima.TurkiyedeDogalYasamAlani = $("#txtTurkiyedeDogalYasamAlani").val();
    bitkiTanima.YasamSuresi = $("#txtYasamSuresi").val();
    bitkiTanima.ToksikOzellikler = $("#txtToksikOzellikler").val();
    bitkiTanima.HangiDonem = $("#txtHangiDonem").val();
    bitkiTanima.BitkiYetismeAlanlari = $("#txtBitkiYetismeAlanlari").val();
    bitkiTanima.TehditAltindami = $("input[radio=type]:checked").val();//TODO radio buton secimi yanlış düzelt?
}

function EkleBitkiTanima()
{
    var parBitkiTanima = BitkiTanimaParametre();

    $.ajax({
        //TODO url'in yazım şekli dogru mu?
        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleProfilBilgileri')%>",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(parBitkiTanima),
        dataType: "json",
        success: function (response) {
            alert("Sonuç :" + response);
        },
        error: function (x, e) {
            alert('Bitki T anıma Ekleme İşi Başarısız oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })

} 

function GuncelleBitkiTanima(bitki_ID)
{
    var parBitkiTanima = BitkiTanimaParametre();
    if (bitki_ID!==0) {
        $.ajax({ 
            //TODO url'in yazım şekli dogru mu?
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleProfilBilgileri')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID,parBitkiTanima),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Bitki T anıma Ekleme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitki Tanıma da Güncelleme İşi Yapabilmek İçin Bitkiyi Seçiniz.... ");
    }
} 

function SilBitkiTanima(bitki_ID)
{
    if (bitki_ID !== 0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleProfilBilgileri')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(bitki_ID),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Bitki Tanıma Silme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Bitki Tanıma da Silme İşi Yapabilmek İçin Bitkiyi Seçiniz.... ");
    }

}