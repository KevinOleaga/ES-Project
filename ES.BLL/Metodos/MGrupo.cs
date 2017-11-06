using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MGrupo : IGrupo
    {
        private DAL.Interfaces.IGrupo gru;
        public MGrupo()
        {
            gru = new DAL.Metodos.MGrupo();
        }
        public void ActualizarGrupo(Grupo grupo)
        {
            gru.ActualizarGrupo(grupo);
        }

        public Grupo BuscarGrupo(int idgrupo)
        {
            return gru.BuscarGrupo(idgrupo);
        }

        public Grupo BuscarGrupoNombre(string grupo)
        {
            return gru.BuscarGrupo(grupo);
        }

        public void EliminarGrupo(int idgrupo)
        {
            gru.EliminarGrupo(idgrupo);
        }

        public void InsertarGrupo(Grupo grupo)
        {
            gru.InsertarGrupo(grupo);
        }

        public List<Grupo> ListarGrupo()
        {
            throw new NotImplementedException();
        }
    }
}
