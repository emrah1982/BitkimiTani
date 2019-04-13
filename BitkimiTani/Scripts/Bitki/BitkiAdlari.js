<reference path='<%= Page.ResolveUrl("~/ayarlar/baglantikontrolu.js")%>' />

//Önemli incele tekrar eden ajaxların önüne geçmek için kullanacaksın kaynak: https://codereview.stackexchange.com/questions/51289/reusable-ajax-object 
// 1 yol
var degiskenler = function BitkiAdDegiskenleri(turkceAdi, latinceAdi, sinonimAdi, yerelAdi, ingilizceAdi) {
    this._TurkceAdi = turkceAdi;
    this._LatinceAdi = latinceAdi;
    this._SinonimAdi = sinonimAdi;
    this._YerelAdi = yerelAdi;
    this._IngilizceAdi = ingilizceAdi;

     
  


    bitkiAdiEkle = function EkleBitkiAdlari() {
        ADdegiskenler = function () {
            return this._TurkceAdi + ' ' +
                this._LatinceAdi + ' ' +
                this._SinonimAdi + ' ' +
                this._YerelAdi + ' ' +
                this._IngilizceAdi;
        }
        if (BaglantiVarMi() == true) {
            $.ajax({
                url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleBitkiAdi')%>",
                type: "POST",
                contentType: "application/json;charset=utf-8",
                data: JSON.stringify(ADdegiskenler),
                dataType: "json",
                beforeSend: function () { /*https://www.youtube.com/watch?v=bzyqfoDd9a0*/ },
                success: function (data, status, jqXHR) {
                    //this.results = data;
                    //setResult(self.results);
                    $('form').trigger("reset");
                    var statusCode = jqXHR.status;
                    var statusText = jqXHR.statusText;
                    alert("Sonuç :" + data);
                    alert(statusCode + statusText);
                },
                statusCode: {
                    200: function () {
                        // AfterSavedAll();
                        alert("Verileriniz başarılı bir şekilde kaydedildi");
                    },
                    400: function () {
                        alert("Sayfa Bulunamadı.");
                        asd.alert('<span style="color:Red;">Kayıt işlemi Sırasında Hata Oluştu Lütfen Tekrar Deneyiniz.</span > ', function () { });
                    },
                    404: function () {
                        asd.alert('<span style="color:Red;">Error While Saving Outage Entry Please Check</span>', function () { });
                    },

                    error: Hata(
                        alert('Bitki Adı Ekleme İşi Başarısız oldu.')
                    )
                }
            })
        }


    }

    var Hata = function (x, e) {
        alert(x.responseText);
        alert(x.status);
    };

    var Basarili = function (data, textStatus, jqXHR) {
        //this.results = data;
        //setResult(self.results);
        var statusCode = jqXHR.status;
        var statusText = jqXHR.statusText;
        alert("Sonuç :" + data);
    };

    //2.Yol
    var bitkiADparametreleri = class ADdegiskenleri {
        constructor(bitki_ID, turkceAdi, latinceAdi, sinonimAdi, yerelAdi, ingilizceAdi) {
            this._BitkiID = bitki_ID;
            this._TurkceAdi = turkceAdi;
            this._LatinceAdi = latinceAdi;
            this._SinonimAdi = sinonimAdi;
            this._YerelAdi = yerelAdi;
            this._IngilizceAdi = ingilizceAdi;

            adEkle = function () { return this._TurkceAdi, this._LatinceAdi, this._SinonimAdi, this._YerelAdi };
            adGuncelle = function () { return this._BitkiID, this._TurkceAdi, this._LatinceAdi, this._SinonimAdi, this._YerelAdi };
            adPar = function () { return this._BitkiID };
        }

    };
    //Ajax yazım işlemini azaltmak için kullandım başka bişey yapmam gerekir mi?
    $.ajaxSetup({
        dataType: "json",
        contentType: "application/json;charset=utf-8",
        async: true,
        cache: false,
    })

    var parUrl = '<%=Page.ResolveUrl("www.bitkimitani.com/' + parMethod +' ")%>';

    //Bitki Adlarını Ekleme
    bitkiADparametreleri.prototype.bitkiAdiEkle = function () {
        if (BaglantiVarMi() == true) {
            // ajaxSetup(), nasıl çagırmalıyım kendisi otomatikman çagırıyor mu?
            $.ajax({
                parMethod=api / BitkiAdi / EkleBitkiAdi, //Bu düşünce dogrumu
                //url: 'OgrenciBilgileri.aspx/OgrenciSil', Önceleri Bu şekilde cagrıyorum dum ama api de bu olmaz galiba :))
                url: parUrl,
                type: "POST",
                data: JSON.stringify(this.adEkle()),
            }).done(Basarili).fail(Hata(alert('Bitki Adı Ekleme İşi Başarısız Oldu.'))).always(function () { alert("Bitki Adı Başarılı Bir Şekilde Eklendi."); })
        }
    };

    //Bitki Adların tamamı Listeleniyor 
    bitkiAdTumListe = function () {
        $.ajax({
            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / ListelemeBitkiAdi')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
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
    };

    //Bitki Adlarını Güncelleme
    bitkiADparametreleri.prototype.bitkiAdGuncelle = function () {
        if (this._BitkiID !== 0) {

            $.ajax({
                //TODO url kısmını düzenle
                url: "<%=Page.ResolveUrl('/ api / BitkiAdi / GuncelleBitkiAdi')%>",
                type: "POST",
                contentType: "application/json;charset=utf-8",
                data: JSON.stringify(this.adGuncelle()),
                dataType: "json",
                success: function (response) {
                    alert("Sonuç :" + response);
                },
                error: Hata(
                    alert('Bitki Adı Güncelleme İşi Başarısız oldu.')
                )
            })
        }

        else {
            alert("Güncellemek İçin Bitki Adınız Seçiniz");
        }
    };

    //Bitki Adını Silme
    bitkiADparametreleri.prototype.bitkiAdSil = function () {
        if (this._BitkiID !== 0) {
            $.ajax({
                //TODO url kısmını düzenle
                url: "<%=Page.ResolveUrl('/ api / BitkiAdi / SilBitkiAdi')%>",
                type: "POST",
                contentType: "application/json;charset=utf-8",
                data: JSON.stringify(this.adPar()),
                dataType: "json",
                success: function (response) {
                    alert("Sonuç :" + response);
                },
                error: Hata(
                    alert('Bitki Adı Silme İşi Başarısız oldu.')
                )
            })
        }
        else {
            alert("Silmek istediğiniz bitki adını seçiniz lütfen");
        }
    };

    //Bitki Adına göre veri getir
    bitkiADparametreleri.prototype.bitkiAdiGetir = function () {
        if (this._BitkiID !== 0) {
            $.ajax({
                //TODO url kısmını düzenle
                //url: "<%=Page.ResolveUrl('www.bitkimitani.com/ api / BitkiAdi / GetirBitkiAdi')%>",
                url: "<%=Page.ResolveUrl('api / BitkiAdi / GetirBitkiAdi')%>",
                type: "POST",
                contentType: "application/json;charset=utf-8",
                data: JSON.stringify(this.adPar()),
                dataType: "json",
                success: function (response) {
                    alert("Sonuç :" + response);
                },
                error: function (x, e) {
                    alert('Seçilen Bitki Adı İşlemi Başarısız oldu.');
                    alert(x.responseText);
                    alert(x.status);
                }
            })
        }
        else {
            alert("Görüntülemek istediğiniz bitki adını seçiniz lütfen");
        }

    };

    if (typeof (Sys) !== 'undefined') Sys.Application.notifyScriptLoaded(); //Buna gerek var mı ? Java işi,nin tamamının bitmesini bekliyormuş? Hala bu kullanılıyor.//