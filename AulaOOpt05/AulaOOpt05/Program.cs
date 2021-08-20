using System;
using System.Collections.Generic;
using System.Linq;

namespace AulaOOpt05
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec01

            //Empresa corp = new Empresa();
            //Console.WriteLine("preencha a empresa");
            //corp.Nome = CR();
            //Console.WriteLine("idade");
            //corp.Idade = CRI();
            //Console.WriteLine("saldo");
            //corp.Saldo = CRD();
            //Console.WriteLine("funcionarios");
            //corp.QtdFuncionarios = CRI();
            //Console.WriteLine("cnpj");
            //corp.Cnpj = CR();
            //Console.WriteLine("rua");
            //corp.Rua = CR();
            //Console.WriteLine("cep");
            //corp.Cep = CR();
            //Console.WriteLine("cidade");
            //corp.Cidade = CR();
            //Console.WriteLine("estado");
            //corp.Estado = CR();
            //Console.WriteLine("pais");
            //corp.Pais = CR();

            //if (corp.QtdFuncionarios > 8)
            //{
            //    Console.WriteLine("{0} {1} {2}", corp.Nome, corp.Idade, corp.Cnpj);
            //    Console.WriteLine("{0} {1}", corp.Saldo, corp.QtdFuncionarios);
            //    Console.WriteLine("{0} {1} {2}", corp.Rua, corp.Cep, corp.Cidade);
            //    Console.WriteLine("{0} {1}", corp.Estado, corp.Pais);
            //}
            //else
            //{
            //    Console.WriteLine("microempresa");
            //}

            //exec01 carro

            //List<Carro> carros = new List<Carro>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Carro car = new Carro();

            //    Console.WriteLine("modelo");
            //    car.Carro1 = CR();
            //    Console.WriteLine("cavalos vapor");
            //    car.CV = CRI();
            //    Console.WriteLine("Nome da pessoa");
            //    car.Nome = CR();
            //    Console.WriteLine("Idade");
            //    car.Idade = CRI();
            //    Console.WriteLine("Cidade");
            //    car.Cidade = CR();
            //    Console.WriteLine("Estado");
            //    car.Estado = CR();
            //    carros.Add(car);
            //}
            //MelhorCarro(carros);

            //foreach (var item in carros)
            //{
            //    Console.WriteLine(item.Carro1);
            //    Console.WriteLine(item.CV);
            //    Console.WriteLine();
            //}

            //exec02

            //List<Funcionario> funcionarios = new List<Funcionario>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Funcionario estagiario = new Funcionario();
            //    Console.WriteLine("Informações pessoais");
            //    Console.Write("nome:");
            //    estagiario.Nome = CR();
            //    Console.Write("cargo: ");
            //    estagiario.Cargo = CR();
            //    Console.Write("salario: ");
            //    estagiario.Salario = Convert.ToDouble(CR());
            //    funcionarios.Add(estagiario);
            //}
            //Funci(funcionarios);

            //foreach (var item in funcionarios)
            //{
            //    if(item.Salario >= 1800)
            //    {
            //        Console.WriteLine(item.Nome);
            //        Console.WriteLine();
            //    }
            //    else if (item.Salario <= 1800)
            //    {
            //        Console.WriteLine(item.Nome);
            //        Console.WriteLine();
            //    }
            //}

            //exec03

            //while (true)
            //{
            //    Mae matriarca = new Mae();
            //    Console.WriteLine("Digite o nome da mãe");
            //    matriarca.Nome = CR();
            //    Console.WriteLine("Digite o nome do conjuge");
            //    matriarca.Conjuge = CR();
            //    Console.WriteLine("digite a quantidade de filhos");
            //    matriarca.Filhos = CRI();
            //    Console.WriteLine("A mãe {0} cujo informação do conjuge é {1} tem {2} filhos.", matriarca.Nome, matriarca.Conjuge, matriarca.Filhos);
            //    Console.WriteLine("Deseja alterar alguma coisa? 1 para nome da mãe, 2 para conjuge, 3 para filhos ou 4 pra sair ");
            //    int escolha = int.Parse(Console.ReadLine());
            //    if (escolha == 1)
            //    {
            //        Console.WriteLine("Digite o nome da mãe");
            //        matriarca.Nome = CR();
            //        Console.WriteLine("A mãe {0} cujo informação do conjuge é {1} tem {2} filhos.", matriarca.Nome, matriarca.Conjuge, matriarca.Filhos);
            //        break;
            //    }
            //    else if (escolha == 2)
            //    {
            //        Console.WriteLine("Digite o nome do conjuge");
            //        matriarca.Conjuge = CR();
            //        Console.WriteLine("A mãe {0} cujo informação do conjuge é {1} tem {2} filhos.", matriarca.Nome, matriarca.Conjuge, matriarca.Filhos);
            //        break;
            //    }
            //    else if (escolha == 3)
            //    {
            //        Console.WriteLine("digite a quantidade de filhos");
            //        matriarca.Filhos = CRI();
            //        Console.WriteLine("A mãe {0} cujo informação do conjuge é {1} tem {2} filhos.", matriarca.Nome, matriarca.Conjuge, matriarca.Filhos);
            //        break;
            //    }
            //    else if (escolha == 4)
            //    {
            //        break;
            //    }
            //}

            //OOpt502

            //exec01

            //List<Casa> casas = new List<Casa>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Casa domicilio = new Casa();
            //    Console.WriteLine("Digite ");
            //}


            //desafio

            //1a
            //Ciclista biker = new Ciclista();
            //Console.WriteLine("Preencha o nome do ciclista");
            //biker.Nome = CR();
            //Console.WriteLine("preencha a distancia a ser percorrida");
            //biker.distanciaASerPercorrida = CRD();
            //Console.WriteLine("e a velocidade: ");
            //biker.Velocidade = CRD();


            //double resultado = biker.distanciaASerPercorrida / biker.Velocidade;

            //Console.WriteLine("O tempo será de:");
            //Console.WriteLine("{0:#.##} segundos",resultado);

            //1b
            //Random ran = new Random();
            //Ciclista biker = new Ciclista();
            //Console.WriteLine("Preencha o nome do ciclista");
            //biker.Nome = CR();
            //Console.WriteLine("preencha a distancia a ser percorrida");
            //biker.distanciaASerPercorrida = ran.Next(500, 2000 + 1);
            //Console.WriteLine("e a velocidade: ");
            //biker.Velocidade = ran.Next(13, 25 + 1);
            //Console.WriteLine("{0}  {1}",biker.distanciaASerPercorrida,biker.Velocidade);

            //double resultado = biker.distanciaASerPercorrida / biker.Velocidade;

            //Console.WriteLine("O tempo será de:");
            //Console.WriteLine("{0:#.##} segundos", resultado);

            //1c
            //Console.WriteLine("preencha a distancia a ser percorrida");
            //double dist = CRD();
            ////biker.distanciaASerPercorrida = CRD();
            //List<Ciclista> bikerr = new List<Ciclista>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Preencha o nome do ciclista");
            //    Ciclista biker = new Ciclista();
            //    biker.Nome = CR();
            //    Console.WriteLine("e a velocidade: ");
            //    biker.Velocidade = CRD();
            //    bikerr.Add(biker);
            //}
            //Ciclistas(bikerr);

            //foreach (var item in bikerr)
            //{
            //    Console.WriteLine("{0} {1:#:##}",item.Nome, item.distanciaASerPercorrida/item.Velocidade);
            //}
        }
        public static void PreencheFuncionario(List<Funcionario> funcionarios)
        {
            while (true)
            {
                try
                {
                    Funcionario estagiario = new Funcionario();
                    Console.WriteLine("Informações pessoais");
                    Console.Write("nome:");
                    estagiario.Nome = CR();
                    Console.Write("cargo: ");
                    estagiario.Cargo = CR();
                    Console.Write("salario: ");
                    estagiario.Salario = Convert.ToDouble(CR());
                    funcionarios.Add(estagiario);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("erro inesperado");
                }

            }
        }
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CRI()
        {
            return int.Parse(Console.ReadLine());
        }
        public static double CRD()
        {
            return double.Parse(Console.ReadLine());
        }
        public static void MelhorCarro(List<Carro> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (list[j - 1].CV < list[j].CV)
                    {
                        var a = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = a;
                    }
                }
            }
        }
        public static void Funci(List<Funcionario> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (list[j - 1].Salario < list[j].Salario)
                    {
                        var a = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = a;
                    }
                }
            }
        }
        public static void Ciclistas(List<Ciclista> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    double x = list[j].distanciaASerPercorrida / list[j].Velocidade;
                    double y = list[j-1].distanciaASerPercorrida / list[j-1].Velocidade;
                    if (y> x)
                    {
                        Ciclista biker = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = biker;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
