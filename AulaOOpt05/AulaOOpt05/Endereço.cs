using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt05
{
    class Endereco
    {
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

    }
    class Dados : Endereco
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Rg { get; set; }
    }
    class Empresa : Dados
    {
        public double Saldo { get; set; }
        public int QtdFuncionarios { get; set; }

    }
    class Carro : Empresa
    {
        public List<Carro> Carros { get; set; }
        public string Carro1 { get; set; }
        public int CV;
        public string Modelo { get; set; }

    }
    class Pessoa : Endereco
    {
        public string Nome;
        public int Idade;
        public string Cpf;
    }
    class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
    }
    class Mae : Pessoa
    {
        public string Conjuge { get; set; }
        public int Filhos { get; set; }
    }
    class Imovel : Endereco
    {
        public string DataConstrucao { get; set; }
    }
    class Casa : Imovel
    {
        public int Quartos { get; set; }
        public List<Casa> casas { get; set; }
    }
    class Ciclista
    {
        public string Nome { get; set; }
        public double distanciaASerPercorrida { get; set; }
        public double Velocidade { get; set; }
    }

}
