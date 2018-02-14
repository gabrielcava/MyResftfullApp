using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace MyResftfullApp.Services
{
    public class Real : Moneda
    {
        public override string GetCotizacion()
        {
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }
    }
}