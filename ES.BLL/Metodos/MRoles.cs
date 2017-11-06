using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MRoles : IRoles
    {
        private DAL.Interfaces.IRoles rol;
        public MRoles()
        {
            rol= new DAL.Metodos.Mroles();
        }
        public void ActualizarRoles(Roles roles)
        {
            rol.ActualizarRoles(roles);
        }

        public Roles BuscarRoles(int idRoles)
        {
            return rol.BuscarRoles(idRoles);
        }

        public Roles BuscarRolesNombre(string roles)
        {
            return rol.BuscarRoles(roles);
        }

        public void EliminarRoles(int idroles)
        {
            rol.EliminarRoles(idroles);
        }

        public void InsertarRoles(Roles roles)
        {
            rol.InsertarRoles(roles);
        }

        public List<Roles> ListarRoles()
        {
            return rol.ListarRoles();
        }
    }
}
