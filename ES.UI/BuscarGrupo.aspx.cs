using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using ES.DATA;
namespace ES.UI
{
    public partial class BuscarGrupo : System.Web.UI.Page
    {
        public IGrupo grup;
        public BuscarGrupo()
        {
            grup = new MGrupo();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        void CargarDatos()
        {
            List<Grupo> listaGrupo = grup.ListarGrupo();

            gvDatos.DataSource = listaGrupo.Select(x => new {
                x.IdGrupo,
               x.Aula

            });
            gvDatos.DataBind();
        }
    }
}