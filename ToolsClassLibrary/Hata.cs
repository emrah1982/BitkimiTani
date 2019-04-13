using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsClassLibrary
{
   public class Hata
    {

        public string HataYap()
        {
            Exception hata = new Exception();
            throw hata;
        }
    }
}
