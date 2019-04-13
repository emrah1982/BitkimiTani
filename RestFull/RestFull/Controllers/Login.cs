using RestFull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace RestFull.Controllers
{
    public class Login : ApiController
    {
        // GET api/<controller>
        

        // GET api/<controller>/5
        public string Get()
        {
            Bitki btk = new Bitki();
            string s = JsonConvert.SerializeObject(btk.GetBitkiAdlari());
            return s;
        }

        // POST api/<controller>
        public void Post(string username, string password)
        {


        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}