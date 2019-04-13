using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClassLibrary;
using DataClassLibrary;
using System.Data.SqlClient;
using System.Data;


namespace DataClassLibrary
{
    public class BitkiMineralleriDB
    {



        BaglantiDB baglanti = new BaglantiDB();

        public string GetToprakMineralBilgisiBy(int bitkiAd_ID)
        {
            SqlConnection con = baglanti.Baglanti();
            if (bitkiAd_ID!=0)
            {
                using (SqlCommand com = new SqlCommand("sp_ToprakMineralBilgisi", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@bitkiAdID", bitkiAd_ID);
                    com.ExecuteNonQuery();
                }
                return "Toprak Mineral Bilgileri Listelendi";
            }
            else
            {
                return "Bitki Seçiniz";
            }
         
        }

        public string GetToprakMineralleriBilgisiEkleGuncelle(BitkiMineralleri bitkiMineralleri)
        {
            SqlConnection con = baglanti.Baglanti();
            using (SqlCommand com = new SqlCommand("sp_ToprakMineralBilgisiEkleGuncelle", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bitkiAdID", bitkiMineralleri.Bitki_ID);
                com.Parameters.AddWithValue("@mineralAdi", bitkiMineralleri.MineralAdi);
                com.Parameters.AddWithValue("@mineralHakkindaBilgi", bitkiMineralleri.MineralHakkindaBilgi);
                com.Parameters.AddWithValue("@nem", bitkiMineralleri.Nem);
                com.Parameters.AddWithValue("@mineralMinDegeri", bitkiMineralleri.MinMineral);
                com.Parameters.AddWithValue("@mineralMaxDegeri", bitkiMineralleri.MaxMineral);
                com.Parameters.AddWithValue("@topraktaBulunmasiGerekenMineraller", bitkiMineralleri.TopraktaBulunmasiGerekenMineraller);
                com.Parameters.AddWithValue("@analizBirimi", bitkiMineralleri.AnalizBirimi);
                com.ExecuteNonQuery();
            }
            return "Bitki Mineralleri Eklendi ve Güncellendi";
        }
    }
}
