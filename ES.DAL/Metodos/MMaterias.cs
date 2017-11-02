using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DAL.Interfaces;
using ES.DATA;
using ServiceStack.OrmLite;
using System.Data;

namespace ES.DAL.Metodos
{
    public class MMaterias : IMaterias
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MMaterias()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarMaterias(Materias materias)
        {
            throw new NotImplementedException();
        }

        public Materias BuscarMaterias(int idmaterias)
        {
            throw new NotImplementedException();
        }

        public Materias BuscarMaterias(string materias)
        {
            throw new NotImplementedException();
        }

        public void EliminarMaterias(int materias)
        {
            throw new NotImplementedException();
        }

        public void InsertarMaterias(Materias materias)
        {
            throw new NotImplementedException();
        }

        public List<Materias> ListarMaterias()
        {
            throw new NotImplementedException();
        }
    }
}
