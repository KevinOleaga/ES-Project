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
    public class MGrupo_Profesor : IGrupo_Profesor
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MGrupo_Profesor()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarGrupo_Profesor(Grupo_Profesor grupo_profesor)
        {
            throw new NotImplementedException();
        }

        public Grupo_Profesor BuscarGrupo_Profesor(int idgrupo)
        {
            throw new NotImplementedException();
        }

        public void EliminarGrupo_Profesor(int idgrupo)
        {
            throw new NotImplementedException();
        }

        public void InsertarGrupo_Profesor(Grupo_Profesor grupo_profesor)
        {
            throw new NotImplementedException();
        }

        public List<Grupo_Profesor> ListaGrupo_Profesor()
        {
            throw new NotImplementedException();
        }
    }
}
