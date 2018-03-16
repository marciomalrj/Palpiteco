using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.Views;
using Negocios.Apresentacao;
using Persistencia;
using Negocios.RN;
using Negocios.Interfaces;

namespace Palpiteco.Controller
{
    public class PerfilController
    {
        private PerfilApresentacao pa = new PerfilApresentacao();
        private Perfil perfil = new Perfil();
        private RnPerfil rnPerfil = new RnPerfil();

        public void InserirPerfil(PerfilView perfil)
        {
            try
            {
                pa.CadastrarPerfil(perfil);
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível inserir perfil: " + ex.Message);
            }
            
        }

        public List<PerfilView> RetornarPerfis()
        {
            try
            {
                return pa.ListarPerfil();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }
        public void Delete(int id)
        {
            pa.ExcluirPerfil(id);
        }

    }
}