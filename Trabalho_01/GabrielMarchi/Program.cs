using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielMarchi
{
    class Program
    {
   
        static void Main(string[] args)
        {
            int x = 6; int y = 6;
            int[,] estoqueUm = new int[x, y];
            int[,] estoqueDois = new int[x, y];
            int[,] estoqueTres = new int[x, y];
            int[,] estoqueQuatro = new int[x, y];

            //prenchimento de metade do estoque
            for (int i = 0; i < x; i++)  
            {
                for (int j = 0; j < y; j++)
                {
                    if (i < 3)
                    {
                        estoqueUm[i, j] = 1;
                        estoqueDois[i, j] = 2;
                        estoqueTres[i, j] = 3;
                        estoqueQuatro[i, j] = 4;
                    }
                }
            }
            ImprimeMatriz(estoqueUm, x, y);
            ImprimeMatriz(estoqueDois, x, y);
            ImprimeMatriz(estoqueTres, x, y);
            ImprimeMatriz(estoqueQuatro, x, y);
            Console.WriteLine();
            Console.WriteLine("---------------------");
            //inicio do loop
            for (int dia = 0; dia < 6; dia++) 
            {
                Console.WriteLine("Dia " + (dia + 1) + "");
                int carregamento = 0;
                carregamento = Geradores.Qtd();
                //lista de entrada pra receber carregamento
                List<string> entrada = new List<string>();

                //inicio do contador
                int count1 = 0; 
                int count2 = 0;
                int count3 = 0;
                int count4 = 0;
                Console.Write("Carga recebida, carregamento => ");
                //roda quantidade de carga pra lista
                for (int i = 0; i < carregamento; i++)
                {
                    //recebe os valores de entrada
                    entrada = Geradores.GeraEntrada();
                    for (int j = 0; j < entrada.Count; j++)
                    {
                        Console.Write(entrada[j]);
                    }
                    foreach (var item in entrada)
                    {
                        //checa os itens da carga de entrada e acrescenta ao contador
                        if (item.Contains("1"))
                        {
                            count1++;
                        }
                        if (item.Contains("2"))
                        {
                            count2++;
                        }
                        if (item.Contains("3"))
                        {
                            count3++;
                        }
                        if (item.Contains("4"))
                        {
                            count4++;
                        }
                    }
                    Console.WriteLine();
                }
                for (int i = 1; i < 5; i++)
                {
                    //checa o numero do contador de entrada e acrescenta à matriz respectiva usando a função Preenche, roda 4 vezes, uma para cada ID
                    switch (i)  
                    {
                        case 1:
                            estoqueUm = Preenche(estoqueUm, x, y, count1, 1);
                            break;
                        case 2:
                            estoqueDois = Preenche(estoqueDois, x, y, count2, 2);
                            break;
                        case 3:
                            estoqueTres = Preenche(estoqueTres, x, y, count3, 3);
                            break;
                        case 4:
                            estoqueQuatro = Preenche(estoqueQuatro, x, y, count4, 4);
                            break;
                        default:
                            break;
                    }
                }
                //impressão dos estoques
                ImprimeMatriz(estoqueUm, x, y);
                ImprimeMatriz(estoqueDois, x, y);
                ImprimeMatriz(estoqueTres, x, y);
                ImprimeMatriz(estoqueQuatro, x, y);
                Console.WriteLine();
                Console.WriteLine("Pressione enter para continuar:");
                Console.WriteLine("---------------------");
                Console.ReadLine();

                //zeramento do contador pra começo de retirada
                count1 = 0; 
                count2 = 0;
                count3 = 0;
                count4 = 0;
                string saida;
                int carregamentoSaida = 0;
                carregamentoSaida = Geradores.Qtd();
                int[] vetSaida = new int[10];
               
                Console.Write("Carregamento de saída recebido => ");
                //roda quantidade de carregamento de saida
                for (int i = 0; i < carregamentoSaida; i++) 
                {
                    //recebe valores do carregamento de saida
                    saida = Geradores.OrdemDeServico();
                    for (int j = 0; j < saida.Length; j++)
                    {
                        // usa GetNumericValue com cast pra atribuir a string ao vetor
                        vetSaida[j] = (int)char.GetNumericValue(saida[j]);
                        Console.Write(vetSaida[j] + "");
                    }
                    for (int u = 0; u < vetSaida.Length; u++)
                    {
                        //contagem de numeros a serem retirados
                        if (vetSaida[u] == 1) 
                        {
                            count1++;
                        }
                        else if (vetSaida[u] == 2)
                        {
                            count2++;
                        }
                       else if (vetSaida[u] == 3)
                        {
                            count3++;
                        }
                        else if (vetSaida[u] == 4)
                        {
                            count4++;
                        }
                    }
                    Console.WriteLine();
                }
                for (int i = 1; i < 5; i++)
                {
                    //checa o contador que recebe valor do vetor e decrementa da matriz, roda 4 vezes, 1 vez pra cada ID 
                    switch (i) 
                    {
                        case 1:
                            estoqueUm = Retira(estoqueUm, x, y, count1, 1);
                            break;
                        case 2:
                            estoqueDois = Retira(estoqueDois, x, y, count2, 2);
                            break;
                        case 3:
                            estoqueTres = Retira(estoqueTres, x, y, count3, 3);
                            break;
                        case 4:
                            estoqueQuatro = Retira(estoqueQuatro, x, y, count4, 4);
                            break;
                        default:
                            break;
                    }
                }
                //impressão dos estoques de saída
                ImprimeMatriz(estoqueUm, x, y);
                ImprimeMatriz(estoqueDois, x, y);
                ImprimeMatriz(estoqueTres, x, y);
                ImprimeMatriz(estoqueQuatro,x,y);
                Console.WriteLine();
                Console.WriteLine("Pressione enter para continuar: ");
                Console.WriteLine("---------------------");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static int[,] ImprimeMatriz(int[,] ImprimeMatriz, int x, int y)
        {
            Console.WriteLine("---------------------");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write(ImprimeMatriz[i, j] + " ");
                   
                }
            }
            Console.WriteLine();
            return ImprimeMatriz;
        }
        public static int[,] Preenche(int[,] matriz, int x, int y, int contador, int numero) 
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (matriz[i, j] == 0) 
                    {
                        if (contador > 0)
                        {
                            //atribui o respectivo numero ao indice de matriz
                            matriz[i, j] = numero; 
                            contador--;
                        }
                    }
                }
            }
            return matriz;
        }
        public static int[,] Retira(int[,] ordemDeServico, int x, int y, int contadorsaida, int numero)
        {
            for (int i = x-1 ; i >= 0; i--)
            {
                for (int j = y- 1 ; j >= 0; j--)
                {
                    //checa o numero a ser decrementado
                    if (ordemDeServico[i, j] == numero)
                    {
                        if (contadorsaida > 0)
                        {
                            //decrementa
                            ordemDeServico[i, j] = 0; 
                            contadorsaida--;
                        }
                    }
                }
            }
            return ordemDeServico;
        }
    }
}


