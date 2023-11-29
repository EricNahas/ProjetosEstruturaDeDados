using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    internal class Locacao
    {
        private List<Estoque> estoques;
        private List<Contrato> contratos;

        public Locacao(List<Estoque> estoques, List<Contrato> contratos)
        {
            this.Estoques = estoques;
            this.Contratos = contratos;
        }

        public Locacao()
        {
            estoques = new List<Estoque>();
            contratos = new List<Contrato>();
        }

        internal List<Estoque> Estoques { get => estoques; set => estoques = value; }
        internal List<Contrato> Contratos { get => contratos; set => contratos = value; }

        public int verificaId(List<Estoque> estoque)
        {
            int retorno = 0;
            foreach (Estoque e in estoque)
            {
                retorno++;
            }
            return retorno;
        }

        public int verificaId(List<Contrato> contrato)
        {
            int retorno = 0;
            foreach (Contrato c in contrato)
            {
                retorno++;
            }
            return retorno;
        }

        public int verificaId(Tipo_item tipoItem)
        {
            int retorno = 0;
            foreach (Item i in tipoItem.Itens)
            {
                retorno++;
            }
            return retorno;
        }

        public Tipo_item achaTipoItem(int id)
        {
            Tipo_item retorno = new Tipo_item(-1);

            foreach(Estoque e in estoques)
            {
                if (e.Tipo_item.Id == id)
                {
                    retorno = e.Tipo_item; 
                    break;
                }
            }

            return retorno;
        }

        public void cadastraTipoEquipamento(string nome, int id)
        {
            estoques.Add(new Estoque(id, new Tipo_item(nome, id)));
        }

        public string consultaTipoEquipamento()
        {
            string retorno = string.Empty;

            foreach (Estoque e in estoques)
            {
                retorno += "Estoque " + e.Id + ": \n";
                retorno += "    " + e.Tipo_item.Nome + " - ID: " + e.Tipo_item.Id + "\n"; ;
                if (e.Tipo_item.Itens.Count > 0)
                {
                    foreach (Item i in e.Tipo_item.Itens)
                    {
                        retorno += "        " + i.Nome + " - Valor diário: R$" + i.VlrDiario + "\n";
                    }
                }
            }
            return retorno;
        }

        public bool cadastraEquipamento(Tipo_item tipoItem, string nome, double vlrDiario)
        {
            bool retorno = false;

            if (tipoItem.Id != -1)
            {
                retorno = true;

                tipoItem.Itens.Add(new Item(nome, verificaId(tipoItem), vlrDiario));
            }

            return retorno;
        }

        public bool verificaItensContrato(List<Itens_contrato> itensContrato)
        {
            bool retorno = false;
            List<int> compare = new List<int>();

            foreach(Itens_contrato i in itensContrato)
            {
                foreach (Estoque e in estoques)
                {
                    if (i.ItemContrato.Id == e.Tipo_item.Id && i.Qtd <= achaTipoItem(i.ItemContrato.Id).Itens.Count)
                    {
                        compare.Add(i.ItemContrato.Id);
                        break;
                    }
                }
            }

            if (compare.Count == itensContrato.Count)
            {
                retorno= true;
            }

            return retorno;
        }

        public void registraContrato(int id, DateTime saida, DateTime retorno, List<Itens_contrato> itensContrato)
        {
            Contratos.Add(new Contrato(id, saida, retorno, itensContrato));

        }

        public string consultaContrato()
        {
            string retorno = "Não há contratos ativos no momento";

            foreach (Contrato c in Contratos)
            {
                retorno = "------------------------------------------------\n";
                retorno += "Contrato " + c.Id + "\n";
                retorno += "    Saída:" + c.AgendamentoSaida.ToShortDateString() + "\n";
                retorno += "    Retorno:" + c.AgendamentoRetorno.ToShortDateString() + "\n";
                retorno += "    Situação: " + (c.Liberado ? "Liberado" : "Aguardando") + "\n";
                retorno += "    Itens: \n";

                foreach (Itens_contrato i in c.ListaContrato)
                {
                    retorno += "        " + i.ItemContrato.Nome + " - Quantidade: " + i.Qtd + "\n";
                }
                retorno += "------------------------------------------------";
            }
            return retorno;
        }

        public bool liberaContrato(int id)
        {
            Contrato retornoContrato = null;
            bool retorno = false;

            foreach (Contrato c in contratos)
            {
                if (c.Id == id)
                {
                    retornoContrato = c;
                    break;
                }
            }

            if (retornoContrato != null && retornoContrato.Liberado == false)
            {
                if (verificaItensContrato(retornoContrato.ListaContrato))
                {
                    retorno = true;

                    foreach (Itens_contrato itemContrato in retornoContrato.ListaContrato)
                    {
                        for (int i = 0; i < itemContrato.Qtd; i++)
                        {
                            foreach (Estoque e in estoques)
                            {
                                if (e.Id == itemContrato.ItemContrato.Id)
                                {
                                    retornoContrato.Liberado = true;

                                    // Cria uma cópia da pilha Retorno
                                    Stack<Item> copiaRetorno = new Stack<Item>(e.Retorno);

                                    // Lista temporária para armazenar itens devolvidos
                                    List<Item> itensDevolvidos = new List<Item>();

                                    // Itera sobre a cópia da pilha
                                    while (copiaRetorno.Count > 0)
                                    {
                                        Item item = copiaRetorno.Pop();

                                        // Adiciona o item devolvido à lista temporária
                                        itensDevolvidos.Add(item);

                                        // Adiciona o item devolvido à coleção original do tipo_item
                                        e.Tipo_item.Itens.Add(item);
                                    }

                                    // Atualiza a pilha Retorno com os itens não devolvidos
                                    foreach (Item itemNaoDevolvido in e.Retorno)
                                    {
                                        e.Retorno.Push(itemNaoDevolvido);
                                    }

                                    // Limpa a pilha original
                                    e.Retorno.Clear();

                                    // Pode imprimir a quantidade de itens devolvidos
                                    Console.WriteLine(itensDevolvidos.Count);
                                }
                            }
                        }
                    }
                }
            }

            return retorno;
        }

        public string consultaContratoLiberado()
        {
            string retorno = string.Empty;
            int counter = 0;

            foreach (Contrato c in Contratos)
            {
                if (c.Liberado)
                {
                    retorno += "------------------------------------------------\n";
                    retorno += "Contrato " + c.Id + "\n";
                    retorno += "    Saída:" + c.AgendamentoSaida.ToShortDateString() + "\n";
                    retorno += "    Retorno:" + c.AgendamentoRetorno.ToShortDateString() + "\n";
                    retorno += "    Itens: \n";

                    foreach (Itens_contrato i in c.ListaContrato)
                    {
                        retorno += "        " + i.ItemContrato.Nome + " - Quantidade: " + i.Qtd + "\n";
                    }
                    retorno += "------------------------------------------------\n";
                    counter++;
                }
            }
            if (counter == 0)
            {
                retorno = "Não há contratos liberados!";
            }

            return retorno;
        }

        public string realizaDevolucao(int id, int resposta, int indice1, int indice2)
        {
            string retorno = string.Empty;
            Contrato contrato = null;
            List<Item> lista = new List<Item>();
            Estoque estoque = null;

            foreach (Contrato c in contratos)
            {
                if (c.Id == id) { contrato = c; }
            }

            if (resposta == 1)
            {
                if (contrato != null)
                {
                    contrato.ListaContrato[indice1].ItemContrato.Itens[indice2].Avaria = true;

                    // Remover item avariado da lista
                    contrato.ListaContrato[indice1].ItemContrato.Itens.RemoveAt(indice2);
                }
            }
            else
            {
                if (contrato != null)
                {
                    foreach (Itens_contrato t in contrato.ListaContrato)
                    {
                        foreach (Estoque e in estoques)
                        {
                            if (t.ItemContrato.Id == e.Id)
                            {
                                for (int i = 0; i < t.ItemContrato.Itens.Count; i++)
                                {
                                    // Colocando Retorno em estoque
                                    estoque = new Estoque(e.Id, e.Tipo_item);
                                    foreach (Item y in e.Retorno)
                                    {
                                        estoque.Retorno.Push(y);
                                    }

                                    // Fim

                                    // Preenchendo a Lista
                                    for (int j = 0; j < e.Retorno.Count; j++)
                                    {
                                        if (t.ItemContrato.Itens[i] == estoque.Retorno.Peek())
                                        {
                                            lista.Add(estoque.Retorno.Pop());
                                        }
                                        else
                                        {
                                            estoque.Retorno.Pop();
                                        }
                                    }
                                }
                            }

                            estoque = new Estoque(e.Id, e.Tipo_item);
                            foreach (Item i in e.Retorno)
                            {
                                estoque.Retorno.Push(i);
                            }

                            e.Retorno.Clear();

                            for (int x = lista.Count - 1; x >= 0; x--)
                            {
                                Console.WriteLine("Valor da lista: " + lista[x].Nome + " - Indice: " + x);

                                if (lista[x] != estoque.Retorno.Peek())
                                {
                                    e.Retorno.Push(lista[x]);
                                }
                                else
                                {
                                    e.Tipo_item.Itens.Add(lista[x]);
                                }
                            }
                        }
                    }
                }
            }

            return retorno;
        }

        public string devolveItens(int id)
        {
            double valorTotal = 0;
            string retorno = "Não foi possível realizar a devolução.";

            foreach (Contrato c in contratos)
            {
                if (id == c.Id && c.Liberado)
                {
                    foreach (Itens_contrato i in c.ListaContrato)
                    {
                        Tipo_item tipoItem = achaTipoItem(i.ItemContrato.Id);

                        if (tipoItem.Id != -1)
                        {
                            foreach (Item itemContrato in tipoItem.Itens)
                            {
                                if (i.ItemContrato.Itens.Contains(itemContrato))
                                {
                                    // Verifica se o item foi avariado
                                    if (itemContrato.Avaria)
                                    {
                                        valorTotal += 0;  // Item avariado não contribui para o valor total
                                    }
                                    else
                                    {
                                        valorTotal += itemContrato.VlrDiario;
                                    }
                                }
                            }
                        }
                    }

                    retorno = $"Itens devolvidos com sucesso!\nO valor total é de: {valorTotal * (c.AgendamentoRetorno - c.AgendamentoSaida).Days}";
                    break;
                }
            }

            return retorno;
        }

    }
}
