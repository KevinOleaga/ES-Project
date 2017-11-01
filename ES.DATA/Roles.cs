using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ES.DATA
{
    public class Roles
    {
        [AutoIncrement]
        public int IdRol { get; set; }

        public string Rol { get; set; }

    }
}
