//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Web.Http.Results;
//using BusinessClassLibrary;
//using EntityClassLibrary;
////Todo Entitye gerek var mı? 

//namespace API_Bitki.Controllers
//{
//    [RoutePrefix("api/BitkiAd")]
//    public class BitkiAdlari_DenemeController : ApiController
//    {
//        // GET: api/BitkiAd

//        static List<string> strings = new List<string>
//        {
//            "values","values1","values2"
//        };
//        [HttpGet]
//        public List<BitkiAdlari> BitkiListesi()
//        {

//            using (BitkiBilgileriBO liste = new BitkiBilgileriBO())
//            {
//                return liste.GetBitkiAdlariListesi().ToList();
//            }

            
//        }

//        // GET: api/BitkiAd/5
//        //Birden fazla degişken göndermek istersem nasıl olacak?
//        //TODO string ingilizceAdi="" bu yazım dogrumu istege baglı olarak kullnabilirmiyim?
        
//        [HttpGet]
//        public BitkiBilgileriBO SecilenBitkiAdi(int?bitki_ID,BitkiAdlari bitkiAdi)      
//        {
//            using (BitkiBilgileriBO seciliBitkiAdi = new BitkiBilgileriBO())
//            {
//                int sonuc = seciliBitkiAdi.GetBitkiAdiGetirBO(bitki_ID, bitkiAdi.TurkceAdi, bitkiAdi.IngilizceAdi, bitkiAdi.LatinceAdi, bitkiAdi.SinonimAdlari, bitkiAdi.YerelAdlari);
//                if (sonuc>=1)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }

//            }
//            //var bitkiAdi = seciliBitkiAdi.GetBitkiAdiGetirBO(bitkiAdlari.ID);
//            //return bitkiAdi;

//            //TODO Daha mantıklı bir yol var mı ?
//            //if (bitkiAdi.ID != bitki_ID || bitkiAdi.TurkceAdi != "" || bitkiAdi.LatinceAdi != "" || bitkiAdi.LatinceAdi != "" || bitkiAdi.SinonimAdlari != "" || bitkiAdi.YerelAdlari != "")
//            //{
//            //    Altı neden yeşil çizgi
//            //        veri tabanı işlemleri
//            //        var secilen = new List<BitkiBilgileriBO>();
//            //    secilen.GetBitkiAdiGetirBO(bitki_ID, bitkiAdi.TurkceAdi, );
//            //    return Request.CreateResponse(HttpStatusCode.OK, secilen);
//            //}

//            //else
//            //{
//            //    Console.WriteLine("Aradığınız bitki bulunamadı daha sonra tekrar deneyiniz");
//            //    return null;
//            //}

//        }

//        // POST: api/BitkiAd      
//        [HttpPost]
//        public void EkleBitkiAdi([FromBody]string value)
//        {

//        }

//        // PUT: api/BitkiAd/5
//        [Route("GuncelleBitkiAdi/{id:int}")]
//        [HttpPut]
//        public void GuncelleBitkiAdi(int Bitki_Id, [FromBody]string value)
//        {

//        }

//        // DELETE: api/BitkiAd/5
//        [Route("SilBitkiAdi")]
//        [HttpDelete]
//        public void SilBitkiAdi(params int[] BitkiListesi_Id)
//        {
//            //TODO Silinecek olan verileri dizi şeklinde burada mı almam gerekiyor yoksa asp tarafına mı koyamak daha mantıklı olur, nasıl olacak
//            for (int i = 0; i < BitkiListesi_Id.Length; i++)
//            {
//                //TODO veri tabanı baglantı işlemlerini yapılacak

//            }




//        }
//    }
//}
