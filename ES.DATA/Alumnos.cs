using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DATA
{
    public class Alumnos
    {
        [AutoIncrement]
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Padecimientos { get; set; }
        public string Direcion { get; set; }
        public int IdEncargado { get; set; }
        public bool Graduado { get; set; }
        public bool Abandono { get; set; }
        public string AñoGraduacion { get; set; }


    }
}
