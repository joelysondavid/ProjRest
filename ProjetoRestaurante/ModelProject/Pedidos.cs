using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    class Pedidos
    {
        public int? Id { get; set; }
        public string NumMesa { get; set; }
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public decimal ValorTotal { get; set; }
        // itens de pedidos
        public IList<ItensPedido> ItensDePedido { get; set; }

        public Pedidos()
        {
            this.Id = null;
            this.ItensDePedido = new List<ItensPedido>();
        }

        // TALVES NÃO USAREMOS ESTES MÉTODOS POIS ESTAREMOS TRABALHANDO DIRETAMENTE COM O BANCo
        // método para remover um único item da lista de itens
        public void RemoveItem(ItensPedido item)
        {
            this.ItensDePedido.Remove(item);
        }
        // método para remover todos os itens
        public void RemoverTodos()
        {
            this.ItensDePedido.Clear();
        }
    }
}
