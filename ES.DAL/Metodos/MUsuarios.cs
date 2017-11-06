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

        public void ActualizarUsuario(Usuarios usuarios)
        {
            _db.Update(usuarios);
        }

        public Usuarios BuscarUsuario(string usuario)
        {
            return _db.Select<Usuarios>(x => x.Username == usuario).FirstOrDefault();
        }

        public void EliminarUsuario(string usuario)
        {
            _db.Delete<Usuarios>(x => x.Username == usuario);
        }

        public void InsertarUsuario(Usuarios usuarios)
        {
            _db.Insert(usuarios);
        }

        public List<Usuarios> ListaUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}