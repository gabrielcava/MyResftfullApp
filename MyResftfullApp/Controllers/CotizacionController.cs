using MyResftfullApp.Dtos;
using MyResftfullApp.Models.Enum;
using MyResftfullApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyResftfullApp.Controllers
{
    [RoutePrefix("MyResftfullApp/Cotizacion")]
    public class CotizacionController : ApiController
    {
        public Moneda GetEstrategia(TipoMoneda tipoMoneda)
        {
            switch (tipoMoneda)
            {
                case TipoMoneda.Dolar:
                    return new Dolar();
                case TipoMoneda.Peso:
                    return new Peso();
                case TipoMoneda.Real:
                    return new Real();
                default:
                    throw new ArgumentException();
            }
        }

        [Route("{tipoMoneda}")]
        [HttpGet]
        public CotizacionDto GetCotizacion([FromUri] string tipoMoneda)
        {
            var estrategia = this.GetEstrategia(((TipoMoneda)Enum.Parse(typeof(TipoMoneda),tipoMoneda)));

            var cotizacionDto = new CotizacionDto();

            cotizacionDto.Value = estrategia.GetCotizacion();

            return cotizacionDto;
        }
    }
}