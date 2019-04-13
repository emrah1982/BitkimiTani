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
    public class BitkiTanimaDB
    {
        BaglantiDB baglanti = new BaglantiDB();
        public string GetBitkiTanimaBilgileriBy(int bitkiAd_ID)
        {
            //TODO bitki tanıma ozellikleri eklenecek
           
            SqlConnection con = baglanti.Baglanti();
            using (SqlCommand com = new SqlCommand("sp_BitkimiTaniBilgileri", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bitkiAdID", bitkiAd_ID);
                com.ExecuteNonQuery();
                return "Seçili Bitki Başarılı Bir Şekilde Lİsteledi";
            }


        }

        public string GetBitkiTaEklemeGuncelleme(BitkiTanima tanima)
        {
            SqlConnection con = baglanti.Baglanti();
            using (SqlCommand com = new SqlCommand("sp_BitkimiTaniEkleGuncelle", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bitkiAdID", tanima.Bitki_ID);
                com.Parameters.AddWithValue("@bitkiTipiTur", tanima.BitkiTipi);
                com.Parameters.AddWithValue("@toleranslari", tanima.Tolerans);
                com.Parameters.AddWithValue("@yetistigiSehirler", tanima.YetistigiSehirler);
                com.Parameters.AddWithValue("@anavataniveDogalYayilisAlanlari", tanima.AnavataniDogalYayılısAlanlariIhtiyaci);
                com.Parameters.AddWithValue("@dogalYasamAlanlari", tanima.DogalYasamAlanlari);
                com.Parameters.AddWithValue("@arsizlikDurumu", tanima.ArsizlikDurumu);
                com.Parameters.AddWithValue("@yetismeDurumu", tanima.YetismeDurumu);
                com.Parameters.AddWithValue("@yasamSuresi", tanima.YasamSuresi);
                com.Parameters.AddWithValue("@toksikOzellikler", tanima.ToksikOzellikler);
                com.Parameters.AddWithValue("@hangiDonem", tanima.HangiDonem);
                com.Parameters.AddWithValue("@bitkiYetismeAlanlari", tanima.BitkiYetismeAlanlari);
                com.Parameters.AddWithValue("@endemik", tanima.Endemik);
                com.ExecuteNonQuery();
                return "Bitki Tanıma Ekleme /Guncelleme İşi Başarılı Bir Şekilde Geçekleştirildi.";
            }
        }
    }
}
