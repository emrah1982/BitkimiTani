using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClassLibrary;

namespace DataClassLibrary
{
    public class BitkiUretimDB
    {
        BaglantiDB baglanti = new BaglantiDB();
        public string GetBitkiUretimBilgileriBy(int bitkiAd_ID)
        {
            SqlConnection con = baglanti.Baglanti();

            using (SqlCommand com = new SqlCommand("sp_BitkiUretimBilgileri", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bitkiAdID", bitkiAd_ID);
                com.ExecuteNonQuery();
                con.Close();
            }
            return "Secili olan Bitki Uretim Bilgileri Listelendi";
        }


        public string GetBitkiUretimBilgileriEkleGuncelle(BitkiUretim uretim)
        {
            SqlConnection con = baglanti.Baglanti();

            //int returnValue;
            using (SqlCommand com = new SqlCommand("sp_bitkiUretimEkleGuncelle", con))
            {
                // List<UretimYontemleri> yontemleris = new List<UretimYontemleri>();

                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bitkiAd_ID", uretim.BitkiAd_ID);
                com.Parameters.AddWithValue("@araziOlcusu", uretim.AraziOlcusu);
                com.Parameters.AddWithValue("@bakimIhtiyaci", uretim.BakimIhtiyaci);              
                com.Parameters.AddWithValue("@uretimYontemleri", uretim.UretimYontemleri);
                com.Parameters.AddWithValue("@celikleUretim", uretim.CelikleUretim);
                com.Parameters.AddWithValue("@gelisimHizi", uretim.GelisimHizi);
                com.Parameters.AddWithValue("@mevsimineGore", uretim.MevsimineGore);
                com.Parameters.AddWithValue("@ortamSicakligi", uretim.OrtamSicakligi);
                com.Parameters.AddWithValue("@ruzgarHizi", uretim.RuzgarHizi);
                com.Parameters.AddWithValue("@sicakKusak", uretim.SicakKusak);
                com.Parameters.AddWithValue("@soguyaDayaniklilikSicaklikAraligi", uretim.SogugaDayaniklilikSicaklikAraligi);
                com.Parameters.AddWithValue("@sogukKusak", uretim.SogukKusak);
                com.Parameters.AddWithValue("@sulamaTarihi", uretim.SulamaTarihi);
                com.Parameters.AddWithValue("@sulamaYontemi", uretim.SulamaYontemi);
                com.Parameters.AddWithValue("@tohumDikimDerinligi_Min", uretim.TohumDikimDerinligi_Min);
                com.Parameters.AddWithValue("@tohumDikimDerinligi_Max", uretim.TohumDikimDerinligi_Max);
                com.Parameters.AddWithValue("@yillikSicaklikGunsayisi", uretim.YillikSicaklikGunSayisi);
                com.Parameters.AddWithValue("@videoLink", uretim.VideoLinki);
       
                //com.Parameters.AddWithValue("@videoLink", uretim.BitkiUretimYontemleri.Add());

                //com.Parameters.Add("@DonusDegeri", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                //com.Parameters.AddWithValue("@returnValue", -1).Direction = ParameterDirection.ReturnValue;

                com.ExecuteNonQuery();
                // returnValue = com.Parameters["@returnValue"].Value;
               // con.Close();
                

            }
            return "Uretim Yontemi Guncellendi";



        }
    }
}
