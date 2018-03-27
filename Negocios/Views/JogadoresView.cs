using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Views
{
    public class JogadoresView
    {
        public int? IdJogador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int? IdPerfil { get; set; }
        public string FotoPerfil { get; set; }
        public Perfil Perfil { get; set; }
        public ICollection<Palpites> Palpites { get; set; }
    }
}
