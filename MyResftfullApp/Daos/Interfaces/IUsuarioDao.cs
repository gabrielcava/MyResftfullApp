using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResftfullApp.Daos.Interfaces
{
    public interface IUsuarioDao
    {
        int Create(Usuario usuario);

        IList<Usuario> GetAll();

        void Update(int usuarioId, Usuario usuario);

        void Delete(int usuarioId);
    }
}
