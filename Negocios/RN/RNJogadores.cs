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
    public class RNJogadores : RnGenerica<Jogadores>
    {
        private Jogadores p = new Jogadores();
        private PalpitecoEntities banco = new PalpitecoEntities();
        public void InserirPerfil(Jogadores j)
        {
            Insert(j);
        }
        public void AtualizarPerfil(Jogadores j)
        {
            Update(j);
        }

        public void DeletarJogador(int id)
        {
            var jogador = FindById(id);
            Delete(jogador);
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
            return FindAll();
        }
        public List<Jogadores> RetornaJogadoresPerfil(int idPerfil)
        {
            //List<Jogadores> lista = new List<Jogadores>();

            var jogadores = banco.Jogadores.Where(j => j.IdPerfil == idPerfil).ToList();
            return jogadores;
        }
    }
}
