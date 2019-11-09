using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class ItemPedido
    {
        public int? Id { get; set; }
        public int PedidoId { get; set; }
        public int ItemId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorItens { get; set; }
        public string Status { get; set; }

        public ItemPedido()
        {
            this.Id = null;
        }
    }
}
