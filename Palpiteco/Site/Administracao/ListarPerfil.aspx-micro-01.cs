using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.Apresentacao;

namespace Palpiteco.Site.Administracao
{
    public partial class ListarPerfil : System.Web.UI.Page
    {
        private static PerfilApresentacao perfilApresentacao = new PerfilApresentacao();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static string ListarPerfis()
        {
            
            JavaScriptSerializer js = new JavaScriptSerializer();
            try
            {
                var lista = perfilApresentacao.ListarPerfil();

                js.MaxJsonLength = Int32.MaxValue;
                var t = js.Serialize(lista);
                return js.Serialize(lista);
            }
            catch (Exception ex)
            {
                return js.Serialize("false");
                throw new ApplicationException("erro", ex);
            }
        }
    }
}