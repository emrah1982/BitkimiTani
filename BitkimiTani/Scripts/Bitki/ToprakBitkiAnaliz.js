function ToprakAnaliziParametreler() {
    var toprakAnalizi = {};
    toprakAnalizi.EkilenUrunAdi = $("#txtEkilenUrunAdi").val();
    toprakAnalizi.TarimSekli = $("#txtTarimSekli").val();
    toprakAnalizi.NumuneNo = $("#txtnumuneNo").val();
    toprakAnalizi.NumuneKonumu = $("#txtNumuneKonumu").val();
    toprakAnalizi.Derinlik = $("#txtNumuneDerinlik").val();
}

function GubreTakibiParametreler() {

    var gubreTakibi = {};
    gubreTakibi.EkimGubreTavsiyesi = $("#txtEkimGubreTavsiyesi").val();
    gubreTakibi.EkimGubreMiktari = $("#txtEkimGubreMiktari").val();
    gubreTakibi.EkimGubreSerimTarihi = $("#txtEkimGubreSerimTarihi").val();
    gubreTakibi.UstGubreTavsiyesi = $("#txtUstGubreTavsiyesi").val();
    gubreTakibi.UstGubreMiktari = $("#txtUstGubreMiktari").val();
    gubreTakibi.UstGubreSerimTarihi = $("#txtUstGubreSerimTarihi").val();
}

function SuMiktariParametreler() {
    var suMiktari = {};
    suMiktari.UrunSuMiktari = $("#txtSuMiktari").val();
    suMiktari.SulamaYontemi = $("#txtSulamaYontemi").val();
    suMiktari.Alan = $("#txtAraziAlani").val();
    suMiktari.BitkiAdi = $("#txtBitkiAdi").val();
    suMiktari.SulamaAyi = $("#txtSulamaAyi").val();
    //txtBitkiKatsayisi=Kpc= Değişik bitkiler için belirlenmiş katsayı (Meyvelerde 0,80)
    suMiktari.BitkiKatsayisi = $("#txtBitkiKatsayisi").val();
    //txtBuharlasmaMiktari=Ep= Pan buharlaşma kabından ölçülen buharlaşma miktarı (mm)
    suMiktari.BuharlasmaMiktari = $("#txtBuharlasmaMiktari").val();
    suMiktari.RuzgarHizi = $("#txtRuzgarHizi").val();
    // günlük minimum nispi nem oranını detay.asp syf ekle
    suMiktari.GunlukNispiNemMin = $("#txtGunlukNispiNemMin").val();
    //Su tuketimi için Bitki Su tüketimi = Kpc.Ep
    // Dam.Sul.İleVer.SuMiktarı=Etd(0,1(Pd)0,5)
    //Etd = Günlük su tüketimi
    //Pd = Öğleyin bitkinin gölgelediği alan(%)
    //Kaynak:http://www.gencziraat.com/Sulama/Damla-Sulamada-Kullanilacak-Su-Miktari-5.html
    //Kaynak:https://www.researchgate.net/publication/272163509_Bitki_Katsayilarinin_Yerel_Iklim_Verileri_Kullanilarak_FAO-56'dan_Uyarlanmasi
} 

