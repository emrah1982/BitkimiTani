using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using EntityClassLibrary;
using System.Drawing;
using System.Net.Http;

namespace DataClassLibrary
{
   public class ResimDB
    {
        static string base64String = null;
        public string GetKullaniciResimiEkle(ResimEn resim)
        {
            //int kullaniciIDresmi = resim.KullaniciID;
            //int bitkiID = resim.BitkiID;
            //string dirPath = HttpContext.Current.Server.MapPath("~") + "/Dosyalar/KullaniciResimleri/"+resim.KullaniciID;
            //FileUpload1.SaveAs(dirPath + kullaniciIDresmi + ".jpg");
            return "resim yükleme başarılı";
           
        }
    }
}
