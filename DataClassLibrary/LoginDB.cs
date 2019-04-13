using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClassLibrary;
using DataClassLibrary;
using System.Data;
using System.Web;

namespace DataClassLibrary
{
    public class LoginDB
    {
        BaglantiDB baglan = new BaglantiDB();

        public bool GetSifremiGuncelle(int kullaniciID, string eskiSifre, string yeniSifre)
        {
            var sifreGun = new KullaniciBilgileriEn()
            {
                ID = kullaniciID,
                Sifre = yeniSifre
            };

            if (sifreGun.ID != 0 || !string.IsNullOrEmpty(sifreGun.Sifre) || string.IsNullOrEmpty(yeniSifre))
            {
                var kullanici = new KullaniciBilgileriEn()
                {
                    ID = kullaniciID,
                    Sifre = yeniSifre,
                    SifreGuncellemeTarihi = DateTime.Now,
                    CepTelefonuOnay = Guid.NewGuid().ToString("N").Substring(0, 6), //Cep Telefonu Onayı için 6 haneli sayı uretiyor
                };
                //Todo Şifre Güncelle
            }
            return false;
        }

        public void MailSifreOnayKoduOlustur(string mailSifreOnayKodu, string email)
        {
            SqlConnection con = baglan.Baglanti();
            SqlCommand com = new SqlCommand("update Kullanici_tbl set MailSifreOnay=@MailSifreOnay where Email=@email", con);
            com.Parameters.AddWithValue("@MailSifreOnay", mailSifreOnayKodu);
            com.Parameters.AddWithValue("@Email", email);
            com.ExecuteNonQuery();
        }


        public List<KullaniciBilgileriEn> KullaniciEmailVeSifre(string email, string sifre)
        {
            SqlConnection con = baglan.Baglanti();
            var list = new List<KullaniciBilgileriEn>();

            using (SqlCommand com = new SqlCommand("select KullaniciID,Ad,Soyad from Kullanici_tbl where Email=@email and Sifre=@sifre ", con))
            {

                com.Parameters.AddWithValue("@email", email);
                com.Parameters.AddWithValue("@sifre", sifre);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new KullaniciBilgileriEn()
                    {
                        //KullaniciID = reader["KullaniciID"].ToString(),
                        Ad = reader["Ad"].ToString(),
                        Soyad = reader["Soyad"].ToString(),
                        //Image = reader["Resim"].ToString(),
                    });

                }
            }
            con.Close();

            return list;
        }

        public void GetYeniKullaniciEkleBy(KullaniciBilgileriEn kullaniciEkle)
        {
            SqlConnection con = baglan.Baglanti();
            using (SqlCommand com = new SqlCommand("sp_YeniKullaniciEkle", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Ad", kullaniciEkle.Ad);
                com.Parameters.AddWithValue("@Soyad", kullaniciEkle.Soyad);
                com.Parameters.AddWithValue("@CepTelefonu", kullaniciEkle.CepTelefonu);
                com.Parameters.AddWithValue("@Adres", kullaniciEkle.Adres);
                com.Parameters.AddWithValue("@Sehir", kullaniciEkle.Sehir);
                com.Parameters.AddWithValue("@onay", kullaniciEkle.Onay);
                com.Parameters.AddWithValue("@email", kullaniciEkle.Email);
                com.Parameters.AddWithValue("@sifre", kullaniciEkle.Sifre);
                com.ExecuteNonQuery();
            }
            con.Close();

        }

        public Boolean GetSifremiUnuttumBy(string email)
        {
            //Kullanıcının tanımlı mail adresi var mı yok mu ona bakılıyor
            Boolean varmi = false;
            SqlConnection con = baglan.Baglanti();


            SqlCommand com = new SqlCommand("sp_MailKontrol", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@email", email);

            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                varmi = true;
            }
            con.Close();
            return varmi ? true:false;

        }
        //public List<KullaniciBilgileriEn> GetKullaniciKaydiBilgileri(string email)
        public List<KullaniciBilgileriEn> GetKullaniciKaydiBilgileri(string email)
        {

            var kullanici = new KullaniciBilgileriEn()
            {
                Email = email
            };
            //Todo Kullanici Var mı yok mu ona bakılacak
            var list = new List<KullaniciBilgileriEn>();
            SqlConnection con = baglan.Baglanti();
            using (SqlCommand com = new SqlCommand("Select Ad,Soyad,Sifre from Kullanici_tbl where Email=@email", con))
            {
                com.Parameters.AddWithValue("@email", kullanici.Email);
                SqlDataAdapter dap = new SqlDataAdapter(com);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new KullaniciBilgileriEn()
                    {
                        Ad = reader["Ad"].ToString(),
                        Soyad = reader["Soyad"].ToString(),
                        Sifre = reader["Sifre"].ToString()
                    });
                }
            }
            return list;
        }

        public bool GetKullaniciGiris(string email,string sifre)
        {
            SqlConnection con = baglan.Baglanti();
            using (SqlCommand com=new SqlCommand("sp_KullaniciGiris", con))
            {
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@email", email);
                com.Parameters.AddWithValue("@sifre", sifre);
                return true;
            }

        }


    }
}
