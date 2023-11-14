using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08
{
    internal class Fretamento
    {
        private List<Viagem> viagens;
        private List<Aeroporto> aeroportos;
        private Garagem garagem;
        private bool jornada = false;

        internal List<Viagem> Viagens { get => viagens; set => viagens = value; }
        internal List<Aeroporto> Aeroportos { get => aeroportos; set => aeroportos = value; }
        internal Garagem Garagem { get => garagem; set => garagem = value; }
        public bool Jornada { get => jornada; set => jornada = value; }

        public Fretamento() 
        {
            Viagens = new List<Viagem>();
            Aeroportos= new List<Aeroporto>();
            Garagem= new Garagem();
        }

        public void iniciaJornada()
        {
            int counter = 0;

            foreach (Veiculo v in this.Garagem.ListaVeiculo)
            {
                if (counter < Aeroportos.Count)
                {
                    Aeroportos[counter].PilhaVeiculos.Push(v);
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                
            }

            Jornada = true;
        }

        public string encerraJornada()
        {
            string retorno = "";

            foreach (Veiculo v in Garagem.ListaVeiculo)
            {
                retorno += "Carro: " + v.Id + "\n";
                retorno += "Quantidade de passageiros transportados: " + (v.QtdLotacao * v.QtdViagem) + "\n" + "\n";

                v.QtdViagem = 0;
            }

            Jornada = false;
            return retorno;
        }

        public bool permiteViagem(Aeroporto aeroportoSaida)
        {
            bool retorno = true;

            if (Jornada == false)
            {
                retorno = false;
            }
            else
            {
                if (aeroportoSaida.PilhaVeiculos.Count == 0)
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        public Aeroporto procuraAeroporto(int id)
        {
            Aeroporto achei = new Aeroporto();

            foreach (Aeroporto aeroporto in aeroportos)
            {
                if (aeroporto.Id == id)
                {
                    achei= aeroporto;
                    break;
                }
            }

            return achei;
        }

        public string qtdViagemEspecifica(Aeroporto a1, Aeroporto a2)
        {
            int counter = 0;

            foreach (Viagem v in this.Viagens)
            {
                if (v.AeroportoSaida == a1 && v.AeroportoChegada == a2)
                {
                    counter++;
                }
            }

            return "A quantidade de viagens de " + a1.Nome + " para " + a2.Nome + " é de: " + counter; 
        }

        public string listaViagemEspecifica(Aeroporto a1, Aeroporto a2)
        {
            string retorno = "Viagens de " + a1.Nome + " para " + a2.Nome + ": \n";
            int counter = 1;

            foreach (Viagem v in this.Viagens)
            {
                if (v.AeroportoSaida == a1 && v.AeroportoChegada == a2)
                {
                    retorno += counter + "ª viagem - carro " + v.Veiculo.Id + "\n";
                    counter++;
                }
            }
            return retorno;
        }

        public string qtdPassageirosViagemEspecifica(Aeroporto a1, Aeroporto a2)
        {
            int counter = 0;

            foreach (Viagem v in this.Viagens)
            {
                if (v.AeroportoSaida == a1 && v.AeroportoChegada == a2)
                {
                    counter += v.Veiculo.QtdLotacao;
                }
            }

            return "A quantidade de pessoas transportadas de " + a1.Nome + " para " + a2.Nome + " é de: " + counter;
        }
    }
}
