using EntityClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;


namespace DataClassLibrary
{
    public class BitkiAdlariDB
    {
        BaglantiDB baglan = new BaglantiDB();
        string bitkiAdiEkleSonuc;
        string bitkiAdiEkleGuncelle;
        public List<BitkiAdlari> GetBitkiAdiListe()
        {
            SqlConnection con = baglan.Baglanti();
            StringBuilder errorMessages = new StringBuilder();
            var list = new List<BitkiAdlari>();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    using (var comm = new SqlCommand("sp_BitkiListesi", con))
                    {
                        comm.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter dap = new SqlDataAdapter(comm);
                        SqlDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            list.Add(new BitkiAdlari()
                            {
                                TurkceAdi = reader["TurkceAdi"].ToString(),
                                IngilizceAdi = reader["IngilizceAdi"].ToString(),
                                LatinceAdi = reader["LatinceAdi"].ToString(),
                                SinonimAdlari = reader["SinonimAdi"].ToString(),
                                YerelAdlari = reader["YerelAdi"].ToString()
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                //TODO Bu hata kodu store prosedure de uyar mı?
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "Error Number: " + ex.Errors[i].Number + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                //TODO Hata mesajlarını nasıl alırım asp tarafında veya başka bir yol var mı? 
                Console.WriteLine(errorMessages.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public string GetBitkiAdGetirBy(int bitkiID)
        {
            var ad = new BitkiAdlari()
            {
                ID = bitkiID,
            };
            if (ad.ID != 0)
            {
                SqlConnection con = baglan.Baglanti();
                DataTable table = new DataTable();
                var cmd = new SqlCommand("sp_BitkiAdiGetir", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bitki_ID", ad.ID);
                var da = new SqlDataAdapter(cmd);

                cmd.CommandType = CommandType.StoredProcedure;
                da.Fill(table);
                con.Close();
            }
            return "Seçtiğiniz Bitki Adi Başarıyla Getirildi ";
        }
       
        public string GetBitkiAdiByEkle(BitkiAdlari ad)
        {
          
            SqlConnection con = baglan.Baglanti();
            if (ad.ID!=0||!string.IsNullOrEmpty(ad.TurkceAdi) || !string.IsNullOrEmpty(ad.LatinceAdi) || !string.IsNullOrEmpty(ad.IngilizceAdi) || !string.IsNullOrEmpty(ad.SinonimAdlari) || !string.IsNullOrEmpty(ad.YerelAdlari))
            {
               
                using (SqlCommand comm = new SqlCommand("sp_BitkiAdiEkle", con))
                {
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@id",ad.ID);
                    comm.Parameters.AddWithValue("@turkceAdi", ad.TurkceAdi);
                    comm.Parameters.AddWithValue("@latinceAdi", ad.LatinceAdi);
                    comm.Parameters.AddWithValue("@ingilizceAdi", ad.IngilizceAdi);
                    comm.Parameters.AddWithValue("@sinonimAdlar", ad.SinonimAdlari);
                    comm.Parameters.AddWithValue("@yerelAdlar", ad.YerelAdlari);
                    int sonuc =comm.ExecuteNonQuery();
                    bitkiAdiEkleSonuc = sonuc >= 1 ? "Bitki Adı Kaydı İşlemi Başarılı" : "Bitki Adı Kaydı İşlemi Başarısız Oldu";              
                }
                con.Close(); 
            }
            return bitkiAdiEkleSonuc;
           // return "Bitki Adları Başarılı Bir Şekilde Kaydedildi.";
        }
        public string GetBitkiAdlariGuncelleByDB(int bitkiID, BitkiAdlari ad)
        {
            SqlConnection con = baglan.Baglanti();

            var adID = new BitkiAdlari()
            {
                ID = bitkiID
            };

            if (adID.ID != 0)
            {
                using (SqlCommand com = new SqlCommand("sp_BitkiAdlariGuncellemeEkleme", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@degisken", adID.ID);
                    com.Parameters.AddWithValue("@turkceAdi", ad.TurkceAdi);
                    com.Parameters.AddWithValue("@latinceAdi", ad.LatinceAdi);
                    com.Parameters.AddWithValue("@ingilizceAdi", ad.IngilizceAdi);
                    com.Parameters.AddWithValue("@sinonimAdlar", ad.SinonimAdlari);
                    com.Parameters.AddWithValue("@yerelAdlar", ad.YerelAdlari);
                    int sonuc = com.ExecuteNonQuery();
                    con.Close();
                    //if (i >= 1)
                    //{
                    //    return "Bitki Adı Başarıyla Güncellendi";
                    //}
                    bitkiAdiEkleGuncelle = sonuc >= 1 ? "Bitki Adı Başarıyla GÜNCELLENDİ" : "Bitki Adı GÜNCELLENEMEDİ Lütfen Bitkinizi Seçiniz";
                }
            }
            //return "Bitki Adı GÜNCELLENEMEDİ Lütfen Bitkinizi Seçiniz";
            return bitkiAdiEkleGuncelle;

        }
        public string GetBitkiAdiSilByDB(int bitkiID)
        {
            //TODO Dizi şeklinde almak istesem nasıl alabilirim params dizi ile
            SqlConnection con = baglan.Baglanti();
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    var bitkiAdi = new BitkiAdlari()
                    {
                        ID = bitkiID
                    };

                    using (SqlCommand comm = new SqlCommand("sp_bitkiAdlariSil", con))
                    {
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@degisken", bitkiAdi.ID);
                        int sonuc=comm.ExecuteNonQuery();
                    }
                con.Close();
             
               
                }
                return "Bitkiniz başarılı bir şekilde silindi";
            }
            catch (Exception ex)
            {
                return "İnternet Baglantınızı kontrol ediniz"+ex;
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
           
        }
    }
}

