using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClassLibrary
{
   public class BaglantiDB
    {
        public SqlConnection Baglanti()
        {
            string connectionString = "Data Source=DESKTOP-69OSIAF;Initial Catalog=BitkimiTani;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            
            return conn;
        }
    } 
}
