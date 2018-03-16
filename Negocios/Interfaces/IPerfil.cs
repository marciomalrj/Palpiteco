using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Persistencia;

namespace Negocios.Interfaces
{
    interface IPerfil : IGenerica<Perfil>
    {
        ICollection<Jogadores> BuscarJogadoresPorPerfil(int id);
    }
}
