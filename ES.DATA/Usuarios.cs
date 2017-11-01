using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ES.DATA
{
    public class Usuarios
    {
        public string Username { get; set; }

        public int Password { get; set; }
        [AutoIncrement]
        public int IdRol { get; set; }

        public int IntentosFallidos { get; set; }

        public bool CuentasBloqueada { get; set; }

        public byte[] Foto { get; set; }

        public int? Telefono { get; set; }

    }

}
