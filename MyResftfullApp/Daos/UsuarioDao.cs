using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyResftfullApp.Daos.Interfaces;
using MyResftfullApp.Dtos;

namespace MyResftfullApp.Daos
{
    public class UsuarioDao: IUsuarioDao
    {
        private VirtualMindDataBaseEntities DBEntities { get; set; }

        public UsuarioDao()
        {
            DBEntities = new VirtualMindDataBaseEntities();
        }

        public int Create(Usuario usuario)
        {
            DBEntities.Usuario.Add(usuario);
            return DBEntities.SaveChanges();
        }

        public IList<Usuario> GetAll()
        {
            return DBEntities.Usuario.ToList();
        }

        public void Update(int usuarioId, Usuario usuario)
        {
            var oldUsuario = DBEntities.Usuario.Where(x => x.Id == usuarioId).Single();

            oldUsuario.Nombre = usuario.Nombre;
            oldUsuario.Apellido = usuario.Apellido;
            oldUsuario.Email = usuario.Email;
            oldUsuario.Password = usuario.Password;

            DBEntities.SaveChanges();
        }

        public void Delete(int usuarioId)
        {
            var usuarioToDelete = new Usuario()
            {
                Id = usuarioId
            };

            DBEntities.Usuario.Attach(usuarioToDelete);
            DBEntities.Usuario.Remove(usuarioToDelete);
            DBEntities.SaveChanges();
        }
    }
}