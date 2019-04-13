using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using EntityClassLibrary;


namespace BusinessClassLibrary
{
   public class BingSearchApiBO
    {  //Kaynak Adres:https://github.com/Azure-Samples/cognitive-services-REST-api-samples/blob/master/dotnet/Search/BingImageSearchv7Quickstart.cs
       //Kaynak Adres : https://azure.microsoft.com/tr-tr/try/cognitive-services/my-apis/?apiSlug=search-api-v7
        public class ResimAra // (BitkiAdlari bitkiAdlar)
        {          
            // Buraya geçerli erişim anahtarınızla değiştirin. Alış tarihi 06/01/2019 Bitiş Tarihi 14/01/2019
            const string subscriptionKey = "868af73c67a3479789095ae5dfff137a";

            // Verify the endpoint URI. If you encounter unexpected authorization errors,
            // double-check this value against the Bing search endpoint in your Azure dashboard.
            const string uriBase = "https://api.cognitive.microsoft.com/bing/v7.0/images/search";

            const string searchTerm = "tropical ocean";//Aranacak kelime Latince, Turkçe isimde arama dizi olarak almayı denesem

            // A struct to return image search results seperately from headers
            struct SearchResult
            {
                public string jsonResult;
                public Dictionary<String, String> relevantHeaders;
            }

            static void Main()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("Searching images for: " + searchTerm + "\n");
                //arama terimini kullanarak arama isteği gönder
                SearchResult result = BingImageSearch(searchTerm);
                //JSON yanıtını Bing Görsel Arama API'sından seri hale getirme
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(result.jsonResult);

                var firstJsonObj = jsonObj["value"][0];
                Console.WriteLine("Title for the first image result: " + firstJsonObj["name"] + "\n");
                //Uygulamayı çalıştırdıktan sonra, görüntüyü görmek için çıkış URL'sini bir tarayıcıya kopyalayın.
                Console.WriteLine("URL for the first image result: " + firstJsonObj["webSearchUrl"] + "\n");

                Console.Write("\nPress Enter to exit ");
                Console.ReadLine();
            }

            /// <summary>
            /// Performs a Bing Image search and return the results as a SearchResult.
            /// </summary>
            static SearchResult BingImageSearch(string searchQuery)
            {
                // Arama isteğinin URI'sini oluştur
                var uriQuery = uriBase + "?q=" + Uri.EscapeDataString(searchQuery);

                // Web isteğini gerçekleştir ve yanıtı al
                WebRequest request = WebRequest.Create(uriQuery);
                request.Headers["Ocp-Apim-Subscription-Key"] = subscriptionKey;
                HttpWebResponse response = (HttpWebResponse)request.GetResponseAsync().Result;
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();

                // Dönüş için sonuç nesnesi oluştur
                var searchResult = new SearchResult()
                {
                    jsonResult = json,
                    relevantHeaders = new Dictionary<String, String>()
                };

                // Bing HTTP başlıklarını ayıkla
                foreach (String header in response.Headers)
                {
                    if (header.StartsWith("BingAPIs-") || header.StartsWith("X-MSEdge-"))
                        searchResult.relevantHeaders[header] = response.Headers[header];
                }

                return searchResult;
            }

        }
    }
}
