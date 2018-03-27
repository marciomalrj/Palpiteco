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
    public class JogadoresApresentacao
    {
        private Jogadores perfil = new Jogadores();
        private RNJogadores rnPerfil = new RNJogadores();
        private JogadoresView perfilView = new JogadoresView();
        private List<Jogadores> jogadores = new List<Jogadores>();

        public void CadastrarPerfil(JogadoresView jogadoresView)
        {
            perfil.NomePerfil = jogadoresView.Nome;
            perfil.Jogadores = jogadoresView.;

            rnPerfil.InserirPerfil(perfil);
        }

    }
}
