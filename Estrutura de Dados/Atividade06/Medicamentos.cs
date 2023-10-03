using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06
{
    internal class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;

        public Medicamentos()
        {
            this.ListaMedicamentos = new List<Medicamento>();
        }

        internal List<Medicamento> ListaMedicamentos { get => listaMedicamentos; set => listaMedicamentos = value; }

        public void adicionar(Medicamento medicamento)
        {
            this.ListaMedicamentos.Add(medicamento);
        }

        public bool deletar(Medicamento medicamento)
        {
            bool retorno = false;
            foreach (Medicamento medicamento2 in this.ListaMedicamentos)
            {
                if (medicamento.Id == medicamento2.Id)
                {
                    if (medicamento2.qtdeDisponivel() == 0)
                    {
                        this.ListaMedicamentos.Remove(medicamento2);
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            Medicamento achado = new Medicamento();

            foreach (Medicamento m in this.ListaMedicamentos)
            {
                if (m.Id == medicamento.Id)
                {
                    achado = m;
                }
            }

            return achado;
        }
    }
}
