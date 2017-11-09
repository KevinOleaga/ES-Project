using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MMaterias : IMaterias
    {
        private DAL.Interfaces.IMaterias mate;
        public MMaterias()
        {
            mate = new DAL.Metodos.MMaterias();
        }

        public void ActualizarMaterias(Materias materias)
        {
            throw new NotImplementedException();
        }

        public Materias BuscarMaterias(int idmaterias)
        {
            throw new NotImplementedException();
        }

        public Materias BuscarMateriasNombre(string materias)
        {
            throw new NotImplementedException();
        }

        public void EliminarMaterias(int materias)
        {
            throw new NotImplementedException();
        }

        public void InsertarMaterias(Materias materias)
        {
            throw new NotImplementedException();
        }

        public List<Materias> ListarMaterias()
        {
            throw new NotImplementedException();
        }
    }
}
