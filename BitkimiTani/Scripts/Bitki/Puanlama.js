//TODO Puanlama ve Favoriler ayarla bu şekilde olmayacak  galiba :))
function artirmaParametre() {
    var puan = {};
    puan.MinPuan = $("#lblMinPuan").attr();
    puan.MaxPuan = $("#lblMaxPuan").attr();
    puan.favori = $("#lblFavoriArtir").attr();
}
var score = 0;
function minPuanArtir() {
    score += 1;
    $("#lblMinPuan")[0].innerHTML = score;
}
//TODO puan artırmayı sadece 1 kişi bir kere yapacak nasıl olacak ?

function maxPuanArtir() {
    score += 1;
    $("#lblMaxPuan")[0].innerHTML = score;
}

function favorileri() {
    score = 0;
    $("#lblFavoriArtir")[0].innerHTML = score;

    if (kullaniciBilgileri_ID !== 0) {
        $.ajax({
            //TODO url'in yazım şekli dogru mu?

            url: "<%=Page.ResolveUrl('/ api / BitkiAdi / EkleProfilBilgileri')%>",
            type: "POST",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(kullaniciBilgileri_ID, score),
            dataType: "json",
            success: function (response) {
                alert("Sonuç :" + response);
            },
            error: function (x, e) {
                alert('Favorilere Ekleme İşi Başarısız oldu.');
                alert(x.responseText);
                alert(x.status);
            }
        })
    }
    else {
        alert("Lütfen Kullanıcı Girişi Yapınız.")
    }
}
