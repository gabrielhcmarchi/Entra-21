using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOPt0601
{
    class Vip : Ingresso
    {
        public double ValorAdicional { get; set; }
        public override void ImprimeValor()
        {
            Console.WriteLine(Valor + ValorAdicional);
        }

    }
}
