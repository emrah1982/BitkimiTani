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
    public class KullaniciDB
    {
        BaglantiDB baglan = new BaglantiDB();
        public string KullaniciBilgileriByEkle(KullaniciBilgileriEn bilgiler)
        {
            SqlConnection con = baglan.Baglanti();
            using (SqlCommand com=new SqlCommand("sp_YeniKullaniciEkle", con))
            {              
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Ad", bilgiler.Ad);
                com.Parameters.AddWithValue("@Soyad", bilgiler.Soyad);
                com.Parameters.AddWithValue("@CepTelefonu",bilgiler.CepTelefonu);
                com.Parameters.AddWithValue("@Adres",bilgiler.Adres);
                com.Parameters.AddWithValue("@Sehir",bilgiler.Sehir);
                com.Parameters.AddWithValue("@Email",bilgiler.Email);
                com.Parameters.AddWithValue("@Sifre",bilgiler.Sifre);
                com.Parameters.AddWithValue("@onay", bilgiler.Onay);
                int res1 = com.ExecuteNonQuery();
            }
            return "Yeni Kullanıcı Kaydı Oluşturuldu.";
        }

        public KullaniciBilgileriEn KullaniciBilgileriByGuncelle()
        {
            //TODO kullanici bilgileri ekle ve yetkilendirme
            return null;
        }

    }
}
