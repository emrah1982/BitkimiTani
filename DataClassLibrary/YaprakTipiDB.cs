using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClassLibrary;
using DataClassLibrary;
using System.Data;

namespace DataClassLibrary
{
    public class YaprakTipiDB
    {
        BaglantiDB baglanti = new BaglantiDB();

        public string GetYaprakTipiBilgisiBy(BitkiMorfoloji yaprakTipi)
        {//TODO yaprak tipi yapılacak
            SqlConnection con = baglanti.Baglanti();
            SqlCommand com = new SqlCommand("", con);
            com.CommandType = CommandType.StoredProcedure;
           // com.Parameters.AddWithValue("", yaprakTipi.);
            return "";
        }
    }
}
