using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassLibrary;
using EntityClassLibrary;

namespace DataClassLibrary
{
    public class BitkiEkolojiDB
    {
        BaglantiDB baglan = new BaglantiDB();
        string ekolojiListesi;
        public List<BitkiEkoloji> EkolojiListesi(int bitkiID)
        {
            //SqlConnection con = baglanti.Baglanti();
            SqlConnection con = baglan.Baglanti();
            var list = new List<BitkiEkoloji>();
            using (SqlCommand com = new SqlCommand("sp_BitkiEkolojiListele", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bitkiAdID", bitkiID);
                int sonuc = com.ExecuteNonQuery();
                ekolojiListesi = sonuc >= 1 ? "Seçilen Bitki Türüne Göre Ekoloji Listelendi" : "Seçilen Bitki Türüne Göre Ekoloji Listeleme Başarısız Oldu";
            }
            //return "Seçilen Bitki Türüne Göre Ekoloji Listelendi";
            return list;
        }

        public string GetEkolojiEkleGuncelleBy(BitkiEkoloji ekoloji)
        {
            SqlConnection con = baglan.Baglanti();
            if (ekoloji.BitkiAd_ID != 0 || !string.IsNullOrEmpty(ekoloji.Iklim) || !string.IsNullOrEmpty(ekoloji.Isik))
            {
                using (SqlCommand com = new SqlCommand("sp_BitkiEkolojiEkleGuncelle", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@bitkiAdID", ekoloji.BitkiAd_ID);
                    com.Parameters.AddWithValue("@iklim", ekoloji.Iklim);
                    com.Parameters.AddWithValue("@isik", ekoloji.Isik);
                    com.Parameters.AddWithValue("@sicaklik", ekoloji.Sicaklik);
                    com.Parameters.AddWithValue("@nem", ekoloji.Nem);
                    com.Parameters.AddWithValue("@gorunus", ekoloji.Gorunus);
                    com.Parameters.AddWithValue("@toprakYapisi", ekoloji.ToprakYapisi);
                    com.Parameters.AddWithValue("@toprakPh", ekoloji.ToprakPh);
                    com.Parameters.AddWithValue("@toprakEnYuksek_Ph", ekoloji.ToprakEnYuksek_Ph);
                    com.Parameters.AddWithValue("@toprakEnDusuk_Ph", ekoloji.ToprakEnDusuk_Ph);
                    com.Parameters.AddWithValue("@bolgeSoguklugu", ekoloji.BolgeSohuklugu);
                    com.Parameters.AddWithValue("@bolgeSicakligiGunsayisi", ekoloji.BolgeSicakligiGunsayisi);
                    com.Parameters.AddWithValue("@kusakSicakligi", ekoloji.KusakSicakligi);
                    com.Parameters.AddWithValue("@kusakSoguklugu", ekoloji.KusakSoguklugu);
                    com.Parameters.AddWithValue("@mineraller", ekoloji.Mineraller);
                    com.Parameters.AddWithValue("@soc", ekoloji.Soc);
                    com.Parameters.AddWithValue("@p", ekoloji.P);
                    com.Parameters.AddWithValue("@ca", ekoloji.Ca);
                    int res1 = com.ExecuteNonQuery();
                }
                con.Close();
            }


            return "Bitkinin Ekoloji Bilgileri Başarılı Bir Şekilde Kaydedildi.";

        }


    }
}
