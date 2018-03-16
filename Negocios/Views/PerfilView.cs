using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Views
{
    public class PerfilView
    {
        public int? IdPerfil { get; set; }
        public string NomePerfil { get; set; }
        public string Acoes { get; set; }
        public ICollection<Jogadores> Jogadores { get; set; }
    }
}
