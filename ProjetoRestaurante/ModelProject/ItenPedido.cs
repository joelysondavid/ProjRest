using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    class ItenPedido
    {
        public int? Id { get; set; }
        public int PedidoId { get; set; }
        public int ItemId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorItens { get; set; }
        public string Status { get; set; }

        public ItenPedido()
        {
            this.Id = null;
        }
    }
}
