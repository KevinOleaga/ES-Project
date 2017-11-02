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
    public class MProfesor : IProfesor
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MProfesor()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarProfesor(Profesor profesor)
        {
            throw new NotImplementedException();
        }

        public Encargado BuscarProfesor(int idProfesor)
        {
            throw new NotImplementedException();
        }

        public void EliminarProfesor(int idProfesor)
        {
            throw new NotImplementedException();
        }

        public void InsertarProfesor(Profesor profesor)
        {
            throw new NotImplementedException();
        }

        public List<Profesor> ListaProfesor()
        {
            throw new NotImplementedException();
        }
    }
}
