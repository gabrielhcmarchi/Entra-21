using System;
using System.Linq;

namespace aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista 00----------------------------------------------------------------------------------------- completa
            //exercicio 1

            //int[][] matriz = new int[4][];//gera matriz 4 linhas

            //for (int i = 0; i < matriz.Length; i++)//percorre todas as linhas
            //{
            //    matriz[i] = new int[4];//gera colunas
            //}
            //for (int i = 0; i < matriz.Length; i++)//percorre todas as inhas
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)//percorre todas as colunas
            //    {
            //        Console.WriteLine("Insira o elemento ->" + i + " " + j);
            //        matriz[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //int cont = 0;
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if(matriz[i][j] > 10)
            //        {
            //            cont++;
            //        }
            //        Console.Write(matriz[i][j] + " " );
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(cont);

            //exec 02

            //int x = 5, y = 5;
            //int[,] diagonal = new int[x, y]; /////////declarando de uma vez uma matriz 5x5
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (i == j)
            //        {
            //            diagonal[i, j] = 1;
            //        }
            //        else
            //        {
            //            diagonal[i, j] = 0;
            //        }
            //    }

            //}
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; i < y; i++)
            //    {
            //        Console.WriteLine(diagonal[i, j] + " ");
            //        Console.WriteLine();
            //    }
            //}

            //exec03

            //int[][] matriz = new int[4][];

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = i * j;
            //        Console.Write(matriz[i][j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //extra copia de matriz
            //int[][] matrizCopia = matriz;


            //exec04


            //bool encontra = false;
            //int[][] matriz = new int[2][];
            //int x;

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[2];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira o elemento ->" + i + " " + j);
            //        matriz[i][j] = int.Parse(Console.ReadLine());

            //    }


            //}
            //Console.WriteLine("Insira o elemento a ser encontrado: ");
            //x = int.Parse(Console.ReadLine());
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {


            //        if(matriz[i][j] == x)
            //        {
            //            encontra = true;
            //            Console.WriteLine("Numero encontrado: " + x + "na posição: " +i + " "+ j );
            //            break;
            //        }


            //    }
            //}
            //if (encontra == false)
            //{
            //    Console.WriteLine("Nada encontrado");
            //}

            //exec05



            //int[][] matriz = new int[2][];
            //int[][] matriz2 = new int[2][];
            //int[][] matriz3 = new int[2][];

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[2];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz2[i] = new int[2];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz3[i] = new int[2];
            //}
            //for (int i = 0; i < matriz.Length; i++)

            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira o elemento ->" + i + " " + j);
            //        matriz[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < matriz2.Length; i++)
            //{
            //    for (int j = 0; j < matriz2[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira o elemento ->" + i + " " + j);
            //        matriz2[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < matriz3.Length; i++)
            //{
            //    for (int j = 0; j < matriz3[i].Length; j++)
            //    {
            //        if (matriz[i][j] > matriz2[i][j])
            //        {
            //            matriz3[i][j] = matriz[i][j];
            //        }
            //        else if (matriz2[i][j] > matriz[i][j])
            //        {
            //            matriz3[i][j] = matriz2[i][j];
            //        }
            //        Console.WriteLine("Numeros da terceira matriz: " + i + " " + j + " " + matriz3[i][j]);
            //    }

            //}

            //exec6

            //Random ran = new Random();
            //int[][] matriz = new int[10][];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[10];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{

            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = ran.Next(0, 10);
            //        if (i < j)
            //        {
            //            matriz[i][j] = 2 * i + 7 * j - 2;
            //            Console.Write(matriz[i][j] + " ");
            //        }
            //        if (i == j)
            //        {
            //            matriz[i][j] = 3 * i - 1;
            //            Console.Write(matriz[i][j] + " ");
            //        }
            //        if (i > j)
            //        {
            //            matriz[i][j] = 4 * i - 5 * j + 1;
            //            Console.Write(matriz[i][j] + " ");
            //        }

            //    }
            //}
            //Console.WriteLine();


            // exec7

            //int[][] matriz = new int[3][];
            //int[][] som = new int[3][];
            //int soma = 0;

            //for (int i = 0; i < som.Length; i++)
            //{
            //    som[i] = new int[3];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[3];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira o elemento ->" + i + " " + j);
            //        matriz[i][j] = int.Parse(Console.ReadLine());
            //        if (j > i)
            //        {
            //            som[i][j] = matriz[i][j];
            //            soma += som[i][j];
            //        }
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(som[i][j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("A soma é igual a: {0}", soma, " ");

            //exec8

            //int[][] matriz = new int[3][];
            //int[][] som = new int[3][];
            //int soma = 0;

            //for (int i = 0; i < som.Length; i++)
            //{
            //    som[i] = new int[3];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[3];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira o elemento ->" + i + " " + j);
            //        matriz[i][j] = int.Parse(Console.ReadLine());
            //        if (j < i)
            //        {
            //            som[i][j] = matriz[i][j];
            //            soma += som[i][j];
            //        }
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(som[i][j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("A soma é igual a: {0}", soma, " ");

            //exec9

            //Random ran = new Random();
            //int[][] matriz = new int[4][];
            //int[][] matriz1 = new int[4][];

            //Console.WriteLine();
            //Console.WriteLine("Matriz normal: ------------------------");
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //    matriz1[i] = new int[4];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = ran.Next(1, 20);
            //        if (matriz[i][j] < 10)
            //        {
            //            Console.Write("0" + matriz[i][j] + " ");
            //        }
            //        else
            //        {
            //            Console.Write(matriz[i][j] + " ");
            //        }

            //        if (j <= i)
            //        {
            //            matriz1[i][j] = matriz[i][j];
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Matriz tranformada: ----------------");
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(matriz1[i][j] + " ");
            //    }
            //}
            //Console.WriteLine();


            //exec10 - FIM

            //    Random ran = new Random();
            //    bool flag = false;
            //    int calc = 0;
            //    int[] numeros = new int[25];

            //    Console.WriteLine();
            //    Console.WriteLine("Bingo: ------------------------");
            //    int[][] matriz = new int[5][];

            //    for (int posicao = 0; posicao < 25; posicao++)
            //    {
            //        while (true)
            //        {
            //            flag = false;
            //            calc = ran.Next(0, 100);
            //            for (int tentativa = 0; tentativa < 25; tentativa++)
            //            {
            //                if (calc == numeros[tentativa])
            //                {
            //                    flag = true;
            //                }
            //            }
            //            if (!flag)
            //            {
            //                break;
            //            }
            //        }
            //        if (!flag)
            //        {
            //            numeros[posicao] = calc;
            //            flag = false;
            //        }
            //    }

            //    for (int i = 0; i < matriz.Length; i++)
            //    {
            //        matriz[i] = new int[5];

            //    }
            //    int x = 0;
            //    for (int i = 0; i < matriz.Length; i++)
            //    {
            //        Console.WriteLine();

            //        for (int j = 0; j < matriz.Length; j++)
            //        {
            //            matriz[i][j] = numeros[x];
            //            x++;
            //            Console.Write(matriz[i][j] + " ");
            //        }
            //    }
            //}

            //lista 01 -----------------------------------------------------------------------------------


            //exec1

            //int[][] matriz = new int[3][];
            //int[] resultado = new int[3];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[3];
            //    resultado[i] = 0;
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[j][i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)//coluna
            //{

            //    for (int j = 0; j < matriz[i].Length; j++)//linha
            //    {
            //        resultado[i] += matriz[j][i];
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(matriz[i][j] + "  ");
            //    }
            //}
            //for (int i = 0; i < resultado.Length; i++)
            //{
            //    Console.WriteLine(resultado[i]);
            //}

            //exec2

            //int[][] matriz = new int[5][];

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length - 1; j++)
            //    {
            //        if (j == 0)
            //        {
            //            Console.WriteLine(" matricula" + (i + 1) + " alunos");
            //            matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //        else if (j == 1)
            //        {

            //            Console.WriteLine(" nota" + (i + 1) + " alunos");
            //            matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //        else
            //        {
            //            Console.WriteLine(" nota" + (i + 1) + " trabalhos");
            //            matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }
            //    // b)
            //    matriz[i][matriz[i].Length - 1] = matriz[i][1] + matriz[i][2];

            //}
            //Console.WriteLine("------------------------------------------");
            //// c)
            //int notaFinal = -1, valorNotaFinal = -1;
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    if (matriz[i][3] > valorNotaFinal)
            //    {
            //        valorNotaFinal = matriz[i][3];
            //        notaFinal = i;
            //    }
            //}
            //Console.WriteLine("aluno maior nota");
            //Console.WriteLine(matriz[notaFinal][0]);
            //Console.WriteLine("------------------------------------------");
            //int mediaFinal = 0;
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    mediaFinal += matriz[i][3];  
            //}
            //Console.WriteLine("Média final de todos os alunos é: ");
            //Console.WriteLine(mediaFinal / matriz.Length);




            //lista 02 -----------------------------------------------------------------------------------


            //exec1

            //int[][] matriz = new int[3][];

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[3];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{

            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = 4;
            //        Console.Write(matriz[i][j] + " ");
            //    }
            //}

            //exec2

            //int soma=0;
            //int[][] matriz = new int[2][];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira o elemento ->" + i + " " + j);
            //        matriz[i][j] = int.Parse(Console.ReadLine());
            //        soma += matriz[i][j];

            //    }
            //}
            //Console.WriteLine("A soma deu: " + soma + " ");
            //Console.ReadLine();

            //exec3

            //Random ran = new Random();
            //int[][] matriz1 = new int[2][];
            //int[][] matriz2 = new int[4][];
            //int calc = 0;

            //Console.WriteLine();
            //Console.WriteLine("Matriz norma1: ------------------------");
            //for (int i = 0; i < matriz1.Length; i++)
            //{
            //    matriz1[i] = new int[4];
            //}
            //for (int i = 0; i < matriz2.Length; i++)
            //{
            //    matriz2[i] = new int[2];
            //}
            //for (int i = 0; i < matriz1.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz1[i].Length; j++)
            //    {
            //        calc = ran.Next(0, 30);
            //        matriz1[i][j] = calc;
            //        Console.Write(matriz1[i][j] + " ");

            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Matriz 2: ------------------------");
            //for (int i = 0; i < matriz2.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz2[i].Length; j++)
            //    {
            //        matriz2[i][j] = matriz1[j][i];
            //        Console.Write(matriz2[i][j] + " ");
            //    }

            //}
            //Console.WriteLine();

            //exec4

            //int[][] matriz = new int[3][];//gera matriz 4 linhas
            //int[] vet = new int[6];
            //for (int i = 0; i < matriz.Length; i++)//percorre todas as linhas
            //{
            //    matriz[i] = new int[6];//gera colunas
            //}
            //for (int i = 0; i < matriz.Length; i++)//percorre todas as inhas
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)//percorre todas as colunas
            //    {
            //        Console.WriteLine("Insira o elemento ->" + i + " " + j);
            //        matriz[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(matriz[i][j] + " ");

            //        if (vet[j] < matriz[i][j])
            //        {
            //            vet[j] = matriz[i][j];
            //        }
            //    }
            //    Console.WriteLine();

            //}
            //for (int i = 0; i < vet.Length; i++)
            //{
            //    Console.WriteLine();
            //    Console.Write(" maires valores das colunas :"+ vet[i] + " ");
            //}


        }
    }
}