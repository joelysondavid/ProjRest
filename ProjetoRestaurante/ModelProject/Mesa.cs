using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Mesa
    {
        public string NumMesa { get; set; }
        public string Descricao { get; set; }

        // sobrescrevendo método tostring
        public override string ToString()
        {
            return (NumMesa);
        }
    }
}
