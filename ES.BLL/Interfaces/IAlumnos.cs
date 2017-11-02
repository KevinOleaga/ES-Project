﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;

namespace ES.BLL.Interfaces
{
   public interface IAlumnos
    {
        
            List<Alumnos> ListaAlumnos();
            // Select por PK
            Alumnos BuscarAlumnos(int idAlumnos);
            // Insert
            void InsertarAlumnos(Alumnos alumnos);
            // Update
            void ActualizarAlumnos(Alumnos alumnos);
            // Delete
            void EliminarAlumnos(int idAlumnos);
            //buscar productos por categorias
            List<Alumnos> ListarProductos(int idCalificaciones);
        
    }
}
