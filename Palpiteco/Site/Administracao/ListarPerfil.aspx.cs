using System;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using Palpiteco.Controller;

namespace Palpiteco.Site.Administracao
{
    public partial class ListarPerfil : System.Web.UI.Page
    {
        private static PerfilController perfilAcoes = new PerfilController();
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
                var lista = perfilAcoes.RetornarPerfis();

                js.MaxJsonLength = Int32.MaxValue;
                //var t = js.Serialize(lista);
                return js.Serialize(lista);
            }
            catch (Exception ex)
            {
                return js.Serialize("false");
                throw new ApplicationException("erro", ex);
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static string ExcluirPerfil(int id)
        {

            JavaScriptSerializer js = new JavaScriptSerializer();
            try
            {
                perfilAcoes.Delete(id);
                return js.Serialize("true");
            }
            catch (Exception ex)
            {
                return js.Serialize("false");
                throw new ApplicationException("erro", ex);
            }
        }
    }
}