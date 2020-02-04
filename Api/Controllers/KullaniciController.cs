using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class KullaniciController : ApiController
    {

        public string KullaniciGetir()
        {
            return "merhaba";
        }

        /// <summary>
        /// Parametre istek öneği
        /// 
        ///  {
        ///    "KULLANICI_AD" : "",
        ///    "SIFRE" : ""
        ///  }
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        public DenemeKullanici Login(DenemeKullanici model)
        {
            DenemeKullanici kul = new DenemeKullanici()
            {
                KULLANICI_AD = model.KULLANICI_AD,
                SIFRE = model.SIFRE
            };
            return kul; 
          
        }
        public class DenemeKullanici
        {
            public string KULLANICI_AD { get; set; }
            public string SIFRE { get; set; }
        }
    }
}
