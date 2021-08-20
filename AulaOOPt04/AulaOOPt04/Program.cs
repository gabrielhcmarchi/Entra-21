using System;
using System.Collections.Generic;

namespace AulaOOPt04
{
    class Program
    {
        public static void Main(string[] args)
        {
            //exec01

            //Pessoa pes = new Pessoa();
            //Console.WriteLine("Insira o nome da pessoa");
            //pes.Nome = CR();
            //Console.WriteLine("Insira o Cpf da pessoa");
            //pes.Cpf = CR();
            //Console.WriteLine("Insira a idade");
            //pes.Idade = CRI();
            //Console.WriteLine("Insira a rua em que a pessoa mora");
            //pes.Rua = CR();
            //Console.WriteLine("Insira o número da casa");
            //pes.Numero = CR();
            //Console.WriteLine("Insira a cidade em que ela reside");
            //pes.Cidade = CR();
            //Console.WriteLine("Insira o estado em que ela vive");
            //pes.Estado = CR();
            //Console.Clear();
            //Console.WriteLine("----------//----------");
            //Console.WriteLine("{0} | {1} | {2} anos", pes.Nome, pes.Cpf, pes.Idade);
            //Console.WriteLine("{0} | nº{1} | {2} | {3}", pes.Rua, pes.Numero, pes.Cidade, pes.Estado);
            //Console.ReadLine();
            //Console.Clear();
            //Empresa company = new Empresa();
            //Console.WriteLine("Insira o nome da Empresa");
            //company.nome = CR();
            //Console.WriteLine("Insira a quantidade de funcionários");
            //company.funcionarios = CRI();
            //Console.WriteLine("----------//----------");
            //Console.WriteLine("{0} | {1} funcionários |", company.nome, company.funcionarios);
            //Console.ReadLine();
            //Console.Clear();

            //List<string> dados = new List<string>();
            //for (int i = 1; i <= 4; i++)
            //{
            //    Habitacao local = new Habitacao();
            //    Console.WriteLine("Insira o tipo da habitação");
            //    local.tipohabitacao = CR();
            //    dados.Add(local.tipohabitacao);
            //    Console.WriteLine("Insira o nome do dono desta habitação");
            //    local.nomeDono = CR();
            //    dados.Add(local.nomeDono);
            //    Console.WriteLine("Insira a rua em que a pessoa mora");
            //    local.Rua = CR();
            //    dados.Add(local.Rua);
            //    Console.WriteLine("Insira o número da casa");
            //    local.Numero = CR();
            //    dados.Add(local.Numero);
            //    Console.WriteLine("Insira a cidade em que ela reside");
            //    local.Cidade = CR();
            //    dados.Add(local.Cidade);
            //    Console.WriteLine("Insira o estado em que ela vive");
            //    local.Estado = CR();
            //    dados.Add(local.Estado);

            //    if (i == 4)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("tipos de habitação e seus donos:\n ");
            //        foreach (string hab in dados)
            //        {
            //            Console.Write(hab + " | ");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //exec02

            //int quilos = 0;
            //double horas = 0;
            //Pessoa2 fifa = new Pessoa2();
            //Console.WriteLine("insira o nome");
            //fifa.Nome = CR();
            //Console.WriteLine("insira a idade");
            //fifa.Idade = CRI();
            //Console.WriteLine("Insira quantidade de dopamina");
            //Pessoa2.Dopamina = CRI();
            //Console.WriteLine("Insira o dinheiro que você tem");
            //Pessoa2.Dinheiro = CRI();

            //Console.WriteLine("Deseja comer, ou trabalhar ?");
            //string escolha = CR();
            //if(escolha == "comer")
            //{
            //    Console.WriteLine("Quantos quilos você quer comer?(sim.)");
            //    quilos = CRI();
            //    Pessoa2.Comer2(quilos);
            //}
            //if(escolha == "trabalhar")
            //{
            //    Console.WriteLine("Quantas horas?");
            //    horas = Convert.ToDouble(Console.ReadLine());
            //    Pessoa2.Seila(horas);
            //}
            //Console.WriteLine("{0} | {1} anos | {2} | {3} |", fifa.Nome, fifa.Idade, Pessoa2.Dopamina, Pessoa2.Dinheiro);

            //exec03

            //List<Cachorro> cachorro = new List<Cachorro>();
            //for (int i = 0; i < 2; i++)
            //{
            //    Cachorro dog = new Cachorro();
            //    Console.WriteLine("Insira o nome do cachorro");
            //    dog.Nome = CR();
            //    Console.WriteLine("Insira a quantidade de dopamina dele");
            //    dog.Dopamina = CRI();
            //    Console.WriteLine("quantidade de conforto dele:");
            //    dog.Conforto = CRI();
            //    cachorro.Add(dog);
            //}
            //while (true)
            //{
            //    Console.WriteLine("1---     Descansar");
            //    Console.WriteLine("2---         Comer");
            //    Console.WriteLine("3---      Sair");
            //    char escolha = Convert.ToChar(Console.ReadLine());
            //    if (escolha == '1')
            //    {
            //        Console.WriteLine("Qual cachorro irá descansar?");
            //        for (int i = 0; i < cachorro.Count; i++)
            //        {
            //            Console.Write("ID dos cachorros: {0} ", i +1);
            //            Console.WriteLine(cachorro[i].Nome);
            //        }
            //        Console.WriteLine("Qual ID você deseja?");
            //        int aux = int.Parse(Console.ReadLine());
            //        aux--;
            //        Console.WriteLine("Quantas horas de descanso?");
            //        int horas = int.Parse(Console.ReadLine());
            //        cachorro[aux].Conforto += cachorro[aux].Descansar(horas);
            //        Console.WriteLine("quantidade de descanso e dopamina");
            //        foreach (var item in cachorro)
            //        {
            //            Console.WriteLine(item.Conforto);
            //        }
            //    }
            //    else if (escolha == '2')
            //    {
            //        Console.WriteLine("Qual cachorro irá comer?");
            //        for (int i = 0; i < cachorro.Count; i++)
            //        {
            //            Console.Write("ID dos cachorros: {0} ", i +1);
            //            Console.WriteLine(cachorro[i].Nome);
            //        }
            //        Console.WriteLine("Qual ID você deseja?");
            //        int aux = int.Parse(Console.ReadLine());
            //        aux--;
            //        Console.WriteLine("Quantos KG de comida?");
            //        int kg = int.Parse(Console.ReadLine());
            //        cachorro[aux].Comer += cachorro[aux].Comer2(kg);
            //        Console.WriteLine("quantidade de dopamina e descanso : ");
            //        foreach (var item in cachorro)
            //        {
            //            Console.WriteLine(item.Dopamina);
            //        }
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

        }
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CRI()
        {
            return int.Parse(Console.ReadLine());
        }

    }
}
