using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;

        public Medicamentos() 
        {
            this.listaMedicamentos = new List<Medicamento>();
        }

        public void adicionar(Medicamento medicamento)
        {
            this.listaMedicamentos.Add(medicamento);
        }

        public bool deletar(Medicamento medicamento)
        {
            bool retorno = false;
            foreach (Medicamento medicamento2 in this.listaMedicamentos)
            {
                if (medicamento.Id == medicamento2.Id)
                {
                    if (medicamento2.qtdeDisponivel() == 0)
                    {
                        this.listaMedicamentos.Remove(medicamento2);
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {

        }
    }
}
