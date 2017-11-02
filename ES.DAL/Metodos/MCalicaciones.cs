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
    class MCalicaciones : ICalificaciones
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MCalicaciones()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarCalificaciones(Calificaciones calificaciones)
        {
            throw new NotImplementedException();
        }

        public Calificaciones BuscarCalificacionese(int idcalificaciones)
        {
            throw new NotImplementedException();
        }

        public Calificaciones BuscarCalificacionesPorIdAlumnos(int idalumnos)
        {
            throw new NotImplementedException();
        }

        public Calificaciones BuscarCalificacionesPorIdMateria(int idmaterias)
        {
            throw new NotImplementedException();
        }

        public void EliminarCalificaciones(int idcalificaciones)
        {
            throw new NotImplementedException();
        }

        public void InsertarCalificaciones(Calificaciones calificaciones)
        {
            throw new NotImplementedException();
        }

        public List<Calificaciones> ListarCalificaciones()
        {
            throw new NotImplementedException();
        }
    }
}
