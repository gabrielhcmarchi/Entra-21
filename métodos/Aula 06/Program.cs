using System;
using System.Collections;
using System.Collections.Generic;

namespace Aula_06
{
    class Program
    {
        static void Main(string[] args)
        {

            //-----------------------------------------------Lista01---------------------------------------------//

            //    //exec1

            //    int a, b,res;

            //    Program prog = new Program();

            //    Console.WriteLine("num1 e num2");
            //    a = int.Parse(Console.ReadLine());
            //    b = int.Parse(Console.ReadLine());

            //    res = prog.Calc(a, b);
            //    Console.WriteLine(res);

            //}


            //---------------------------------------------------------------------------------------------------//

            //exec2

            //Program prog = new Program();
            //Console.WriteLine("insira um numero");
            //int x = prog.CRI();
            //x = prog.ParOuImpar(x);
            //Console.WriteLine(x);

            //---------------------------------------------------------------------------------------------------//

            //exec3

            //int valor = 0;
            //Program check = new Program();
            //Console.WriteLine("Insira valor para checagem");
            //int x = prog.CRI();
            //x = prog.PosOuNeg(x, valor);
            //Console.WriteLine(x);

            //---------------------------------------------------------------------------------------------------//

            //exec4

            //Program conv = new Program();
            //double c;
            //Console.WriteLine("Digite o valor a ser convertido de celsius para Fahrenheit");
            //c = prog.CRD();
            //c = prog.Converte(c);
            //Console.WriteLine(c);

            //---------------------------------------------------------------------------------------------------//

            //exec5

            //double valor1, valor2, valor3;
            //string decision;
            //Program CalculoMedia = new Program();
            //Console.WriteLine("Insira três notas: ");
            //valor1 = CalculoMedia.CRD();
            //valor2 = CalculoMedia.CRD();
            //valor3 = CalculoMedia.CRD();
            //Console.WriteLine("Insira A para média aritmética, P para ponderada ou M para mediana");
            //decision = Console.ReadLine();
            //double resultado = CalculoMedia.Media(valor1, valor2, valor3, decision);
            //Console.WriteLine(resultado);

            //---------------------------------------------------------------------------------------------------//

            //exec6

            //double valor1, valor2, valor3,valor4,valor5;

            //Program CalcCinco = new Program();
            //Console.WriteLine("Insira cinco valores: ");
            //valor1 = CalcCinco.CRD();
            //valor2 = CalcCinco.CRD();
            //valor3 = CalcCinco.CRD();
            //valor4 = CalcCinco.CRD();
            //valor5 = CalcCinco.CRD();
            //double resultado = CalcCinco.FuncCinco(valor1, valor2, valor3, valor4, valor5);
            //Console.WriteLine(resultado);

            //---------------------------------------------------------------------------------------------------//

            //exec7

            //Program prog = new Program();
            //double a, b;
            //Console.WriteLine("Insira catetos para o calculo da hipotenusa");
            //a = prog.CRD();
            //b = prog.CRD();
            //Console.WriteLine(prog.Hipotenusa(a, b));

            //---------------------------------------------------------------------------------------------------//

            //exec8

            //int inicial = 0; int final = 0;

            //Program prog = new Program();
            //Console.WriteLine("Insira número incial");
            //inicial = prog.CRI();
            //Console.WriteLine("Insira número final: ");
            //final = prog.CRI();
            //prog.MaiorMenor(inicial, final);



            //---------------------------------------------------------------------------------------------------//

            //----------------------------------------Lista02----------------------------------------------------//


            //exec1

            //Program prog = new Program();
            //double[] vet = new double[4];
            //double res;

            //Console.WriteLine("Insira 4 valores, retornarei o maior entre eles");

            //vet[0] = prog.CRD();
            //vet[1]= prog.CRD();
            //vet[2]= prog.CRD();
            //vet[3] = prog.CRD();
            //res = prog.Comparador(vet);

            //Console.WriteLine(res+" é o maior valor");

            //---------------------------------------------------------------------------------------------------//

            //exec2

            //int escolha;
            //Program prog = new Program();
            //int[] armazena = new int[10];
            //Random rnd = new Random();

            //for (int i = 0; i < armazena.Length; i++)
            //{
            //    armazena[i] = rnd.Next(0, 9 + 1);
            //    Console.Write(armazena[i] + " ");
            //}
            //Console.WriteLine("\n\n");
            //Console.WriteLine("Escolha um número do vetor de 1 a 10");
            //escolha = prog.CRI();
            //escolha--;
            //int res = prog.Escolha(armazena,escolha);
            //Console.WriteLine(res);

            //---------------------------------------------------------------------------------------------------//

            //exec3

            //Program prog = new Program();
            //int[] vet2 = new int[10];
            //Console.WriteLine("Insira 10 valores: ");
            //for (int i = 0; i < vet2.Length; i++)
            //{
            //    vet2[i] = prog.CRI();

            //}

            //prog.Decrescente(vet2);

            //---------------------------------------------------------------------------------------------------//

            //exec4

            //Program prog = new Program();
            //Console.WriteLine("Insira dois números: ");
            //int x = prog.CRI();
            //int y = prog.CRI();
            //Console.WriteLine("Insira + para somar os dois valores, ou - para diminuir");
            //string escolha = prog.CR();
            //int resultado = prog.MiniCalc(x, y, escolha);
            //Console.WriteLine(resultado);

            //---------------------------------------------------------------------------------------------------//

        }

