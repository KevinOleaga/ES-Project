using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DATA
{
    public class Alumnos
    {
        public int IdAlumno { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public int? Telefono { get; set; }

        public string Email { get; set; }

        public string Padecimientos { get; set; }

        public string Direcion { get; set; }

        public int IdEncargado { get; set; }

    }
}
