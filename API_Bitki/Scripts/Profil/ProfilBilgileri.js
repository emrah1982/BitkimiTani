function ProfilBilgilerParametre() {
    var profilBilgileri = {};
    profilBilgileri.Ad = $("#txtAd").val();
    profilBilgileri.Soyad = $("#txtSoyad").val();
    profilBilgileri.CepTelefonu = $("#txtCeptelefonu").val();
    profilBilgileri.Unvan = $("#txtUnvan").val();
    profilBilgileri.Email = $("#txtEmail").val();
    profilBilgileri.WebSitesi = $("#txtWebAdresi").val();
    profilBilgileri.Resim = $("#txtResim").val();
}

function SifreDegisimParametre()
{
    var sifreDegisimi = {};
    sifreDegisimi.MevcutSifre = $("#txtMevcutSifre").val();
    sifreDegisimi.YeniSifre = $("#txtYeniSifre").val();
}

function GruplarParametre()
{
    var gruplar = {};
    gruplar.GrupAdi = $("#txtGrupAdi").val();
}

function ArazilerimParametre()
{
    var arazilerim = {};
    arazilerim.Il = $("#txtIl").val();
    arazilerim.Ilce = $("#txtIlce").val();
    arazilerim.Ada = $("#txtAdNo").val();
    arazilerim.PaftaNo = $("#txtPatfaNo").val();
    arazilerim.AraziOlcusu = $("#txtAraziOlcusu").val();
} 
//TODO dogru mu ?
var score = 0;
function Favorilerim() {       
    score += 1;
    $("#favoriArtir")[0].innerHTML = score;
}



function ListeleProfilBilgileri(kullaniciBilgileri_ID) {
    if (kullaniciBilgileri_ID!==0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleProfilBilgileri')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(kullaniciBilgileri_ID),
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
    else {
        alert("Lütfen Kullanıcı Girişi Yapınız.")
    }
}
function EkleProfilBilgileri(kullaniciBilgileri_ID)
{
    if (kullaniciBilgileri_ID!==0) {
        var parEkleProfilBilgileri = ProfilBilgilerParametre();
        $.ajax({
            //TODO url'in yazım şekli dogru mu?

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleProfilBilgileri')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(parEkleProfilBilgileri),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Kullanıcı Girişi Ekleme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Kullanici Girişi Yapınız ")
    }

}
function GuncelleProfilBilgileri(profilBilgileri_ID)
{
    if (profilBilgileri_ID!==0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleProfilBilgileri')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(parEkleProfilBilgileri),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Profil Bilgileri Güncelleme İşlemi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })




    }
    else {
        alert("Profil Bilgileri Güncelleme İçin Profil Seçiniz...");
    }

}

function EkleSifreEkle()
{
    $.ajax({
        //TODO url'in yazım şekli dogru mu?
        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleSifreEkle')%>",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(parSifre),
        dataType: "json",
        success: function (response) {
            alert("Sonuç :" + response);
        },
        error: function (x, e) {
            alert('Şifre Ekleme İşlemi Başarısız oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })


}
function GuncelleSifre(kullanici_ID)
{
    
    var parSifre = SifreDegisimParametre();
    if (kullanici_ID!==0)    {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleSifre')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(parSifre),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Şifre Ekleme İşlemi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })

    }
    else {
        alert("Lütfen Giriş Yapınız");
    }
}

function ListeGruplar(kullanici_ID)
{
    if (kullanici_ID !== 0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleSifre')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(kullanici_ID),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Grup Listeleme İşlemi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Gurp Listeleme İşlemi için Lütfen Giriş Yapınız. ")
    }
}
function EkleGrupOlustur()
{
    var parGrupOlustur = GruplarParametre();
    $.ajax({
        //TODO url'in yazım şekli dogru mu?
        url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleSifre')%>",
        type: "POST",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(parGrupOlustur),
        dataType: "json",
        success: function (response) {
            alert("Sonuç :" + response);
        },
        error: function (x, e) {
            alert('Şifre Ekleme İşlemi Başarısız oldu.');
            alert(x.responseText);
            alert(x.status);
        }
    })

} 
function GuncelleGrupOlustur(grup_ID)
{

    if (grup_ID!==0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleSifre')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(grup_ID),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Grup Güncelleme  İşlemi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Gurp güncellemesi için Lütfen Seçim yapınız. ")
    }
} 
function SilGrup(grup_ID)
{
    if (grup_ID !== 0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleSifre')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(grup_ID),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Grup Silme İşlemi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Gurp Silme İşlemi için Lütfen Seçim yapınız. ")
    }

} 

function ListeleAraziBilgileri(kullaniciBilgileri_ID) {
    if (kullaniciBilgileri_ID !== 0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleProfilBilgileri')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(kullaniciBilgileri_ID),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Arazi Listeleme  İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Lütfen Kullanıcı Girişi Yapınız.")
    }

}
function GuncelleAraziBilgileri() {
    var parAraziBilgileri = ArazilerimParametre();
    if (kullaniciBilgileri_ID !== 0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleProfilBilgileri')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(parAraziBilgileri, kullaniciBilgileri_ID),
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
    else {
        alert("Lütfen Kullanıcı Girişi Yapınız.")
    }

}
function EkleAraziBilgileri() {
    var parAraziBilgileri = ArazilerimParametre();
    if (kullaniciBilgileri_ID !== 0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / AraziBilgileriEkle')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(parAraziBilgileri, kullaniciBilgileri_ID),
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
    else {
        alert("Lütfen Kullanıcı Girişi Yapınız.")
    }

}
function SilAraziBilgileri(parArazi_ID) {
    if (kullaniciBilgileri_ID !== 0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / AraziBilgileriEkle')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(parArazi_ID),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Arazi Silme işlemi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Lütfen Kullanıcı Girişi Yapınız.")
    }


}