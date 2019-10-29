using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    class Itens
    {
        public int? Id { get; set; }
        public string Descricao { get; set; }
        public string Detalhes { get; set; }
        public int TempoPreparo { get; set; }
        public decimal Preco { get; set; }
        public string URLImagem { get; set; }

        // contrutor recebendo nulo
        public Itens()
        {
            this.Id = null;
        }
    }
}
