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
    public class BitkiKullanimAlanlariDB
    {
        BaglantiDB baglanti = new BaglantiDB();
        public string GetBitkiKullanimAlanlariBy(int bitkiAd_ID)
        { 
            SqlConnection con = baglanti.Baglanti();
            using (SqlCommand com=new SqlCommand("sp_BitkiKullanimBilgileri", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bitkiAd_ID", bitkiAd_ID);
                com.ExecuteNonQuery();
            }
            //TODO İçinde Bitki yoksa liseleme konusunda (veri bulunamadı) bilgisini nasıl çıkartabilirim 
            return "Secili Bitki Verileri Listelendi";
        }

        public string GetKullanimAlanlariEkleGuncelle(BitkiKullanimAlanlari bitkiKullanim)
        {
            SqlConnection con = baglanti.Baglanti();
            using (SqlCommand com=new SqlCommand("sp_BitkiKullanimBilgileriEkleGuncelle", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bitkiAdID", bitkiKullanim.Bitki_ID);
                com.Parameters.AddWithValue("@kullanimAlanlari", bitkiKullanim.KullanimAlanlari);
                com.Parameters.AddWithValue("@peyzajdaKullanim", bitkiKullanim.PeyzajdaKullanim);
                com.Parameters.AddWithValue("@susBitkileri", bitkiKullanim.SusBitkileri);
                com.Parameters.AddWithValue("@tibbiAramotikBitkiler", bitkiKullanim.TibbiAramotikBitkiler);
                com.ExecuteNonQuery();          

            }

            return "Veri ekleme ve Guncelleme işi başarılı bir şekilde gerçekleştirildi";
        }

    }
}
