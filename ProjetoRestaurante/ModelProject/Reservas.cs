﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    class Reservas
    {
        public int? Id { get; set; }
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public string NumMesa { get; set; }

        public Reservas()
        {
            this.Id = null;
        }
    }
}