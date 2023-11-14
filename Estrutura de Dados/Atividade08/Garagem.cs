using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08
{
    internal class Garagem
    {
        private List<Veiculo> listaVeiculo = new List<Veiculo>();

        internal List<Veiculo> ListaVeiculo { get => listaVeiculo; set => listaVeiculo = value; }
    }
}
