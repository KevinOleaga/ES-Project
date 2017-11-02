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
    
    public class MGrupo_Alumnos : IGrupo_Alumnos
    {
        private OrmLiteConnectionFactory _conexion;
    private IDbConnection _db;

    public MGrupo_Alumnos()
    {
        _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
        _db = _conexion.Open();
    }
        public void ActualizarGrupo_Alumnos(Grupo_Alumnos grupo_alumnos)
        {
            throw new NotImplementedException();
        }

        public Grupo_Alumnos BuscarGrupo_Alumnos(int idgrupo)
        {
            throw new NotImplementedException();
        }

        public void EliminarGrupo_Alumnos(int idgrupo)
        {
            throw new NotImplementedException();
        }

        public void InsertarGrupo_Alumnos(Grupo_Alumnos grupo_alumnos)
        {
            throw new NotImplementedException();
        }

        public List<Grupo_Alumnos> ListaGrupo_Alumnos()
        {
            throw new NotImplementedException();
        }
    }
}
