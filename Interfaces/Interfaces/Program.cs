using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> person = new List<Pessoa>();
            while (true)
            {
                Console.WriteLine("Insira uma pessoa ou enter pra encerrar:  ");
                Pessoa pes = new Pessoa();
                pes.Nome = Console.ReadLine();
                if (pes.Nome == "")
                {
                    Console.WriteLine("grato, volte sempre");
                    break;
                }
                pes.Idade = int.Parse(Console.ReadLine());
                pes.Cpf = Console.ReadLine();
                bool insere = true;
                foreach (var item in person)
                {
                    if (item.Cpf == pes.Cpf)
                    {
                        insere = false;
                        break;
                    }
                }
                if (insere)
                {
                    Console.WriteLine("pessoa adicionada ");
                    person.Add(pes);
                }
                else
                {
                    Console.WriteLine("cpf já existente, pessoa nao adicionada");
                }
                MostraPessoa(person);
            }
        }
        public static void MostraPessoa(List<Pessoa> p)
        {
            foreach (var item in p)
            {
                Console.WriteLine("Nome: {0}", item.Nome);
                Console.WriteLine("Idade: {0}", item.Idade);
                Console.WriteLine("CPF: {0}", item.Cpf);
            }
        }
    }
}
