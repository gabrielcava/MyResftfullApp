using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResftfullApp.Dtos
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}