﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPolimorfismo
{
    class Assistente : Funcionario
    {
        public int NumeroMatricula { get; set; }
        public override void ExibeDados()
        {
            base.ExibeDados();
            Console.WriteLine(NumeroMatricula);
        }
    }
}
