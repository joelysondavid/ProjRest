using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Usuario
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string TipoUsr { get; set; }
        public Usuario()
        {
            this.Id = null;
        }

        // comparação de objetos
        protected bool Equals(Usuario other)
        {
            return Id.Equals(other.Id);
        }
        public override bool Equals(object obj)
        {
            // se a referencia do objeto for nula
            if (ReferenceEquals(null, obj)) return false;
            // se a referencia do obj for da propia classe
            if (ReferenceEquals(this, obj)) return true;
            // comprar o tipo do objeto com o tipo da classe
            if (obj.GetType() != typeof(Usuario)) return false;
            // chama o equalsque compara os id
            return Equals((Usuario)obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
