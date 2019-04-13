<reference path='<%= Page.ResolveUrl("~/ayarlar/baglantikontrolu.js")%>' />



var loginParametre = class LoginParameter {
    constructor(parKullaniciID, parEmail, parSifre, parAd, parSoyad, parSehir, parCeptelefonu, parAdres) {
        this._parKullaniciID = parKullaniciID;
        this._parEmail = parEmail;
        this._parSifre = parSifre;
        this._parAd = parAd;
        this._parSoyad = parSoyad;
        this._parSehir = parSehir;
        this._parCeptelefonu = parCeptelefonu;
        this._parAdres = parAdres;

        kullaniciGetir = function () { return this._parEmail, this._parSifre };
        KullaniciEkle = function () { return this._parAd, this._parSoyad, this._parSehir, this._parCeptelefonu, this._parAdres };
   
    }
}

function VerileriTemizle() {
    loginParametre.remove();
}

var Basarili = function (data) {

    alert("Sonuç :" + data);
}

var Hata = function (err, e) {
    alert(err.responseText);
    alert(err.status + " " + err.statusText);
}

$.ajaxSetup({
    type: "POST",
    contentType: "application/json;charset=utf-8",
    dataType: "json",
});

loginParametre.prototype.KullaniciGirisi = function () {
    
    if (BaglantiVarMi() == true) {
        $.ajax({
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / KullaniciGiris')%>",
            headers: { Authorization: "Basic" + btoa(parEmail + ":" + parSifre) },//Mantığı nedir?
            data: JSON.stringify(this.kullaniciGetir),//Parametre alma işi dogru ve mantıklı mı?           
            success: Basarili(
                bilgiler = jQuery.parseJSON(e.d),
                sessionStorage.setItem("Kullanici Numarasi", e.KullaniciID), //Burda session yönetimi yapmak istiyorum asp.net tarafında mı olacak                
                
                adsoyad.val(bilgiler.Ad + " " + bilgiler.Soyad),
                kullaniciResmi.val(bilgiler.Resim),
                //$(location).attr('href', 'BitkiDetay.aspx'), burda olması mantıklı gelmiyor? Ne yapabilirim?
                alert("Hoşgeldiniz" + " "),
            ),
            error: Hata(
                alert(' Kullanıcı Bilgilerinizi Kontrol Ediniz Lütfen... Giriş İşleminiz Başarısız oldu.')
            )
        })
    }
}