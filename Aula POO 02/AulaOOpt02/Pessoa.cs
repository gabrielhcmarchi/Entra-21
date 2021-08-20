using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt02
{
    class Pessoa
    {
        public string nome, cpf, endereco;
        public int idade;

        public Pessoa(string nome, string cpf, string endereco, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.idade = idade;
        }
    }
}
