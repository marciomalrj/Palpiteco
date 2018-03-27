using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Negocios.Interfaces;
using Negocios.RN;

namespace Negocios.RN
{
    public class RNJogadores //: RnGenerica<Jogadores>
    {
        private IJogadores iJogador;
        private Jogadores p = new Jogadores();
        private PalpitecoEntities banco = new PalpitecoEntities();
        public void InserirJogador(Jogadores j)
        {
            iJogador.Insert(j);
            // Insert(j);
        }
        public void AtualizarJogador(Jogadores j)
        {
            iJogador.Update(j);
        }

        public void DeletarJogador(int id)
        {
            var jogador = iJogador.FindById(id);
            iJogador.Delete(jogador);
        }

        public Jogadores RetornarPorId(int id)
        {

            using (PalpitecoEntities con = new PalpitecoEntities())
            {
                return con.Jogadores.Where(j => p.IdJogador == id).First();
            }
        }

        public List<Jogadores> RetornaListaJogadores()
        {
            return iJogador.FindAll();
        }
        public List<Jogadores> RetornaJogadoresPerfil(int idPerfil)
        {
            //List<Jogadores> lista = new List<Jogadores>();
            //iJogadores.
            var jogadores = banco.Jogadores.Where(j => j.IdPerfil == idPerfil).ToList();
            return jogadores;
        }
    }
}
