using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPolimorfismoPt2
{
    class Velho : Imovel
    {
        public double Desconto { get; set; }
        public override void Calcula()
        {
            Preco -= Desconto;
        }
    }
}
