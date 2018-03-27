using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Persistencia;

namespace Negocios.Interfaces
{
    interface IJogadores : IGenerica<Jogadores>
    {
        List<Jogadores> RetornaJogadoresPerfil(int idPerfil);
    }
}
