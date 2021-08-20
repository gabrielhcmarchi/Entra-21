using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec1

            //int numero;
            // Console.WriteLine("Digite qualquer valor: ");
            //try
            //{
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    if (numero > 10)
            //    {
            //        Console.WriteLine("O valor é maior que dez. ");

            //    }
            //    else
            //    {
            //        Console.WriteLine("O valor é menor que dez.");
            //    }


            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadLine();


            //exec2

            //double numero1, numero2;

            //Console.WriteLine("Digite valor 1");
            //numero1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite valor 2");
            //numero2 = Convert.ToDouble(Console.ReadLine());

            //if (numero1 == numero2)
            //{
            //Console.WriteLine("São iguais.");
            //}
            //else
            //{
            //Console.WriteLine("Não são ou sei lá.");
            //}

            //exec3

            //double n1, n2;

            //Console.WriteLine("Digite um valor: ");
            //n1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite um segundo valor: ");
            //n2 = Convert.ToDouble(Console.ReadLine());

            //if (n2 > n1)
            //{
            //    Console.WriteLine("Seu valor é: " +n2);
            //}
            //else if (n2 > n1)
            //{
            //    Console.WriteLine("Seu valor é: "+n2);
            //}

            //exec4

            //double n1, n2, n3;
            //Console.WriteLine("Digite o primeiro valor: ");
            //n1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite o segundo valor: ");
            //n2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro valor: ");
            //n3 = Convert.ToDouble(Console.ReadLine());

            //if (n1 > n2)
            //{
            //    if (n1 > n3)
            //    {
            //        Console.Write("O primeiro é o maior:{0}", n1);
            //    }
            //    else
            //    {
            //        Console.Write("O terceiro é o maior:{0} ", n3);
            //    }
            //}
            //else if (n2 > n3)
            //    Console.Write("O segundo é o maior:{0}", n3);
            //else
            //    Console.Write("O terceiro é o maior:{0}", n3);
            //Console.ReadLine();


            //Exec5

            //double numero;
            //Console.WriteLine("Digite um número: ");
            //numero = Convert.ToDouble(Console.ReadLine());

            //switch (numero)
            //{
            //    case 1:
            //        Console.WriteLine("numero 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Numero 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("Número 3");
            //        break;
            //    default:
            //        Console.WriteLine("não computável");
            //        break;

            //exec6

            //Random rnd = new Random();
            //int valor = rnd.Next(1, 7);
            //if (valor >= 3)
            //{
            //    Console.WriteLine("{0} - Você venceu.",valor);

            //}
            //else
            //{
            //    Console.WriteLine("{0} - Você perdeu.",valor);
            //}
            //Console.ReadLine();

            //exec7

            //int numcheck;
            //Console.WriteLine("Insira um valor");
            //numcheck = Convert.ToInt32(Console.ReadLine());
            //if (numcheck % 2 == 0)
            //{
            //    Console.WriteLine("É par");
            //}
            //else
            //{
            //    Console.WriteLine("É impar");
            //}
            //Console.ReadLine();

            //exec8

            //double valor ;
            //Console.WriteLine("Digite um valor: ");
            //valor = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("O valor original de {0}", valor);
            //double percentual1 = 28.0 / 100.0; // 28%
            //double percentual2 = 21.0 / 100.0;
            //double valor_final1 = valor - (percentual1 * valor);
            //double valor_final2 = valor - (percentual2 * valor);

            //if(valor > 254.50)
            //{
            //    valor = valor_final1;
            //    Console.WriteLine("agora custa {0}", valor_final1);
            //}
            //else
            //{
            //    valor = valor_final2;
            //    Console.WriteLine("agora custa {0}", valor, valor_final2);
            //}

            //exec9

            //double salario;
            //double aumento1 = 30.0 / 100.0;
            //double aumento2 = 25.0 / 100.0;
            //double aumento3 = 20.0 / 100.0;
            //double aumento4 = 15.0 / 100.0;
            //double aumento5 = 10.0 / 100.0;
            //Console.WriteLine("Digite seu salário: ");
            //salario = Convert.ToDouble(Console.ReadLine());
            //double salariofinal = salario + (salario * aumento1);


            //if (salario <= 600.00)
            //{
            //    salario = aumento1;
            //    Console.WriteLine("Seu salário agora é:{0}", salariofinal);
            //}
            //else if (salario > 600.01 && salario <= 1100.00)
            //{
            //    salario = aumento2;
            //    Console.WriteLine("Seu salário agora é:{0}", salariofinal);
            //}
            //else if (salario > 1100.01 && salario <= 2400.00)
            //{
            //    salario = aumento3;
            //    Console.WriteLine("Seu salário agora é:{0}", salariofinal);
            //}
            //else if (salario > 2400.01 && salario <= 3550.00)
            //{
            //    salario = aumento4;
            //    Console.WriteLine("Seu salário agora é:{0}", salariofinal);
            //}
            //else if (salario > 3550.00)
            //{
            //    salario = aumento5;
            //    Console.WriteLine("Seu salário agora é:{0}", salariofinal);
            //}

            //exec10

            //double valor_compra;

            //Console.WriteLine("Qual o valor da compra?");
            //valor_compra = Convert.ToDouble(Console.ReadLine());

            //int cartao, quinta_compra;

            //Console.WriteLine("Tem cartão fidelidade? 1 pra sim, 2 pra não");
            //cartao = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("É a quinta compra? 1 pra sim, 2 pra não");
            //quinta_compra = Convert.ToInt32(Console.ReadLine());

            //if(valor_compra > 0.01 && valor_compra <= 200.00)
            //{
            //    double sempercentual = 0 / 100.0;
            //    double desc = valor_compra - (sempercentual * valor_compra);
            //    valor_compra = desc;
            //}
            //else if (valor_compra > 200.01 && valor_compra <= 400.00)
            //{
            //double percentual = 10.0 / 100.0;
            //double desc2 = valor_compra - (percentual * valor_compra);
            //valor_compra = desc2;

            //}
            //else
            //{
            //double percentual2 = 20.0 / 100.0;
            //double desc3 = valor_compra - (percentual2 * valor_compra);
            //valor_compra = desc3;

            //}
            //if (cartao == 1)
            //{
            //double percentual3 = 15.0 / 100.0;
            //double desc4 = valor_compra - (percentual3 * valor_compra);
            //valor_compra = desc4;

            //}
            //if (quinta_compra == 1)
            //{
            //double percentual4 = 10.0 / 100.0;
            //double desc5 = valor_compra - (percentual4 * valor_compra);
            //valor_compra = desc5;

            //}
            //Console.WriteLine("O valor da sua compra: {0}", valor_compra);

            //calculadora

            //double num1, num2;
            //int operacao = 0;

            //while (operacao != 5)
            //{
            //    Console.WriteLine("Digite o primeiro valor");
            //    num1 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Digite o segundo numero");
            //    num2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Soma, digite 1");
            //    Console.WriteLine("Subtração, digite 2");
            //    Console.WriteLine("Divisão, digite 3");
            //    Console.WriteLine("Multiplicação, digite 4");
            //    Console.WriteLine("Para sair digite 5");
            //    operacao = int.Parse(Console.ReadLine());
            //    Console.Clear();

            //    if (num1 == 0 || num2 == 0 && operacao == 3)
            //    {
            //        Console.WriteLine("404");
            //    }
            //    else
            //    {
            //        if (operacao == 1)
            //        {
            //            Console.WriteLine("O resultado da soma é = {0}", num1 + num2);
            //        }

            //        if (operacao == 2)
            //        {
            //            Console.WriteLine("O resultado da subtração é: {0}", num1 - num2);
            //        }

            //        if (operacao == 3)
            //        {
            //            Console.WriteLine("O resultado da divisão é: {0}", num1 / num2);
            //        }

            //        if (operacao == 4)
            //        {
            //            Console.WriteLine("O resultado da multiplicação é:{0} ", num1 * num2);
            //        }
            //        if (operacao == 5)
            //        {
            //            Console.WriteLine("Operação cancelada. Pressione qualquer botão para sair");
            //        }
            //    }
            //    Console.WriteLine("Pressione qualquer botão pra sair.");
            //    Console.ReadLine();
            //    Console.Clear();

            //lista de exec 2

            //exec 1

            //double queijo = 4.50;
            //double macarrão = 5.00;
            //double feijão = 4.00;
            //double presunto = 5.50;
            //double total = 0;
            //int escolha = 0;
            //int carrinho = 0;
            //int unidade;

            //while (escolha != 5)
            //{

            //    Console.WriteLine("Bem vindo ao mercado do zeca, onde o carrinho só tem 8 espaços");
            //    Console.WriteLine("Para comprar queijo digite 1");
            //    Console.WriteLine("para comprar macarrao digite 2");
            //    Console.WriteLine("para comprar feijão digite 3");
            //    Console.WriteLine("para comprar presunto, digite 4");
            //    Console.WriteLine("Para finalizar a compra digite 5");
            //    escolha = int.Parse(Console.ReadLine());


            //    if (carrinho != 7)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Carrinho lotado!");
            //        Console.WriteLine("Pressione qualquer tecla pra voltar");
            //    }

            //    {
            //        if (escolha == 1)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Quantas unidades de queijo você quer comprar?");
            //            unidade = int.Parse(Console.ReadLine());
            //            carrinho = carrinho + unidade;
            //            Console.WriteLine("Acrescentados {0} unidades de queijo no valor de {1}", carrinho, queijo);
            //            Console.WriteLine("Pressione qualquer tecla para voltar");
            //            Console.ReadLine();
            //            Console.Clear();
            //            if (unidade >= 4)
            //            {

            //                queijo = (unidade * queijo) - (unidade * queijo) * 0.1;
            //                total = total + queijo;
            //            }

            //        }

            //        if (escolha == 2)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Quantas unidades de macarrão você quer comprar?");
            //            unidade = int.Parse(Console.ReadLine());
            //            carrinho = carrinho + unidade;
            //            Console.WriteLine("Acrescentados {0} unidades de macarrão no valor de {1}", carrinho, macarrão);
            //            Console.WriteLine("Pressione qualquer tecla para voltar");
            //            Console.ReadLine();
            //            Console.Clear();
            //            if (unidade >= 4)
            //            {

            //                macarrão = (unidade * macarrão) - (unidade * macarrão) * 0.1;
            //                total = total + macarrão;
            //            }

            //        }
            //        if (escolha == 3)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Quantas unidades de feijão você quer comprar?");
            //            unidade = int.Parse(Console.ReadLine());
            //            carrinho = carrinho + unidade;
            //            Console.WriteLine("Acrescentados {0} unidades de feijão no valor de {1}", carrinho, feijão);
            //            Console.WriteLine("Pressione qualquer tecla para voltar");
            //            Console.ReadLine();
            //            Console.Clear();
            //            feijão = unidade * feijão;
            //            total = total + feijão;
            //        }
            //        if (escolha == 4)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Quantas unidades de presunto você quer comprar?");
            //            unidade = int.Parse(Console.ReadLine());
            //            carrinho = carrinho + unidade;
            //            Console.WriteLine("Acrescentados {0} unidades de presunto no valor de {1}", carrinho, presunto);
            //            Console.WriteLine("Pressione qualquer tecla para voltar");
            //            Console.ReadLine();
            //            Console.Clear();
            //            presunto = unidade * presunto;
            //            total = total + presunto;
            //        }
            //        if(carrinho >= 8 || escolha == 5) 
            //        {
            //            Console.WriteLine("Carrinho chegou a capacidade máxima!");



            //            if (carrinho > 5)
            //            {
            //                total = total - (total / 100) * 5;
            //            }
            //            Console.WriteLine("O preço total da sua compra é: {0}", total);
            //            Console.WriteLine("Digite qualquer tecla para sair.");
            //            Console.ReadLine();
            //            break;
            //        }

            //    }
            //    }

            // loops

            //exec1

            //for (int i = 1; i <11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //exec2

            //for (int i = 0; i < 24; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //exec3

            //Console.WriteLine("digite um número");
            //float num = float.Parse(Console.ReadLine());

            //while (num  > 0)
            //{
            //    num--; // n = n - 1
            //    Console.WriteLine("{0}",num);

            //  
            //  
            //  
            //  
            //  
            //}

            //exec4

            //Console.WriteLine("digite um número");
            //int num = int.Parse(Console.ReadLine());

            //while (num > 0)
            //{
            //    num--; // n = n - 1
            //    Console.WriteLine("{0}", num);
            //}
            //while (num <= -1)
            //{
            //    num++;
            //    Console.WriteLine(num);
            //}

            //exec5

            //double num;
            //string sair = "exit";
            //while (true)
            //{
            //    Console.WriteLine("Digite um número ou escreva exit para sair");
            //    sair = Console.ReadLine();
            //    if (sair=="exit")
            //    {
            //        break;
            //    }
            //    num = Convert.ToDouble(sair);
            //    if (num >= 24)
            //    {
            //        Console.WriteLine(num * 2); ;
            //    }
            //    else if (num > 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Insira o número novamente");
            //    }
            //}

            //exec6




            //while (true)
            //{
            //    int comando;
            //    var cadastro = new ArrayList();
            //    Console.WriteLine("Bem vindo ao cadastro de alunos. Pressione 1 para cadastrar. Se quiser sair, digite 2.");
            //    comando = Convert.ToInt32(Console.ReadLine());
            //    if (comando == 2)
            //    {
            //        break;
            //    }
            //    else if (comando == 1)
            //    {
            //        Console.WriteLine("Primeiro, digite o nome do aluno: ");
            //        cadastro.Add(Console.ReadLine());

            //        Console.WriteLine("Digite o Cpf:");
            //        cadastro.Add(Console.ReadLine());

            //        Console.WriteLine("Digite o endereço");
            //        cadastro.Add(Console.ReadLine());

            //        Console.Clear();
            //        Console.WriteLine("Aluno cadastrado: ");
            //        Console.WriteLine(cadastro[0]);
            //        Console.WriteLine(cadastro[1]);
            //        Console.WriteLine(cadastro[2]);
            //    }
            //}

            //exec7

            //double valorPositivo = 10.00;
            //double valorNegativo = -15.00;
            //double deve = -0;
            //double ganha = 0;
            //double conta=0;

            //Random rnd = new Random();
            //for (int i = 0; i < 30; i++)
            //{
            //    double roll = rnd.Next(1, 7);

            //    if (roll >= 3)
            //    {
            //        ganha = valorPositivo + ganha;
            //        //Console.WriteLine("Você ganhou {0}", ganha);
            //    }
            //    else
            //    {
            //        deve = valorNegativo - deve;
            //        //Console.WriteLine("Você deve {0}", -deve);
            //    }

            //    if (conta != valorPositivo)
            //    {
            //            conta = ganha + deve;
            //        Console.WriteLine("Você deve {0}", conta);
            //    }
            //    else if (conta != valorNegativo)
            //    {
            //        conta = ganha - deve;
            //        Console.WriteLine("Você ganhou {0}", conta);
            //    }


            //Console.WriteLine(" valor total é : {0}",conta);



            //exec8



            //double queijo = 4.50;
            //double macarrão = 5.00;
            //double feijão = 4.00;
            //double presunto = 5.50;
            //double pão = 3.50;
            //double total = 0;
            //int escolha = 0;
            //int carrinho = 0;
            //int unidade;

            //while (escolha != 5)
            //{

            //    Console.WriteLine("Bem vindo ao mercado do zeca, onde o carrinho só tem 8 espaços");
            //    Console.WriteLine("Para comprar queijo digite 1");
            //    Console.WriteLine("para comprar macarrao digite 2");
            //    Console.WriteLine("para comprar feijão digite 3");
            //    Console.WriteLine("para comprar presunto, digite 4");
            //    Console.WriteLine("Para comprar pão digite 5");
            //    Console.WriteLine("Para finalizar a compra digite 6");
            //    escolha = int.Parse(Console.ReadLine());


            //    if (carrinho != 7)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Carrinho lotado!");
            //        Console.WriteLine("Pressione qualquer tecla pra voltar");
            //    }

            //    {
            //        if (escolha == 1)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Quantas unidades de queijo você quer comprar?");
            //            unidade = int.Parse(Console.ReadLine());
            //            carrinho = carrinho + unidade;
            //            Console.WriteLine("O carrinho agora tem {0} unidades, preço do queijo: {1:c}", carrinho, queijo);
            //            Console.WriteLine("Pressione qualquer tecla para voltar");
            //            Console.ReadLine();
            //            Console.Clear();
            //            if (unidade >= 4)
            //            {

            //                queijo = (unidade * queijo) - (unidade * queijo) * 0.1;
            //                total = total + queijo;
            //            }

            //        }

            //        if (escolha == 2)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Quantas unidades de macarrão você quer comprar?");
            //            unidade = int.Parse(Console.ReadLine());
            //            carrinho = carrinho + unidade;
            //            Console.WriteLine("O carrinho agora tem {0} unidades, preço do macarrão: {1:c}", carrinho, macarrão);
            //            Console.WriteLine("Pressione qualquer tecla para voltar");
            //            Console.ReadLine();
            //            Console.Clear();
            //            if (unidade >= 4)
            //            {

            //                macarrão = (unidade * macarrão) - (unidade * macarrão) * 0.1;
            //                total = total + macarrão;
            //            }

            //        }
            //        if (escolha == 3)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Quantas unidades de feijão você quer comprar?");
            //            unidade = int.Parse(Console.ReadLine());
            //            carrinho = carrinho + unidade;
            //            Console.WriteLine("O carrinho agora tem {0} unidades, preço do feijão: {1:c}", carrinho, feijão);
            //            Console.WriteLine("Pressione qualquer tecla para voltar");
            //            Console.ReadLine();
            //            Console.Clear();
            //            feijão = unidade * feijão;
            //            total = total + feijão;
            //        }
            //        if (escolha == 4)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Quantas unidades de presunto você quer comprar?");
            //            unidade = int.Parse(Console.ReadLine());
            //            carrinho = carrinho + unidade;
            //            Console.WriteLine("O carrinho agora tem {0} unidades, preço do presunto: {1:c}", carrinho, presunto);
            //            Console.WriteLine("Pressione qualquer tecla para voltar");
            //            Console.ReadLine();
            //            Console.Clear();
            //            presunto = unidade * presunto;
            //            total = total + presunto;
            //        }
            //        if (escolha == 5)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Quantas unidades de pão você quer comprar?");
            //            unidade = int.Parse(Console.ReadLine());
            //            carrinho = carrinho + unidade;
            //            Console.WriteLine("O carrinho agora tem {0} unidades, preço do pão: {1:c}", carrinho, pão);
            //            Console.WriteLine("Pressione qualquer tecla para voltar");
            //            Console.ReadLine();
            //            Console.Clear();
            //            pão = unidade * pão;
            //            total = total + queijo;
            //        }
            //            if (carrinho >= 8 || escolha == 5)
            //        {
            //            Console.WriteLine("Carrinho chegou a capacidade máxima!");

            //            if (carrinho > 5)
            //            {
            //                total = total - (total / 100) * 5;
            //            }
            //            Console.WriteLine("O preço total da sua compra é: R${0}", total);
            //            Console.WriteLine("Digite qualquer tecla para sair.");
            //            Console.ReadLine();
            //            break;
            //        }

            //    }
            //}

            //calculadora

            //            while (true)
            //            {
            //                double num1, num2;
            //                string operacao;
            //                double valor;
            //                Console.WriteLine("Digite o primeiro valor");
            //                num1 = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Digite o segundo valor");
            //                num2 = Convert.ToDouble(Console.ReadLine());
            //                Console.Clear();
            //                Console.WriteLine("|Soma --------- digite +");
            //                Console.WriteLine("|Subtração ---- digite -");
            //                Console.WriteLine("|Divisão ------ digite /");
            //                Console.WriteLine("|Multiplicação  digite x");
            //                Console.WriteLine("|Potenciação -- digite ^");
            //                Console.WriteLine("Para sair digite exit");
            //                operacao = (Console.ReadLine());
            //                Console.Clear();
            //                double resultado = 0;
            //                if (num1 == 0 || num2 == 0 && operacao == "/")
            //                {
            //                    Console.WriteLine("404");
            //                }
            //                else
            //                {
            //                    resultado = Conta(operacao, num1, num2);
            //                    if (resultado != 935439)
            //                    {
            //                        Console.WriteLine("{0}{1}{2}={3}", num1, operacao, num2, resultado);
            //                        do
            //                        {
            //                            string condicao;
            //                            Console.WriteLine("para continuar a conta digite s. para resetar, c");
            //                            condicao = Console.ReadLine();
            //                            if (condicao == "s")
            //                            {
            //                                valor = Convert.ToDouble(Console.ReadLine());
            //                                resultado = Conta(operacao, resultado, valor);
            //                                Console.WriteLine(resultado);
            //                            }
            //                            else if (condicao == "c")
            //                            {
            //                                Console.Clear();
            //                                break;
            //                            }

            //                        } while (true);
            //                    }
            //                    else
            //                    {
            //                        break;
            //                    }
            //                }
            //            }
            //        }
            //        public static double Conta(string operacao, double num1, double num2)
            //        {
            //            switch (operacao)
            //            {
            //                case "+":
            //                    return num1 + num2;

            //                case "-":
            //                    return num1 - num2;

            //                case "/":
            //                    return num1 / num2;

            //                case "*":
            //                    return num1 * num2;

            //                case "^":
            //                    return Math.Pow(num1, num2);

            //                case "exit":
            //                    Console.WriteLine("Operação cancelada. Pressione qualquer botão para sair");
            //                    Console.ReadLine();
            //                    break;
            //            }
            //            return 935439;

            //        }
            //    }
            //}
        }
    }
}


