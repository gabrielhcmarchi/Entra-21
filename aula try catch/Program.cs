using System;
using System.Collections.Generic;
using System.Linq;


namespace Aula08
{
    class Program
    {
        //tratamento de exceção
        static void Main(string[] args)
        {
            //lista 01 exercicio 2

            //int num = 0;

            ////apenas pra ficar repetindo
            //while (true)
            //{
            //    Console.WriteLine("digite um numero qualquer: ");

            //    try
            //    {
            //        num = int.Parse(Console.ReadLine());
            //        Console.WriteLine("deu certo.");
            //        break;
            //    }
            //    //testa pra numero grande
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Numero gigantesco");
            //    }
            //    //testa converção de formato
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Apenas numeros");
            //    }
            //    //testa generico
            //    catch (Exception)
            //    {
            //        Console.WriteLine("*erro*");
            //   }


            //exec03

            //double[] vetor = new double[3];
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Insira 3 notas");
            //        for (int i = 0; i < vetor.Length; i++)
            //        {
            //            vetor[i] = Convert.ToDouble(Console.ReadLine());
            //            if (vetor[i] > 10)
            //            {
            //                throw new OverflowException();
            //            }
            //            Console.ReadLine();
            //            break;
            //        }
            //        Console.WriteLine();
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("nota nao pdoe ser maior que 10");
            //    }
            //}

            //segundo método

            ////cria a lista
            //List<double> notas = new List<double>();
            ////Pede dados
            //double resultado1 = 0;
            //double nota = 0;
            //Console.WriteLine("insira 3 notas");
            //for (int i = 0; i < 3; i++)
            //{
            //    while (true)
            //    {
            //        try
            //        {
            //            nota = Convert.ToDouble(Console.ReadLine());
            //            if (nota > 10)
            //            {
            //                throw new OverflowException();   ///gerar func c CRD
            //            }
            //            else
            //            {
            //                notas.Add(nota);
            //                break;
            //            }
            //        }
            //        catch (FormatException) ///same
            //        {

            //            Console.WriteLine("apenas numeros");
            //        }
            //        catch (OverflowException)
            //        {
            //            Console.WriteLine("Numero mui grande");
            //        }
            //    }

            //    double resultado = 0;
            //    foreach (var item in notas)
            //    {
            //        resultado += item;
            //        resultado1 = resultado;
            //    }
            //}
            //Console.WriteLine("Média ► " + (resultado1 / 3));

            //exec4

            //int[] vetCompara = new int[5];
            //Console.WriteLine("Insira 5 valores: ");

            //for (int i = 0; i < vetCompara.Length; i++)
            //{

            //    while (true)
            //    {
            //        try
            //        {
            //            vetCompara[i] = Convert.ToInt32(Console.ReadLine());

            //            break;
            //        }
            //        catch (OverflowException)
            //        {
            //            Console.WriteLine("Numero mui grande");
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("apenas numeros");
            //        }
            //        catch (IndexOutOfRangeException)
            //        {
            //            Console.WriteLine("vetor ta cheio burro");
            //        }

            //    }

            //}
            //int maxValue = vetCompara.Max();
            //int minValue = vetCompara.Min();
            //Console.WriteLine("O maior número foi " + maxValue);
            //Console.WriteLine("O menor número foi " + minValue);


            //exec01 depura

            //Console.WriteLine("Insira um numero");
            //int x = CRI();
            //Console.WriteLine(Exec01(x));

            //exec02

            //Console.WriteLine("Começo do teste");
            //Exec02();

            //exec03

            //int a, b;
            //Console.WriteLine("Dois valores");
            //a = CRI();
            //b = CRI();
            //Console.WriteLine(Exec03(a,b));

            //exec04

            //Console.WriteLine("soma dos numeros caso o primeiro seja maior que o segundo");
            //int a, b;
            //a = CRI();
            //b = CRI();
            //Exec04(a,b);

            //exec05

            //List<double> original = new List<double>();
            //Console.WriteLine("dois valores teste");
            //double a = CRD();
            //original.Add(a);
            //double b = CRD();
            //original.Add(b);
            //Console.WriteLine(Exec05(original));

            //exec06

            //Console.WriteLine("numero");
            //int a = CRI();
            //Console.WriteLine(Exec06(a));

        }
        public static int Exec01(int numero)
        {
            if (numero > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public static void Exec02()
        {
            while (true)
            {
                Console.WriteLine("Insira um numero ou sair");
                string entrada = Console.ReadLine();
                if (entrada == "sair")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("entrada");
                }
            }
            
        }
        public static bool Exec03(int numero1, int numero2)
        {
            if (numero1 > numero2 || numero2 < numero1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Exec04(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                Console.WriteLine(numero1+numero2);
            }
            else
            {
                Console.WriteLine("não computável");
            }
        }
        public static double Exec05(List<double> lista)
        {
            double maior = lista.Max(x => x);
            //foreach (var item in lista)
            //{
            //    if (item > maior)
            //    {
            //        maior = item;
            //    }
            //}
            return maior;
        }
        public static int Exec06(int numero)
        {
            if (numero > 0 && numero <= 10)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double CRD()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}




