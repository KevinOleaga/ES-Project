using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Data;
using ES.DATA;
namespace ES.DAL.Metodos
{
    public class Mroles : IRoles
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public Mroles()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarRoles(Roles roles)
        {
            throw new NotImplementedException();
        }

        public Roles BuscarRoles(int idRoles)
        {
            throw new NotImplementedException();
        }

        public Roles BuscarRoles(string roles)
        {
            throw new NotImplementedException();
        }

        public void EliminarRoles(int idroles)
        {
            throw new NotImplementedException();
        }

        public void InsertarRoles(Roles roles)
        {
            throw new NotImplementedException();
        }

        public List<Roles> ListarRoles()
        {
            throw new NotImplementedException();
        }
    }
}
