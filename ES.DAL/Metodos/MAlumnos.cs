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
    public class MAlumnos : IAlumnos
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MAlumnos()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarAlumnos(Alumnos alumnos)
        {
            throw new NotImplementedException();
        }

        public Alumnos BuscarAlumnos(int idAlumnos)
        {
            throw new NotImplementedException();
        }

        public void EliminarAlumnos(int idAlumnos)
        {
            throw new NotImplementedException();
        }

        public void InsertarAlumnos(Alumnos alumnos)
        {
            throw new NotImplementedException();
        }

        public List<Alumnos> ListaAlumnos()
        {
            throw new NotImplementedException();
        }

        public List<Alumnos> ListarProductos(int idAlumnos)
        {
            throw new NotImplementedException();
        }
    }
}
