using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;
namespace ES.BLL.Interfaces
{
  public interface IEncargado
    {
        List<Encargado> ListaEncargado();
        // Select por PK
        Encargado BuscarEncargado(int idEncargado);
        // Insert
        void InsertarEncargado(Encargado encargado);
        // Update
        void ActualizarEncargado(Encargado encargado);
        // Delete
        void EliminarEncargado(int idEncargado);
    }
}