        ////------------------------------------------Lista01----------------------------------------------------//

        public int Compara(int x, int y)
        {
            if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        public int ParOuImpar(int entrada)
        {
            if (entrada % 2 == 0)

            {
                return 1;
            }

            else
            {
                return 0;
            }
        }
        public string CR()
        {
            return Console.ReadLine();
        }
        public int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public double CRD()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public int PosOuNeg(int x, int valor)
        {
            if (x > valor)
            {
                return 1;
            }
            else if (x < valor)
            {
                return -1;
            }
            else if (x == valor)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }
        public double Converte(double C)
        {
            C = (C * 9 / 5) + 32;
            return C;
        }
        public double Hipotenusa(double A, double B)
        {
            double C;
            C = Math.Pow(A, 2) + Math.Pow(B, 2);
            C = Math.Sqrt(C);
            return C;
        }
        public double Media(double valor1, double valor2, double valor3, string Decisao)
        {
            double resultado = 0;

            switch (Decisao)
            {
                case "A":
                case "a":
                    resultado = (valor1 + valor2 + valor3) / 3;
                    break;

                case "P":
                case "p":
                    resultado = (valor1 * 5 + valor2 * 3 + valor3 * 2) / 5 + 3 + 2;
                    break;

                case "M":
                case "m":
                    double[] notas = new double[3];
                    notas[0] = valor1;
                    notas[1] = valor2;
                    notas[2] = valor3;
                    Array.Sort(notas);
                    resultado = notas[1];
                    return resultado;
                default:
                    return -1;
            }
            return resultado;
        }
        public double FuncCinco(double a, double b, double c, double d, double e)
        {
            double resultado = 0;

            resultado = (a + b + c) / (d * e);

            return resultado;
        }
        public void MaiorMenor(int inicial, int final)
        {
            List<int> Lista = new List<int>();
            for (int i = inicial; i <= final; i++)
            {
                Lista.Add(i);
            }
            foreach (var p in Lista)
            {

                Console.WriteLine(p);
            }
        }

        //---------------------------------------------------------------------------------------------------//

        //--------------------------------------------Lista02------------------------------------------------//
        public double Comparador(double[] vet)
        {

            if (vet[0] > vet[1])
            {
                return Math.Max(vet[0], vet[1]);
            }
            else if (vet[1] > vet[2])
            {
                return Math.Max(vet[1], vet[2]);
            }
            else
            {
                return Math.Max(vet[2], vet[3]);
            }

        }//exec1
        public int Escolha(int [] vetor, int n)
        {
            return vetor[n];
        }//exec2
        public int MiniCalc(int x, int y, string decisao)
        {

            switch (decisao)
            {
                case "+":
                    return x + y;

                case "-":
                    return x - y;

                default:
                    return -1;
            }

        } //exec4
        public void Decrescente(int[] vet2)
        {
            Array.Sort(vet2);
            Array.Reverse(vet2);

            foreach (var b in vet2)
            {
                Console.WriteLine(b);
            }

        }//exec3
        public string Login(string[] logins, string[] senhas, string login, string senha)
        {
            for (int i = 0; i < logins.Length; i++)
            {
                if (logins[i] == login && senhas[i] == senha)
                {
                    return "Login efetuado com sucesso.";
                }
                
            }
            return "login errado.";
        }

        //---------------------------------------------------------------------------------------------------//

        //----------------------------------------Lista05----------------------------------------------------//

        //---------------------------------------------------------------------------------------------------//

    }
}







