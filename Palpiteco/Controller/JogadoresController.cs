using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.Views;
using Negocios.Apresentacao;
using Persistencia;
using Negocios.RN;

namespace Palpiteco.Controller
{
    public class JogadoresController
    {
        private JogadoresApresentacao ja = new JogadoresApresentacao();
        private Jogadores jogadores = new Jogadores();
        private RNJogadores rnJogador = new RNJogadores();

        public void InserirJogador(JogadoresView j)
        {
            try
            {
                rnJogador.InserirJogador(j);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível inserir o jogador: " + ex.Message);
            }
        }
    }
}