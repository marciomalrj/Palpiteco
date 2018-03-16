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
    public class RnPerfil : RnGenerica<Perfil>
    {
        private Perfil p = new Perfil();
        private PalpitecoEntities banco = new PalpitecoEntities();
        public void InserirPerfil(Perfil p)
        {
            Insert(p);
        }

        public void AtualizarPerfil(Perfil p)
        {
            Update(p);
        }

        public void DeletarPerfil(int id)
        {
            var perfil = FindById(id);
            Delete(perfil);
        }

        public Perfil RetornarPorId(int id)
        {
            using (PalpitecoEntities con = new PalpitecoEntities())
            {
                return con.Perfil.Where(p => p.IdPerfil == id).First();
            }
        }

        public List<Perfil> RetornaListaPerfil()
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
