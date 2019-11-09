using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Item
    {
        public int? Id { get; set; }
        public string Descricao { get; set; }
        public string Detalhes { get; set; }
        public int TempoPreparo { get; set; }
        public decimal Preco { get; set; }
        public string URLImagem { get; set; }

        // contrutor recebendo nulo
        public Item()
        {
            this.Id = null;
        }
    }
}
