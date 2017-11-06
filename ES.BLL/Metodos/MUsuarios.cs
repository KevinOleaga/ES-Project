using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MUsuarios : IUsuarios
    {
        private DAL.Interfaces.IUsuarios usu;
        public MUsuarios()
        {
            usu = new DAL.Metodos.MUsuarios();
        }
        public void ActualizarUsuario(Usuarios usuarios)
        {
            usu.ActualizarUsuario(usuarios);
        }
        public Usuarios BuscarUsuario(string usuario)
        {
            return usu.BuscarUsuario(usuario);
        }
        public void EliminarUsuario(string usuario)
        {
            usu.EliminarUsuario(usuario);
        }
        public void InsertarUsuario(Usuarios usuarios)
        {
            usu.InsertarUsuario(usuarios);
        }
        public List<Usuarios> ListaUsuarios()
        {
            return usu.ListaUsuarios();
        }
    }
}
