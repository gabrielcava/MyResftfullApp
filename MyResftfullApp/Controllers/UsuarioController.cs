using MyResftfullApp.Daos;
using MyResftfullApp.Dtos;
using MyResftfullApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyResftfullApp.Controllers
{
    [RoutePrefix("MyResftfullApp/Usuario")]
    public class UsuarioController : ApiController
    {
        private UsuarioService UsuarioService { get; set; }

        public UsuarioController()
        {
            UsuarioService = new UsuarioService();
        }

        [Route]
        [HttpGet]
        public IList<UsuarioDto> GetAllUsuarios()
        {
            var usuarioList = UsuarioService.GetAllUsuarios();

            var usuarioDtoList = new List<UsuarioDto>();

            foreach (var usuario in usuarioList)
            {
                usuarioDtoList.Add(MapEntityToDto(usuario));
            }

            return usuarioDtoList;
        }

        [Route]
        [HttpPost]
        public UsuarioDto CreateUsuario([FromBody]UsuarioDto usuarioDto)
        {
            Usuario usuario = MapDtoToEntity(usuarioDto);

            usuarioDto.Id = UsuarioService.CreateUsuario(usuario);

            return usuarioDto;
        }

        [Route("{usuarioId}")]
        [HttpPut]
        public void UpdateUsuario([FromUri]int usuarioId, [FromBody]UsuarioDto usuarioDto)
        {
            Usuario usuario = MapDtoToEntity(usuarioDto);

            UsuarioService.UpdateUsuario(usuarioId, usuario);
        }

        [Route("{usuarioId}")]
        [HttpDelete]
        public void DeleteUsuario([FromUri]int usuarioId)
        {
            UsuarioService.DeleteUsuario(usuarioId);
        }

        private Usuario MapDtoToEntity(UsuarioDto usuarioDto)
        {
            return new Usuario()
            {
                Nombre = usuarioDto.Nombre,
                Apellido = usuarioDto.Apellido,
                Email = usuarioDto.Email,
                Password = usuarioDto.Password
            };
        }

        private UsuarioDto MapEntityToDto(Usuario usuario)
        {
            return new UsuarioDto()
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
                Password = usuario.Password
            };
        }
    }
}