function ListeleGubreTakibi(kullanici_ID,arazi_ID)
{
    $.ajax({
        //TODO url'in yazım şekli dogru mu?
        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / ListeleGubreTakibi')%>",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(kullanici_ID, arazi_ID),
        dataType: "json",
        success: function (response) {
            alert("Sonuç :" + response);
        },
        error: function (x, e) {
            alert('Gübre Listeleme İşi Başarısız oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })
}
function EkleGubreTakibi() {
    var parGubreEkle = GubreTakibiParametreler();

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
            alert('Gübre Ekleme İşi Başarısız oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })

}
function GuncelleGubreTakibi(ID) {
    if (bitki_ID !== 0) {
        var parGubreGuncelle = GubreTakibiParametreler();
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleGubreTakibi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(ID, parGubreGuncelle),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Gübre Güncelleme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }

    else {
        alert("Güncellemek İçin Gübrenizi Seçiniz");
    }


}
function SilGubreTakibi(Gubre_ID) {
    if (Gubre_ID !== 0) {
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / SilGubreTakibi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(Gubre_ID),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Gübre Silme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }

    else {
        alert("Güncellemek İçin Bitki Adınız Seçiniz");
    }

}

function ListeleSuMiktari(kullanici_ID,arazi_ID) {
    $.ajax({
        //TODO url'in yazım şekli dogru mu?
        //TODO tarlasına gore secim yapılacak
        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / ListeleSuMiktari')%>",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(kullanici_ID, arazi_ID),
        dataType: "json",
        success: function (response) {
            alert("Sonuç :" + response);
        },
        error: function (x, e) {
            alert('Su Miktari Listeleme İşi Başarısız oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })
}
function EkleSuMiktari() {
    var parSuMiktariEkle = SuMiktariParametreler();

    $.ajax({
        //TODO url'in yazım şekli dogru mu?

        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleSuMiktari')%>",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(parSuMiktariEkle),
        dataType: "json",
        success: function (response) {
            alert("Sonuç :" + response);
        },
        error: function (x, e) {
            alert('Su Miktari Ekleme İşi Başarısız oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })

}
function GuncelleSuMiktari(SuMiktari_ID) {
    if (SuMiktari_ID !== 0) {
        var parSuMiktariGuncele = SuMiktariParametreler();
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleSuMiktari')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(ID, parSuMiktariGuncele),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Su Miktari Güncelleme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })

    }
    else {
        alert("Güncelleme İçin Seçim Yapınız");
    }
}
function SilSuMiktari(SuMiktari_ID) {
    if (SuMiktari_ID != 0) {
        $.ajax({
            //TODO url kısmını düzenle
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / SilSuMiktari')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(SuMiktari_ID),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Su Miktari Güncelleme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }


        })
    }
}

function ListeleToprakAnalizi(kullanici_ID) {
    $.ajax({
        //TODO url'in yazım şekli dogru mu?
        //TODO tarlasına gore secim yapılacak
        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / ListeleToprakAnalizi')%>",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(kullanici_ID),
        dataType: "json",
        success: function (response) {
            alert("Sonuç :" + response);
        },
        error: function (x, e) {
            alert('Toprak Analizi Listeleme İşi Başarısız Oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })
}
function AraziToprakAnaliziListesi(arazi_ID) {
    $.ajax({
        //TODO url'in yazım şekli dogru mu?
        //TODO tarlasına gore secim yapılacak
        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / ListeleToprakAnalizi')%>",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(arazi_ID),
        dataType: "json",
        success: function (response) {
            alert("Sonuç :" + response);
        },
        error: function (x, e) {
            alert('Toprak Analizi Listeleme İşi Başarısız Oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })
}
function EkleToprakAnalizi() {
    var parToprakAnaliziEkle = ToprakAnaliziParametreler();

    $.ajax({
        //TODO url'in yazım şekli dogru mu?

        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleGubreTakibi')%>",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(parToprakAnaliziEkle),
        dataType: "json",
        success: function (response) {
            alert("Sonuç :" + response);
        },
        error: function (x, e) {
            alert('Toprak Analizi Ekleme İşi Başarısız oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })
}
function GuncelleToprakAnalizi(toprakAnalizi_ID) {
    var parToprakAnaliziGuncelle = ToprakAnaliziParametreler();
    if (toprakAnalizi_ID !== 0) {
        $.ajax({
            $.ajax({
                //TODO url kısmını düzenle
                url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleSuMiktari')%>",
                type: "POST",
                contentType: "application/json;charset=utf-8",
                data: JSON.stringify(toprakAnalizi_ID, parToprakAnaliziGuncelle),
                dataType: "json",
                success: function (response) {
                    alert("Sonuç :" + response);
                },
                error: function (x, e) {
                    alert('Su Miktari Güncelleme İşi Başarısız oldu.');
                    alert(x.responseText);
                    alert(x.status);
                }
            })

        })
    } 
    else {
        alert("Güncelleme İçin Seçim Yapınız"); 
    }
} 
function SilToprakAnalizi(toprakAnalizi_ID)
{
    if (toprakAnalizi_ID !== 0) {
        $.ajax({
            $.ajax({
                //TODO url kısmını düzenle
                url: "<%=Page.ResolveUrl('/ api / BitkiAdi / SilToprakAnalizi')%>",
                type: "POST",
                contentType: "application/json;charset=utf-8",
                data: JSON.stringify(toprakAnalizi_ID),
                dataType: "json",
                success: function (response) {
                    alert("Sonuç :" + response);
                },
                error: function (x, e) {
                    alert('Toprak Analizi Silme İşi Başarısız oldu.');
                    alert(x.responseText);
                    alert(x.status);
                }
            })

        })
    }
    else {
        alert("Silme İçin Seçim Yapınız");
    }

}