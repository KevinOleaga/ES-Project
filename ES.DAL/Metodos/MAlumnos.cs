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
            _db.Update(alumnos);
        }

        public Alumnos BuscarAlumnos(int idAlumnos)
        {
            return _db.Select<Alumnos>(x => x.IdAlumno == idAlumnos)
               .FirstOrDefault();
        }

        public void EliminarAlumnos(int idAlumnos)
        {
            _db.Delete<Alumnos>(x => x.IdAlumno == idAlumnos);
        }

        public void InsertarAlumnos(Alumnos alumnos)
        {
            _db.Insert(alumnos);
        }

        public List<Alumnos> ListaAlumnos()
        {
            return _db.Select<Alumnos>();
        }

        public List<Alumnos> ListarAlumnos(int idAlumnos)
        {
            return _db.Select<Alumnos>(x => x.IdAlumno == idAlumnos);
        }
    }
}
