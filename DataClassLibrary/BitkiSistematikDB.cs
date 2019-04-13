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
    public class BitkiSistematikDB
    {
        BaglantiDB baglan = new BaglantiDB();
        public string GetBitkiSistematikByEkle(BitkiSistematik sistematik)
        {
            SqlConnection con = baglan.Baglanti();

            if (sistematik.Bitki_ID != 0 || !string.IsNullOrWhiteSpace(sistematik.Alem) || !string.IsNullOrEmpty(sistematik.AltTurler) || !string.IsNullOrEmpty(sistematik.Bolum) || !string.IsNullOrEmpty(sistematik.Cins) || !string.IsNullOrEmpty(sistematik.Familya) || !string.IsNullOrEmpty(sistematik.Sinif) || !string.IsNullOrEmpty(sistematik.Takim) || !string.IsNullOrEmpty(sistematik.Tur))
            {
                //Ekle ve güncelleme yapıyor
                using (SqlCommand command = new SqlCommand("sp_BitkiSistematigi", con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@bitki_ID", sistematik.Bitki_ID);
                    command.Parameters.AddWithValue("@alem", sistematik.Alem);
                    command.Parameters.AddWithValue("@altTurler", sistematik.AltTurler);
                    command.Parameters.AddWithValue("@bolum", sistematik.Bolum);
                    command.Parameters.AddWithValue("@cins", sistematik.Cins);
                    command.Parameters.AddWithValue("@familya", sistematik.Familya);
                    command.Parameters.AddWithValue("@sinif", sistematik.Sinif);
                    command.Parameters.AddWithValue("@takim", sistematik.Takim);
                    command.Parameters.AddWithValue("@tur", sistematik.Tur);
                    command.ExecuteNonQuery();
                }
            }
            return "Sistematik Bilgileri Eklendi / Güncellendi.";
        }

        public string GetBitkiSistematikByGuncelle(int bitkiID,BitkiSistematik sistematik)
        {
            SqlConnection con = baglan.Baglanti();

            if (sistematik.Bitki_ID != 0 || !string.IsNullOrWhiteSpace(sistematik.Alem) || !string.IsNullOrEmpty(sistematik.AltTurler) || !string.IsNullOrEmpty(sistematik.Bolum) || !string.IsNullOrEmpty(sistematik.Cins) || !string.IsNullOrEmpty(sistematik.Familya) || !string.IsNullOrEmpty(sistematik.Sinif) || !string.IsNullOrEmpty(sistematik.Takim) || !string.IsNullOrEmpty(sistematik.Tur))
            {
                //Aslında hem Ekle hemde güncelleme yapıyor
                using (SqlCommand command = new SqlCommand("sp_BitkiSistematigi", con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@bitki_ID", sistematik.Bitki_ID);
                    command.Parameters.AddWithValue("@alem", sistematik.Alem);
                    command.Parameters.AddWithValue("@altTurler", sistematik.AltTurler);
                    command.Parameters.AddWithValue("@bolum", sistematik.Bolum);
                    command.Parameters.AddWithValue("@cins", sistematik.Cins);
                    command.Parameters.AddWithValue("@familya", sistematik.Familya);
                    command.Parameters.AddWithValue("@sinif", sistematik.Sinif);
                    command.Parameters.AddWithValue("@takim", sistematik.Takim);
                    command.Parameters.AddWithValue("@tur", sistematik.Tur);
                    command.ExecuteNonQuery();
                }
            }
            return "Sistematik Bilgileri Güncellendi.";
        }
        public List<BitkiSistematik> GetBitkiSistematikByListe(int bitki_ID)
        {
            BitkiSistematik sistematik = new BitkiSistematik();
            SqlConnection con = baglan.Baglanti();

            var list = new List<BitkiSistematik>();
            if (sistematik.Bitki_ID != 0)
            {
                using (SqlCommand com = new SqlCommand("sp_BitkiSistematigiListesi", con))
                {
                    com.Parameters.AddWithValue("@bitki_ID", sistematik.Bitki_ID);
                    com.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dap = new SqlDataAdapter(com);
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new BitkiSistematik()
                        {
                            Alem = reader["Alem"].ToString(),
                            AltTurler = reader["AltTurler"].ToString(),
                            Bolum = reader["Bolum"].ToString(),
                            Cins = reader["Cins"].ToString(),
                            Familya = reader["Familya"].ToString(),
                            Sinif = reader["Sinif"].ToString(),
                            Takim = reader["Takim"].ToString(),
                            Tur = reader["Tur"].ToString(),
                        });
                    }
                }
            }
            return list;
        }
    }
}
