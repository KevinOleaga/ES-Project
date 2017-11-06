﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;
using ES.BLL.Interfaces;
namespace ES.BLL.Metodos
{
    public class MAlumnos : IAlumnos
    {
        private DAL.Interfaces.IAlumnos alu;
        public MAlumnos()
        {
            alu = new DAL.Metodos.MAlumnos();
        }
        public void ActualizarAlumnos(Alumnos alumnos)
        {
            alu.ActualizarAlumnos(alumnos);
        }

        public Alumnos BuscarAlumnos(int idAlumnos)
        {
           return alu.BuscarAlumnos(idAlumnos);
        }

        public void EliminarAlumnos(int idAlumnos)
        {
            alu.EliminarAlumnos(idAlumnos);
        }

        public void InsertarAlumnos(Alumnos alumnos)
        {
            alu.InsertarAlumnos(alumnos);
        }

        public List<Alumnos> ListaAlumnos()
        {
            return alu.ListaAlumnos();
        }

        public List<Alumnos> ListarAlumnos(int idCalificaciones)
        {
            throw new NotImplementedException();
        }

       
    }
}
