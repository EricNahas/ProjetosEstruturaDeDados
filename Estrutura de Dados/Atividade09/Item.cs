using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    internal class Item
    {
        private string nome;
        private int id;
        private double vlrDiario;
        private bool avaria;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public double VlrDiario { get => vlrDiario; set => vlrDiario = value; }
        public bool Avaria { get => avaria; set => avaria = value; }

        public Item(string nome, int id, double vlrDiario) 
        {
            Nome = nome;
            Id = id;
            VlrDiario = vlrDiario;
            Avaria = false;
        }
    }
}
