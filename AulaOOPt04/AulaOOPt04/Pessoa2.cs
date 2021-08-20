using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOPt04
{
    public class Pessoa2 : Comportamento
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public static int Dopamina { get; set; }
        public static double Dinheiro { get; set; }
        
        public static double Seila(double horas)
        {
            Dinheiro = horas * 24.52 + Dinheiro;
            return Dinheiro;
        }
    }
    class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
    public class Comportamento
    {
        public  int Comer { get; set; }
        public  int Descansar(int descanso)
        {
            descanso *= 100;
            return descanso;
        }
    }
    class Habitacao : Endereco
    {
        public string tipohabitacao { get; set; }
        public string nomeDono { get; set; }

    }
    class Empresa : Endereco
    {
        public string nome { get; set; }
        public int funcionarios { get; set; }

    }
    class Pessoa : Endereco
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
    }
    class Cachorro : Comportamento
    {
        public string Nome { get; set; }
        public int Dopamina { get; set; }
        public int Conforto { get; set; }
        public int Comer2(int quantia)
        {
            Dopamina = quantia * 250;
            return Dopamina;

        }

    }
     class Funcionario : Comportamento
    {
        public string Nome { get; set; }
        public static double Dinheiro { get; set; }
        public static double Trabalhar(double x)
        {
            Dinheiro = x / 24.52;
            Dinheiro = 62 - Dinheiro;
            return Dinheiro;
        }
    }
}
