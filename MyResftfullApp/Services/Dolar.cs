using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace MyResftfullApp.Services
{
    public class Dolar :Moneda
    {
        public override string GetCotizacion()
        {
            HttpClient client = new HttpClient();

            return client.GetStringAsync("http://www.bancoprovincia.com.ar/Principal/Dolar").Result;
        }
    }
}