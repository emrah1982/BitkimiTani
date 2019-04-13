using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using System.IO;

namespace EntityClassLibrary
{
   public class ResimEn
    {
        //public ResimEn()
        //{

        //}
        //public ResimEn(string localFileName, string fileName, string origion)
        //{
        //    this.FileName = fileName.Trim('"');

        //    var fileFolderPath = System.Web.Hosting.HostingEnvironment.MapPath(Controllers.FileController.FileFolder);
        //    var fileFullPath = Path.Combine(fileFolderPath, this.FileName);

        //    File.Copy(localFileName, fileFullPath, true);

        //    File.Delete(localFileName);

        //    this.DownloadLink = origion + "/" + Controllers.FileController.FileFolder.TrimStart('~') + "/" + this.FileName;
        //}

        //public ResimEn(string fileName, byte[] file, string origin)
        //{
        //    this.FileName = fileName;
        //    var fileFolderPath = System.Web.Hosting.HostingEnvironment.MapPath(Controllers.FileController.FileFolder);
        //    var fileFullPath = Path.Combine(fileFolderPath, this.FileName);
        //    File.WriteAllBytes(fileFullPath, file);
        //    this.DownloadLink = origin + Controllers.FileController.FileFolder.TrimStart('~') + "/" + this.FileName;
        //}

        public int ID { get; set; }
        public int KullaniciID { get; set; }
        public int BitkiID { get; set; }
        public string FileName { get; set; }
        public string DownloadLink { get; set; }
        public string FileBase64String { get; set; }
        public int ResminEni { get; set; }
        public int ResminBoyu { get; set; }
        public int minOran { get; set; }
        public int maxOran { get; set; }
        public string resimYolu { get; set; }
    }
}
