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
    public class MGrupo : IGrupo
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MGrupo()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarGrupo(Grupo grupo)
        {
            throw new NotImplementedException();
        }

        public Grupo BuscarGrupo(int idgrupo)
        {
            throw new NotImplementedException();
        }

        public Grupo BuscarGrupo(string grupo)
        {
            throw new NotImplementedException();
        }

        public void EliminarGrupo(int idgrupo)
        {
            throw new NotImplementedException();
        }

        public void InsertarGrupo(Grupo grupo)
        {
            throw new NotImplementedException();
        }

        public List<Grupo> ListarGrupo()
        {
            throw new NotImplementedException();
        }
    }
}
