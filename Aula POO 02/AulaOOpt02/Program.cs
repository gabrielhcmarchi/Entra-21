using System;
using System.Collections.Generic;

namespace AulaOOpt02
{
    class Program
    {
        static void Main(string[] args)
        {
            ////exec01

            //Console.WriteLine("| ------------------------- |");
            //Console.WriteLine("|insira uma pessoa          |");
            //Console.WriteLine("|nome, cpf, endereço e idade|");
            //Console.WriteLine("| ------------------------- |");
            //string nome, cpf, endereco;
            //int idade;

            //nome = Console.ReadLine();
            //cpf = Console.ReadLine();
            //endereco = Console.ReadLine();
            //idade = int.Parse(Console.ReadLine());

            //Pessoa pes = new Pessoa(nome, cpf, endereco, idade);
            //Console.WriteLine();
            //Console.WriteLine("| -------------------- |");
            //Console.WriteLine("|"+pes.nome);
            //Console.WriteLine("| -------------------- |");
            //Console.WriteLine("|"+pes.cpf);
            //Console.WriteLine("| -------------------- |");
            //Console.WriteLine("|"+pes.endereco);
            //Console.WriteLine("| -------------------- |");
            //Console.WriteLine("|"+pes.idade);
            //Console.WriteLine("| -------------------- |");

            //exec02

            //List<Pessoas02> pessoas = new List<Pessoas02>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira uma pessoa");
            //    Console.WriteLine("nome, idade e genero");
            //    string nome = Console.ReadLine();
            //    int idade = int.Parse(Console.ReadLine());
            //    string genero = Console.ReadLine().ToLower();
            //    Pessoas02 pessoas1 = new Pessoas02(nome, idade, genero);
            //    pessoas.Add(pessoas1);
            //}
            //int indexHomem=-1, indexMulher= -1;
            //int idadeHomem =-1 , idadeMulher= -1;

            //for (int i = 0; i < pessoas.Count; i++)
            //{
            //    if(pessoas[i].genero == "m" && idadeMulher < pessoas[i].idade)
            //    {
            //        indexMulher = i;
            //        idadeMulher = pessoas[i].idade;
            //    }
            //    if (pessoas[i].genero == "h" && idadeHomem < pessoas[i].idade)
            //    {
            //        indexHomem = i;
            //        idadeHomem = pessoas[i].idade;
            //    }
            //}
            //Console.WriteLine("|---------------------|");
            //try
            //{
            //    Console.WriteLine("mulher idosa");
            //    Console.WriteLine(pessoas[indexMulher].nome);
            //    Console.WriteLine(pessoas[indexMulher].idade);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("nn tem mulhe");

            //}
            //Console.WriteLine("|---------------------|");
            //try
            //{
            //    Console.WriteLine("homem idoso");
            //    Console.WriteLine(pessoas[indexHomem].nome);
            //    Console.WriteLine(pessoas[indexHomem].idade);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("nn tem home");

            //}

            //exec03

            //List<Cachorros> dog = new List<Cachorros>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira dados do cachorro");
            //    Console.WriteLine("nome do cachorro, nome do dono e idade.");
            //    string nome = Console.ReadLine();
            //    string nomeDono = Console.ReadLine();
            //    int idade = int.Parse(Console.ReadLine());
            //    Cachorros dogs = new Cachorros(nome, nomeDono, idade);
            //    dog.Add(dogs);
            //}
            //for (int i = 0; i < dog.Count; i++)
            //{
            //    if(dog[i].idade > 4)
            //    {
            //        Console.WriteLine("dogs velhos: "+dog[i].nome + " ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Dogs novinhos: "+ dog[i].nome+ " ");
            //    }
            //}



        }
    }
}
