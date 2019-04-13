using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassLibrary;
using EntityClassLibrary;

namespace DataClassLibrary
{
   public class BitkiEkBilgilerDB
    {
        

        BaglantiDB baglanti = new BaglantiDB();
        public string GetBitkiEkBilgileriBy(int bitkiAd_ID)
        {
            SqlConnection con = baglanti.Baglanti();
            using (SqlCommand com=new SqlCommand("sp_BitkiEkBilgiler", con))
            {
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bitkiAd_ID", bitkiAd_ID);
                com.ExecuteNonQuery();
            }
            return "Bitki İle Alakalı Ek Bilgiler Listelendi";
        }


        public string GetBitkiEkBilgiEkleGuncelle(BitkiEkBilgiler bitkiEk)
        {
            SqlConnection con = baglanti.Baglanti();
            using (SqlCommand com=new SqlCommand("sp_BitkiEkBilgilerEkleGuncelle",con))
            {
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bitkiAd_ID", bitkiEk.Bitki_ID);
                com.Parameters.AddWithValue("@kaynaklar", bitkiEk.Kaynaklar);
                com.Parameters.AddWithValue("@notlar", bitkiEk.Notlar);
                com.ExecuteNonQuery();
            }

            return "Bitki ile İlgili Ek Bilgiler Eklendi ve Guncellendi";
        }

    }
}
