﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPolimorfismoPt2
{
    class Imovel
    {
        public string Endereco { get; set; }
        public double Preco { get; set; }
        public virtual void Calcula()
        {

        }
    }
}
