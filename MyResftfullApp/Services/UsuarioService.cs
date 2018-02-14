using MyResftfullApp.Daos;
using MyResftfullApp.Daos.Interfaces;
using MyResftfullApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResftfullApp.Services
{
    public class UsuarioService
    {
        private IUsuarioDao UsuarioDao { get; set; }

        public UsuarioService()
        {
            UsuarioDao = new UsuarioDao();
        }

        public UsuarioService(IUsuarioDao usuarioDao)
        {
            this.UsuarioDao = usuarioDao;
        }

        public int CreateUsuario(Usuario usuario)
        {
            return UsuarioDao.Create(usuario);
        }

        public IList<Usuario> GetAllUsuarios()
        {
            return UsuarioDao.GetAll();
        }

        public void UpdateUsuario(int usuarioId, Usuario usuario)
        {
            UsuarioDao.Update(usuarioId, usuario);
        }

        public void DeleteUsuario(int usuarioId)
        {
            UsuarioDao.Delete(usuarioId);
        }
    }
}