using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08
{
    internal class Viagem
    {
        private Aeroporto aeroportoSaida, aeroportoChegada;
        private Veiculo veiculo;

        internal Aeroporto AeroportoSaida { get => aeroportoSaida; set => aeroportoSaida = value; }
        internal Aeroporto AeroportoChegada { get => aeroportoChegada; set => aeroportoChegada = value; }
        internal Veiculo Veiculo { get => veiculo; set => veiculo = value; }

        public Viagem(Aeroporto aeroportoSaida, Aeroporto aeroportoChegada, Veiculo veiculo)
        {
            AeroportoSaida = aeroportoSaida;
            AeroportoChegada = aeroportoChegada;
            Veiculo = veiculo;

            veiculo.QtdViagem++;
        }
    }
}
