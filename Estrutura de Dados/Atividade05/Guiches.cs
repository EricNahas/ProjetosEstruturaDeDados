using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Guiches
    {
        private List<Guiche> listaGuiches;

        public Guiches()
        {
            ListaGuiches= new List<Guiche>();
        }

        internal List<Guiche> ListaGuiches { get => listaGuiches; set => listaGuiches = value; }

        public void adicionar(Guiche guiche)
        {
            ListaGuiches.Add(guiche);
        }
    }
}
