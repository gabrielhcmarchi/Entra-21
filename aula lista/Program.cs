using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {

            //--------------------------------------listaI----------------------------------------//

            //exec 01

            //-------------------------------------------------------------------------------------//

            ////criando a lista
            //List<string> listaDeString = new List<string>();
            ////pedir dados
            //Console.WriteLine("Insira 2 entradas quaisquer");
            //string entrada = Program.CR();
            //listaDeString.Add(entrada);
            //entrada = CR();
            //listaDeString.Add(entrada);
            ////mostrar na tela
            //Console.WriteLine("------------//--------------");
            //for (int i = 0; i < listaDeString.Count; i++)
            //{
            //    Console.WriteLine(listaDeString[i]);
            //}
            //Console.WriteLine("------------//--------------");
            //foreach (var item in listaDeString)
            //{
            //    Console.WriteLine(item);
            //}

            //-------------------------------------------------------------------------------------//

            // exec 02


            ////cria a lista
            //List<double> notas = new List<double>();
            //// Pede dados
            //Console.WriteLine("insira as 3 notas");
            ////for (int i = 0; i < 3; i++)
            ////{
            ////    var nota = CRD(); // CRD é uma função que chama Convert.ToDouble(Console.ReadLine())
            ////    notas.Add(nota);
            ////}
            //var nota = CRD(); // CRD é uma função que chama Convert.ToDouble(Console.ReadLine())
            //notas.Add(nota);
            //nota = CRD(); // CRD é uma função que chama Convert.ToDouble(Console.ReadLine())
            //notas.Add(nota);
            //nota = CRD(); // CRD é uma função que chama Convert.ToDouble(Console.ReadLine())
            //notas.Add(nota);
            ////mostra
            //double resultado = 0;
            //foreach (var item in notas)
            //{
            //    resultado += item;
            //}
            //Console.WriteLine("Média ► " + (resultado / 3));

            //-------------------------------------------------------------------------------------//

            //exec3

            //List<double> listaMaior = new List<double>();
            //Console.WriteLine("Insira três valores: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    var valor = CRD();
            //    listaMaior.Add(valor);
            //}
            //if (listaMaior[0] == listaMaior[1] && listaMaior[0] == listaMaior[2])
            //{
            //    Console.WriteLine("os números são iguais. ");
            //}
            //else
            //{
            //    double maiorNumero = listaMaior.Max();
            //    Console.WriteLine("O maior número é " + listaMaior.Max());
            //}

            //-------------------------------------------------------------------------------------//


            //exec4

            //List<double> armazenaNumeros = new List<double>();
            //double mult = 1.0;
            //Console.WriteLine("Armazene números consecutivamente. Caso queira parar, pressione 0.");
            //for (int i = 0; true; i++)
            //{
            //    var numero = CRD();


            //    if (numero == 0)
            //    {

            //        foreach  (var item in armazenaNumeros)
            //        {
            //            mult = mult * item;
            //        }
            //        //var mult = armazenaNumeros.Aggregate((x, y) => x * y);
            //        Console.WriteLine("a multiplicação de todos os números é: {0} "  , mult);
            //        break;
            //    }
            //    armazenaNumeros.Add(numero);
            //}

            //-------------------------------------------------------------------------------------//

            //exec5

            //       ^ 
            //-------! exception
            //-------------------------------------------------------------------------------------//


            //-------------------------------------------------------------------------------------//
            //exec6

            //List<string> logins = new List<string>();
            //List<string> senhas = new List<string>();
            //// preenche as lista com letras de 'a' a 'e'
            //for (int i = 97; i < 102; i++) // preenche com letras
            //{
            //    char letra = Convert.ToChar(i);
            //    logins.Add(letra.ToString());
            //    letra = Convert.ToChar(i - 32);
            //    senhas.Add(Convert.ToString(letra));
            //}

            //while (true)
            //{
            //    Console.WriteLine("Insira o login ou sair ou ver");
            //    string tempL = CR(); // CR() == Console.ReadLine
            //    if (tempL == "sair")
            //    {
            //        break;
            //    }
            //    else if (tempL == "ver")
            //    {
            //        MostraLista(logins);
            //        MostraLista(senhas);
            //    }
            //    else if (tempL == "Admin")
            //    {
            //        Console.WriteLine("Senha do Admin");
            //        string tempS = CR();
            //        if (tempS == "@Senac")
            //        {
            //            int a = 0;
            //            while (a == 0)
            //            {
            //                Console.WriteLine("\t\t***Menu Do Admin***");
            //                Console.WriteLine("1 - Criar Conta");
            //                Console.WriteLine("2 - Deletar Conta");
            //                Console.WriteLine("3 - LogOut");
            //                int escolha = CRI();// CRI() == Convert.ToInt32(Console.ReadLine());
            //                switch (escolha)
            //                {
            //                    case 1:
            //                        Console.WriteLine("Qual o login desta conta?");
            //                        string entrada = CR();
            //                        if (BuscaEmLista(logins, entrada) == -1)
            //                        {
            //                            logins.Add(entrada);
            //                            Console.WriteLine("Qual a senha deste login?");
            //                            entrada = CR();
            //                            senhas.Add(entrada);
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Login ja existente");
            //                        }
            //                        break;
            //                    case 2:
            //                        int cont = 0;
            //                        foreach (var item in logins)
            //                        {
            //                            cont++;
            //                            Console.WriteLine(cont + " -> " + item);
            //                        }
            //                        Console.WriteLine("\nQual deseja remover?");
            //                        cont = CRI();
            //                        logins.RemoveAt(cont);
            //                        senhas.RemoveAt(cont);
            //                        break;
            //                    case 3:
            //                        a = 1;
            //                        Console.WriteLine("Log Out efetuado");
            //                        break;
            //                    default:
            //                        Console.WriteLine("Opção inválida");
            //                        break;
            //                }
            //                Console.WriteLine("Pressione enter para progredir");
            //                Console.ReadLine();
            //                Console.Clear();
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Senha incorreta");
            //        }
            //    }
            //    else
            //    {
            //        int indice = BuscaEmLista(logins, tempL);
            //        if (indice != -1)
            //        {
            //            Console.WriteLine("Qual a senha?");
            //            string tempS = CR();
            //            if (senhas[indice] == tempS)
            //            {
            //                Console.WriteLine("Login efetuado");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Senha incorreta");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Login não encontrado");
            //        }
            //    }
            //    Console.WriteLine("Pressione enter para progredir");
            //    Console.ReadLine();
            //    Console.Clear();
            //}



            //-------------------------------------listaII-----------------------------------------//

            //exec01 -- igual 4 da 1

            //List<string> nomeUsuario = new List<string>();
            //Console.WriteLine("Armazene nomes consecutivamente. Caso queira parar e mostrar todos os nomes, escreva sair");
            //for (int i = 0; true; i++)
            //{
            //    var nome = CR();


            //    if (nome == "sair" || nome == "SAIR")
            //    {
            //        Console.WriteLine();
            //        foreach (var item in nomeUsuario)
            //        {

            //            Console.Write(item + " --- ");

            //        }

            //        break;
            //    }
            //    nomeUsuario.Add(nome);

            //-------------------------------------------------------------------------------------//

            //exec02 -- igual a 2 da lista 1

            ////cria a lista
            //List<double> notas = new List<double>();
            ////Pede dados
            //Console.WriteLine("insira as notas, ou digite 0 para mostrar a média de todas");
            //for (int i = 0; true; i++)
            //{
            //    var nota = CRD(); 
            //    notas.Add(nota);
            //    if (nota == 0)
            //    {
            //        Console.WriteLine();
            //        double resultado = 0;
            //        foreach (var item in notas)
            //        {
            //            resultado += item;
            //        }
            //        Console.WriteLine("Média ► " + (resultado / 3));
            //    }


            //-------------------------------------------------------------------------------------//

            //exec3 - igual a 3 da 01

            //List<double> listaMaior = new List<double>();
            //Console.WriteLine("Insira valores, para parar digite 0: ");
            //for (int i = 0; true; i++)
            //{
            //    var valor = CRD();

            //    if (valor == 0)
            //    {
            //        double maiorNumero = listaMaior.Max();
            //        Console.WriteLine("O maior número é " + listaMaior.Max());
            //        double menorNumero = listaMaior.Min();
            //        Console.WriteLine("O menor número é " +listaMaior.Min());
            //    }
            //    listaMaior.Add(valor);
            //}


            //-------------------------------------------------------------------------------------//

            //exec04 -- mostrar nomes com list sort manual

            List<string> nomesUsuario = new List<string>();
            List<double> nascimentoUsuario = new List<double>();
            Console.WriteLine("Digite nome, e depois data de nascimento. Para parar, digite parar ou 0 ");
            for (int i = 0;  true; i++)
            {
                var entrada = CR();
                var entrada2 = CRD();//testar retirada 
                nomesUsuario.Add(entrada);
                nascimentoUsuario.Add(entrada2);//same

                if(entrada == "parar" && entrada2 == 0)//same p 2 condição
                {
                    //atribuição com lista de pseudo-objeto e sort de data de nascimento
                    //cw com retorno de sort manual por objeto -> data de nascimento, do mais velho pro mais novo
                    // |fulano | ciclano | beltrano |
                    // | 24/09 |  25/08  |  29/07   |
                    // é possível criar um método para o sort manual
                    //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
                }
            }
            //-------------------------------------------------------------------------------------//


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
        public static int BuscaEmLista(List<string> elementos, string verificador)//da pra fazer implementação de objeto com classe
        {
            for (int i = 0; i < elementos.Count; i++)
            {
                if (elementos[i] == verificador)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void MostraLista(List<string> elementos)
        {
            foreach (var item in elementos)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}




