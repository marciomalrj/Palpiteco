using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocios.RN;
using Negocios.Interfaces;
using Negocios.Views;
using Persistencia;


namespace Negocios.Apresentacao
{
    public class PerfilApresentacao
    {

        private Perfil perfil = new Perfil();
        private RnPerfil rnPerfil = new RnPerfil();
        private PerfilView perfilView = new PerfilView();
        private List<Jogadores> jogadores = new List<Jogadores>();

        public void CadastrarPerfil(PerfilView perfilView)
        {
            perfil.NomePerfil = perfilView.NomePerfil;
            perfil.Jogadores = perfilView.Jogadores;

            rnPerfil.InserirPerfil(perfil);
        }

        public List<PerfilView> ListarPerfil()
        {
            var lista = new List<PerfilView>();

            try
            {
                foreach (var p in rnPerfil.RetornaListaPerfil())
                {

                    var view = new PerfilView();
                    view.IdPerfil = p.IdPerfil;
                    view.NomePerfil = p.NomePerfil;
                    view.Acoes = AdicionarAcoes(p.IdPerfil);
                    view.Jogadores = p.Jogadores;

                    lista.Add(view);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível listar perfis: " + ex);
            }

        }

        public void ExcluirPerfil(int id)
        {
            try
            {
                rnPerfil.DeletarPerfil(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível excluir perfil: " + ex);
            }
           
        }

        private string AdicionarAcoes(int id)
        {
            //string acoes = "<a href=\"#\"data-role=\"button\"data-icon=\"flat-cross\"data-iconpos=\"notext\"data-theme=\"d\"data-inline=\"true\" onclick=\"ExcluirPerfil("+ id +")\">Excluir</a>";
            string acoes = "<a href=\"#\"data-role=\"button\"data-icon=\"flat-cross\"data-iconpos=\"notext\" data-theme=\"d\" data-inline=\"true\" class=\"ui-link ui-btn ui-btn-d ui-icon-flat-cross ui-btn-icon-notext ui-btn-inline ui-shadow ui-corner-all\" role=\"button\" onclick=\"ExcluirPerfil(" + id +")\">Excluir</a>";
            return acoes;
        }
    }
}
