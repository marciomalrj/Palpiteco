using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Palpiteco
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strPaginaAtual = Request.CurrentExecutionFilePath;
            string pagina = strPaginaAtual.Remove(0, strPaginaAtual.LastIndexOf("/") + 1);

            if (pagina.Equals("Login.aspx"))
            {
                menuControle.Visible = false;
            }
           // else
          //  {
                //if (Session["IdJogador"] == null)
                //    this.Page.Response.Redirect("../Login.aspx");
           // }
        }
    }
}