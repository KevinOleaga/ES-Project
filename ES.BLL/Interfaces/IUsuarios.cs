using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;
namespace ES.BLL.Interfaces
{
   public interface IUsuarios
    {
        List<Usuarios> ListaUsuarios();
        // Select por PK
        Usuarios BuscarUsuario(string usuario);
        // Insert
        void InsertarUsuario(Usuarios usuarios);
        // Update
        void ActualizarUsuario(Usuarios usuarios);
        // Delete
        void EliminarUsuario(string usuario);
    }
}
