using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt0402
{
    class DadosBancarios
    {
        public string Conta { get; set; }
        public double Saldo { get; set; }
        public int Senha { get; set; }

    }
    class Funcionario : DadosBancarios
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
    }
    class Empresa : DadosBancarios
    {
        public List<Funcionario> Funcionarios { get; set; }
    }
}
