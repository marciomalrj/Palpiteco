using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Palpiteco.Controller;
using Negocios.Views;

namespace Palpiteco.Site.Administracao
{
    public partial class CadastrarPerfil : System.Web.UI.Page
    {
        PerfilView pervilView = new PerfilView();
        PerfilController perfilController = new PerfilController();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                pervilView.NomePerfil = txtNome.Text;
                perfilController.InserirPerfil(pervilView);

            }
        }
    }
}