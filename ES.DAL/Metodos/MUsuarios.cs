using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using System.Data;
using ES.DAL.Interfaces;
using ES.DATA;

namespace ES.DAL.Metodos
{
    public class MUsuarios : IUsuarios
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MUsuarios()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarEncargado(Encargado encargado)
        {
            throw new NotImplementedException();
        }

        public Encargado BuscarEncargado(int idEncargado)
        {
            throw new NotImplementedException();
        }

        public void EliminarEncargado(int idEncargado)
        {
            throw new NotImplementedException();
        }

        public void InsertarEncargado(Encargado encargado)
        {
            throw new NotImplementedException();
        }

        public List<Encargado> ListaEncargado()
        {
            throw new NotImplementedException();
        }
    }
}
