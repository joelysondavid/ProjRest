using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Pedido
    {
        public int? Id { get; set; }
        public string NumMesa { get; set; }
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public decimal ValorTotal { get; set; }
        // itens de pedidos
        public IList<ItemPedido> ItensDePedido { get; set; }

        public Pedido()
        {
            this.Id = null;
            this.ItensDePedido = new List<ItemPedido>();
        }

        // TALVES NÃO USAREMOS ESTES MÉTODOS POIS ESTAREMOS TRABALHANDO DIRETAMENTE COM O BANCo
        // método para remover um único item da lista de itens
        public void RemoveItem(ItemPedido item)
        {
            this.ItensDePedido.Remove(item);
        }
        // método para remover todos os itens
        public void RemoverTodos()
        {
            this.ItensDePedido.Clear();
        }

        // método auxiliar para somar valor total
        public decimal CalcValorTotal()
        {
            decimal valorTotal = 0;
            foreach(var item in ItensDePedido)
            {
                // o valortotal será a soma de todos os itens
                ValorTotal = item.ValorItens * item.Quantidade; // que é o valor do item x a quantidade comprada
            }
            return valorTotal;
        }
    }
}
