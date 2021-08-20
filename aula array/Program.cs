using System;
using System.Linq;
namespace aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec1 ------------------------- LISTA 1 --------------------------

            //int[] cont = new int[2];
            //Console.WriteLine("Insira dois valores, mostro o maior");
            //cont[0] = int.Parse(Console.ReadLine());
            //cont[1] = int.Parse(Console.ReadLine());

            //if (cont[0] > cont[1])
            //{
            //    Console.WriteLine("{0} é maior", cont[0]);
            //}
            //else
            //{
            //    Console.WriteLine("{0} é maior", cont[1]);
            //}

            //for (int i = 0; i < cont.Length; i++)
            //{
            //    cont[i] = int.Parse(Console.ReadLine());
            //}

            //exec2


            //double[] media = new double[4];
            //Console.WriteLine("Insira a primeira nota: ");
            //media[0] = double.Parse(Console.ReadLine());
            //Console.WriteLine("Insira a segunda nota: ");
            //media[1] = double.Parse(Console.ReadLine());
            //Console.WriteLine("Insira a terceira nota: ");
            //media[2] = double.Parse(Console.ReadLine());
            //double sum = media.Sum();

            //Console.Clear();
            //Console.WriteLine("Sua média é {0}", sum / 3);


            //exec3

            //int[] cont = new int[3];
            //Console.WriteLine("insira tres valores");
            //cont[0] = int.Parse(Console.ReadLine());
            //cont[1] = int.Parse(Console.ReadLine());
            //cont[2] = int.Parse(Console.ReadLine());

            //if (cont[0] == cont[1] && cont[1] == cont[2])
            //{
            //    Console.WriteLine("São todos iguais");
            //}

            //else if (cont[0] > cont[1])
            //{
            //    Console.WriteLine("{0} é maior", cont[0]);
            //}
            //else if (cont[0] > cont[2])
            //{
            //    Console.WriteLine("{0} é maior", cont[1]);
            //}
            //else
            //{
            //    Console.WriteLine("{0} é maior", cont[2]);
            //}

            //for (int i = 0; i < cont.Length; i++)
            //{
            //    cont[i] = int.Parse(Console.ReadLine());
            //}

            //exec4

            //string escolha;
            //string[] cont = new string[3];
            //Console.WriteLine("insira três nomes");
            //Console.WriteLine("Nome 1:");
            //cont[0] = Console.ReadLine();
            //Console.WriteLine("Nome 2");
            //cont[1] = Console.ReadLine();
            //Console.WriteLine("Nome 3");
            //cont[2] = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Para solicitar o nome, digite o numero do respectivo");
            //escolha = Console.ReadLine();
            //switch (escolha)
            //{
            //    case "1":
            //        Console.WriteLine(cont[0]);
            //        break;
            //    case "2":
            //        Console.WriteLine(cont[1]);
            //        break;
            //    case "3":
            //        Console.WriteLine(cont[2]);
            //        break;
            //}

            //exec5

            //int[] cont = new int[5];
            //Console.WriteLine("Digite 5 valores e depois somarei");
            //cont[0] = int.Parse(Console.ReadLine());
            //cont[1] = int.Parse(Console.ReadLine());
            //cont[2] = int.Parse(Console.ReadLine());
            //cont[3] = int.Parse(Console.ReadLine());
            //cont[4] = int.Parse(Console.ReadLine());

            //int sum = cont.Sum();
            //Console.WriteLine("a soma deu {0}",sum);

            //exec6

            //int comando;
            //int b;
            //int a;
            //int c;
            //string[] nome = new string[4];
            //string[] cpf = new string[4];
            //int[] idade = new int[4];

            //while (true)
            //{
            //    Console.WriteLine("bem vindo ao cadastro de alunos. pressione 1 para cadastrar. se quiser sair, digite 2.");
            //    comando = int.Parse(Console.ReadLine());
            //    if (comando == 2)
            //    {
            //        break;
            //    }
            //    else if (comando == 1)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Em qual lugar deseja armazenar o cadastro?");
            //        b = int.Parse(Console.ReadLine());



            //        Console.WriteLine("primeiro, digite o nome do aluno: ");
            //        nome[b - 1] = Console.ReadLine();
            //        Console.WriteLine("digite o cpf do aluno: ");
            //        cpf[b - 1] = Console.ReadLine();
            //        Console.WriteLine("digite idade do aluno: ");
            //        idade[b - 1] = int.Parse(Console.ReadLine());

            //    }
            //    for (int i = 0; i < nome.Length; i++)
            //    {
            //        Console.WriteLine("|Nome(s): ----{0} ", nome[i]);
            //        Console.WriteLine("|CPF(s): -----{0} ", cpf[i]);
            //        Console.WriteLine("|Idade(s): ---{0} ", idade[i]);
            //        Console.WriteLine("|---------------- ");
            //    }
            // }

            //exec7

            //string[] placa = new string[10];
            //double[] hora = new double[10];
            //for (int i = 0; i < placa.Length; i++)
            //{
            //    placa[i] = "";
            //}
            //while (true)
            //{

            //    Console.WriteLine("entrando ou saindo?");
            //    Console.WriteLine("e = entrando | s = saindo");
            //    string esc = Console.ReadLine();

            //    if (esc == "e")
            //    {
            //        bool cheio = true;

            //        for (int i = 0; i < placa.Length; i++)
            //        {
            //            if (placa[i] == "")
            //            {
            //                Console.WriteLine("Digite a placa");
            //                placa[i] = Console.ReadLine();
            //                Console.WriteLine("Insira a hora de entrada");
            //                hora[i] = double.Parse(Console.ReadLine());
            //                cheio = false;
            //                break;
            //            }
            //        }
            //        if (cheio)
            //        {
            //            Console.WriteLine("esta cheio");
            //        }
            //    }
            //    else if (esc == "s")
            //    {
            //        Console.WriteLine("Qual a placa?");
            //        string saindo = Console.ReadLine();
            //        bool encontrado = true;
            //        for (int i = 0; i < placa.Length; i++)
            //        {
            //            if (placa[i] == saindo)
            //            {
            //                placa[i] = "";
            //                Console.WriteLine("Insira a hora de saida");
            //                double horasaida = double.Parse(Console.ReadLine());
            //                Console.WriteLine("Valor final: " + (horasaida - hora[i] * 3.5));
            //                encontrado = false;
            //                break;
            //            }
            //        }
            //        if (encontrado)
            //        {
            //            Console.WriteLine("Nao encontrada");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalido");
            //    }
            //}



            // ---------------------------LISTA 2------------------------

            //exec 1

            //int a = 0;
            //int b = 0;
            //int[] soma1 = new int[5];
            //int[] soma2 = new int[5];
            //int[] soma3 = new int[5];
            ////int sum = soma3.Sum();

            //while (b < 5)
            //{
            //    Console.WriteLine("primeiro valor");
            //    soma1[b] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Segundo valor");
            //    soma2[b] = int.Parse(Console.ReadLine());
            //    b++;
            //}


            //for (int i = 0; i < soma1.Length; i++)
            //{
            //    soma3[i] = soma1[i] + soma2[i];
            //    Console.WriteLine("a soma é {0}",soma3[i]);

            //}

            //exec2 // ---------------- incompleto



            //        int[] produtos = new int[5];
            //        produtos[0] = 1;
            //        produtos[1] = 5;
            //        produtos[2] = 10;
            //        produtos[3] = 4;
            //        produtos[4] = 35;
            //        int[] carrinho = new int[10];
            //        string escolha;
            //        int unidade;

            //        while (true)
            //        {
            //            Console.WriteLine("|Bem vindo a padaria onde o carrinho só tem 10 espaços---------|");
            //            Console.WriteLine("|--------------------------------------------------------------|");
            //            Console.WriteLine("|Para comprar pao digite 1: -----------------------------------|");
            //            Console.WriteLine("|para comprar pastel digite 2: --------------------------------|");
            //            Console.WriteLine("|para comprar cuca digite 3: ----------------------------------|");
            //            Console.WriteLine("|para comprar coxinha digite 4: -------------------------------|");
            //            Console.WriteLine("|Para comprar bolo digite 5: ----------------------------------|");
            //            Console.WriteLine("|Para finalizar a compra digite 6: ---------------------------x|");
            //            escolha = Console.ReadLine();

            //            if (escolha == "1")
            //            {
            //                Console.Clear();
            //                Console.WriteLine("Quantas unidades de pão você quer comprar?");
            //                unidade = int.Parse(Console.ReadLine());

            //                for (int i = 0; i < unidade; i++)
            //                {
            //                    carrinho[i = unidade] += carrinho[i];

            //                }

            //                Console.WriteLine("O carrinho agora tem {0} unidades, preço do pão {1:c}", carrinho[0], produtos[0] * unidade);
            //                Console.WriteLine("Pressione qualquer tecla para voltar");
            //                Console.ReadLine();
            //                Console.Clear();
            //            }
            //        }
            //    }
            //}


            //if (escolha == 1)
            //{
            //    for (int i = 0; i < carrinho.Length; i++)
            //    {
            //        produtos[0] += carrinho[i];
            //    }
            //}



            //exec3

            //    int[] vet1 = new int[10];
            //    int[] vet2 = new int[10];
            //    int[] vet3 = new int[10];
            //    int soma = 0;

            //    Random rnd = new Random();

            //    for (int i = 0; i < vet1.Length; i++)
            //    {
            //        int valor = rnd.Next(0, 30);
            //        int valor1 = rnd.Next(0, 30);
            //        int valor2 = rnd.Next(0, 30);
            //        vet1[i] = valor;
            //        vet2[i] = valor1;
            //        vet3[i] = valor2;

            //    }
            //    for (int i = 0; i < vet1.Length; i++)
            //    {

            //        if (vet1[i] > vet2[i])
            //        {
            //            soma += vet1[i];
            //            Console.WriteLine(vet1[i]);

            //        }
            //        else if (vet2[i] > vet3[i])
            //        {
            //            Console.WriteLine(vet2[i]);
            //            soma += vet2[i];
            //        }
            //        else
            //        {
            //            soma += vet3[i];
            //            Console.WriteLine(vet3[i]);
            //        }
            //    }
            //    Console.WriteLine("//----------------------------//");
            //    Console.WriteLine("Resultado: {0}",soma);
            //}



            // exec 4 e 5 criptografia e descriptografia da cifra de cesar n/e

            //string palavra, encriptar = null;

            ////Esta é a perfumaria que eu falei...
            ////método write escreve na tela do prompt do usuario
            //Console.Write("|---------------------------------|\n");
            //Console.Write("| 1 - Criptografar um mensagem    |\n");
            //Console.Write("| 2 - Decriptografar uma mensagem |\n");
            //Console.Write("| 0 - Sair                        |\n");
            //Console.Write("|---------------------------------|\n");
            //Console.Write(" Escolha a opçao: ");


            //int opcao = int.Parse(Console.ReadLine());

            //switch (opcao)
            //{

            //    case 1:
            //        Console.Write("Entre com a mensagem para ser criptografada: ");
            //        palavra = Console.ReadLine().ToLower();

            //        //enquanto a palavra for menor que i
            //        for (int i = 0; i < palavra.Length; i++)
            //        {
            //            //Devolve o codigo ASCII da letra
            //            int ASCII = (int)palavra[i];
            //            //Coloca a chave fixa adicionando 10 posições no numero da tabela ASCII
            //            int ASCIIC = ASCII + 10;
            //            //Concatena o texto e o coloca na variável
            //            encriptar += Char.ConvertFromUtf32(ASCIIC);
            //        }
            //        //Mostra o resultado final, concatenando a variável em que está o texto cifrado
            //        Console.Write("Resultado: " + encriptar);
            //        //Aguarda o usuário pressionar uma tecla para sair
            //        Console.ReadKey();
            //        //representa o final do case 1
            //        break;
            //    //caso a opcao escolhida for 2
            //    case 2:
            //        Console.Write("Entre com a mensagem para ser decriptografada: ");
            //        palavra = Console.ReadLine().ToLower();

            //        for (int i = 0; i < palavra.Length; i++)
            //        {
            //            int ASCII = (int)palavra[i];
            //            //Coloca a chave fixa retirando 10 posições no numero da tabela ASCII
            //            int ASCIIC = ASCII - 10;
            //            encriptar += Char.ConvertFromUtf32(ASCIIC);

            //        }

            //        Console.Write(encriptar);
            //        Console.ReadKey();
            //        break;

            //}

            //------------------------------ LISTA 3 ----------------------------------

            //exec1




            //exec 2 e 3

            //int[] cont = new int[5];
            //Console.WriteLine("Insira cinco valores:");
            //cont[0] = int.Parse(Console.ReadLine());
            //cont[1] = int.Parse(Console.ReadLine());
            //cont[2] = int.Parse(Console.ReadLine());
            //cont[3] = int.Parse(Console.ReadLine());
            //cont[4] = int.Parse(Console.ReadLine());

            //for (int i = 0; i < cont.Length; i++)
            //{
            //    Array.Sort(cont);
            //    Console.WriteLine(cont[i]);
            //}
        }
    }
}


