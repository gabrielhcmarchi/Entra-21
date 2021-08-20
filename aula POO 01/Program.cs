using System;
using System.Collections.Generic;
using System.Linq;

namespace AulaOOpt01
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exec 01
            //Pessoa pes = new Pessoa();
            //Console.WriteLine("Preencha esta pessoa");
            //pes.nome = Console.ReadLine();
            //pes.idade = int.Parse(Console.ReadLine());
            //pes.cpf = Console.ReadLine();
            //pes.endereco = Console.ReadLine();
            //Console.WriteLine("-----------//-------------");
            //Console.WriteLine(pes.nome);
            //Console.WriteLine(pes.idade);
            //Console.WriteLine(pes.cpf);
            //Console.WriteLine(pes.endereco);

            //Exec 02

            //List<Cachorro> doginhos = new List<Cachorro>();

            ////preenche a lista
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira o doginho");
            //    Cachorro cao = new Cachorro();
            //    cao.nome = Console.ReadLine();
            //    cao.nomeDoDono = Console.ReadLine();
            //    cao.idade = Convert.ToInt32(Console.ReadLine());
            //    doginhos.Add(cao);
            //}
            //Console.WriteLine("-----------//-----------");

            ////mostrar a lista, apenas cachorros velhos
            //foreach (var item in doginhos)
            //{
            //    if (item.idade > 6)
            //    {
            //        Console.WriteLine(item.nome);
            //        Console.WriteLine(item.nomeDoDono);
            //        Console.WriteLine(item.idade);
            //        Console.WriteLine("-----------//-----------");
            //    }
            //}
            //for (int i = 0; i < doginhos.Count; i++)
            //{
            //    if (doginhos[i].idade > 6)
            //    {
            //        Console.WriteLine(doginhos[i].nome);
            //        Console.WriteLine(doginhos[i].nomeDoDono);
            //        Console.WriteLine(doginhos[i].idade);
            //        Console.WriteLine("-----------//-----------");
            //    }
            //}

            //exec3

            List<Pessoas> pessoas = new List<Pessoas>();
            //sort do mais velho pro mais novo

            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine("Digite o nome:");
                Pessoas gente = new Pessoas();
                gente.nome = Console.ReadLine();
                Console.WriteLine("Digite a idade");
                gente.idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o gênero");
                gente.genero = Console.ReadLine();
                pessoas.Add(gente);
            }
            Console.WriteLine("----------");

            
    

        }
        public static int AchaMaiorIdade(List<Pessoas> lista)
        {
            if (lista.Count == 0)
            {
                throw new InvalidOperationException("Lista vazia");
            }
            int idadeMaxima = int.MinValue;
            foreach  (Pessoas idade in lista)
            {
                if(Pessoas.idade > idadeMaxima)
                {
                    idadeMaxima = Pessoas.idade;
                }
            }
            return idadeMaxima;
        }
    }
    
}

