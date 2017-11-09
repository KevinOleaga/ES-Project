﻿using System;
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
    public class MEncargado : IEncargado
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MEncargado()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarEncargado(Encargado encargado)
        {
            _db.Update(encargado);
        }

        public Encargado BuscarEncargado(string cedula)
        {
            return _db.Select<Encargado>(x => x.Cedula == cedula)
                 .FirstOrDefault();
        }

        public void EliminarEncargado(int idEncargado)
        {
            _db.Delete<Encargado>(x => x.IdEncargado == idEncargado);
        }

        public void InsertarEncargado(Encargado encargado)
        {
            _db.Insert(encargado);
        }

        public List<Encargado> ListaEncargado()
        {
            return _db.Select<Encargado>();
        }
    
    }
}
