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
    public class BitkiMorfolojiDB
    {
        BaglantiDB baglan = new BaglantiDB();
        public BitkiMorfoloji GetBitkiMorfolojiEkleGuncelleBy(BitkiMorfoloji morfoloji)
        {

           // BaglantiDB baglan = new BaglantiDB();
            SqlConnection con = baglan.Baglanti();
            //TODO morfoloji prosedur yazılacak
            SqlCommand com = new SqlCommand("sp_BitkiMorfolojiEkle_Guncelle", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@bitkiAdID", morfoloji.Bitki_ID);
            com.Parameters.AddWithValue("@genelBilgi", morfoloji.FamilyaHakkindaGenelBilgi);
            com.Parameters.AddWithValue("@budama", morfoloji.Budama);
            com.Parameters.AddWithValue("@cicek", morfoloji.Cicek);
            com.Parameters.AddWithValue("@ciceklenmeZamani", morfoloji.CiceklenmeZamani);
            com.Parameters.AddWithValue("@ciceklilikSuresi", morfoloji.CiceklilikSuresi);
            com.Parameters.AddWithValue("@cicekRengi", morfoloji.CicekRengi);
            com.Parameters.AddWithValue("@dalFormu", morfoloji.DalFormu);
            com.Parameters.AddWithValue("@enDusukRakim", morfoloji.EnDusukRakim);
            com.Parameters.AddWithValue("@enKisaBoy",morfoloji.EnKisaBoy);
            com.Parameters.AddWithValue("@enUzunBoy",morfoloji.EnUzunBoy);
            com.Parameters.AddWithValue("@enYuksekRakim", morfoloji.EnYuksekRakim);
           
            com.Parameters.AddWithValue("@kokusu", morfoloji.Kokusu);
            com.Parameters.AddWithValue("@meyveTipi", morfoloji.MeyveTipi);
            com.Parameters.AddWithValue("@ortalamaBoy", morfoloji.OrtalamaBoy);
           // com.Parameters.AddWithValue("@tur", morfoloji.Tur);
            com.Parameters.AddWithValue("@yaprakDizilisi", morfoloji.YaprakDizilisi);
            com.Parameters.AddWithValue("@yaprakTipi",morfoloji.YaprakTipiID);

            com.ExecuteNonQuery();
            return morfoloji;
        }


        public BitkiMorfoloji GetBitkiMorfolojiBilgisiBy(BitkiMorfoloji morfoloji) {

            SqlConnection con = baglan.Baglanti();
            SqlCommand com = new SqlCommand("sp_SeciliBitkiMorfolojiBilgisi", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@bitkiAd_ID", morfoloji.Bitki_ID);
            com.ExecuteNonQuery();

            return morfoloji;

        }
    }
}
