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
    public partial class EditarGrupo : System.Web.UI.Page
    {
        public IGrupo gru;
        public EditarGrupo()
        {
            gru = new MGrupo();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        protected void btnModifcar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdGrupo.Text) && !string.IsNullOrEmpty(txtAula.Text))
                {

                    gru = new MGrupo();
                    Grupo grupo = new Grupo
                    {
                        Aula = txtAula.Text,
                        IdGrupo= Convert.ToInt32(txtIdGrupo.Text)
                    };
                    gru.ActualizarGrupo(grupo);
                    mensaje.Visible = true;
                    mensajeError.Visible = false;
                    mensajeInfo.Visible = false;
                    textoMensaje.InnerHtml = "Grupo agregado";
                }

                else
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = false;
                    mensajeInfo.Visible = true;
                    textomensajeInfo.InnerHtml = "Error";
                    txtAula.Focus();
                }

            }
            catch (Exception)
            {
                mensajeInfo.Visible = false;
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textomensajeError.InnerHtml = "Hubo un error";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var grupo = gru.BuscarGrupo(Convert.ToInt32(txtIdGrupo.Text));
                if (grupo != null)
                {
                    divMantenimiento.Visible = true;

                   txtAula.Text = grupo.Aula;

                }
                else
                {
                    mensajeInfo.Visible = false;
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textomensajeError.InnerHtml = "El alumno no existe";

                }
            }
            catch (Exception)
            {
                mensajeInfo.Visible = false;
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textomensajeError.InnerHtml = "Hubo un error";
            }
        }
    }
}