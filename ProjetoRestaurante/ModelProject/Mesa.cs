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

        // equals
        protected bool Equals(Mesa other)
        {
            return NumMesa.Equals(other.NumMesa);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Mesa)) return false;
            return Equals((Mesa)obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
