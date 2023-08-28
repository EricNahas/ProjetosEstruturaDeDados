using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    internal class Telefone
    {
        private string tipo, numero;
        private bool principal;

        public Telefone(string tipo, string numero, bool principal)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.principal = principal;
        }

        public Telefone(string tipo, string numero)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.principal = true;
        }

        public bool Principal { get => principal; set => principal = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Numero { get => numero; set => numero = value; }

    }
}