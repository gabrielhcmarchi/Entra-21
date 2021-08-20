using System;
using System.Collections.Generic;

namespace AulaPolimorfismoPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Novo> novos = new List<Novo>();
            List<Velho> velhos = new List<Velho>();
            Random ran = new Random();
            for (int i = 0; i < 2; i++)
            {
                Novo n = new Novo();
                n.Endereco = $"Rua XV   n°{ran.Next(10, 200 + 1)}";
                n.Preco = ran.Next(100000, 300000 + 1);
                n.Adicional = ran.Next(50000, 100000 + 1);
                n.Calcula();
                Velho v = new Velho();
                v.Endereco = $"Rua General Osório   n°{ran.Next(10, 200 + 1)}";
                v.Preco = ran.Next(100000, 200000 + 1);
                v.Desconto = ran.Next(50000, 100000 + 1);
                v.Calcula();
                novos.Add(n); velhos.Add(v);
            }
            Cliente cli = new Cliente();
            cli.Nome = "Cleber";
            cli.DinheiroDisponivel = ran.Next(100000, 300000 + 1);

            while (true)
            {

                Console.WriteLine("Ola Sr " + cli.Nome);
                Console.WriteLine("Com saldo de : {0:c}", cli.DinheiroDisponivel);
                Console.WriteLine("Qual apartamento deseja comprar?");
                Console.WriteLine("Imoveis Novos");
                int contador = 1;
                foreach (var item in novos)
                {
                    Console.WriteLine(contador);
                    MostraObjeto(item);
                    contador++;
                }
                Console.WriteLine("Imoveis Clássicos");
                foreach (var item in velhos)
                {
                    Console.WriteLine(contador);
                    MostraObjeto(item);
                    contador++;
                }
                Console.WriteLine("Qual Deseja Comprar?");
                contador = CR(0);
                if (contador < 3)
                {
                    contador--;
                    if (novos[contador].Preco > cli.DinheiroDisponivel)
                    {
                        Console.WriteLine("Nao tem como pagar à vista");
                        Console.WriteLine("Mas podemos parcelar pra você");
                        double valorParcela = CalculaParcela(novos[contador].Preco);
                        Console.WriteLine("Deseja Finalizar esta compra?");
                        Console.WriteLine("1- Sim\n 2 - Nao");
                        contador = CR(0);
                        if (contador == 1)
                        {
                            cli.DinheiroDisponivel -= valorParcela;
                            Console.WriteLine("Obrigado pela preferência");
                            break;
                        }
                    }
                    else
                    {
                        cli.DinheiroDisponivel -= novos[contador].Preco;
                        Console.WriteLine("Obrigado pela preferência");
                        break;
                    }
                }
                else
                {
                    contador -= 3;
                    if (velhos[contador].Preco > cli.DinheiroDisponivel)
                    {
                        Console.WriteLine("Nao tem como pagar à vista");
                        Console.WriteLine("Mas podemos parcelar pra você");
                        double valorParcela = CalculaParcela(velhos[contador].Preco);
                        Console.WriteLine("Deseja Finalizar esta compra?");
                        Console.WriteLine("1- Sim\n2- Nao");
                        contador = CR(0);
                        if (contador == 1)
                        {
                            cli.DinheiroDisponivel -= valorParcela;
                            Console.WriteLine("Obrigado pela preferência");
                            break;
                        }
                    }
                    else
                    {

                        cli.DinheiroDisponivel -= velhos[contador].Preco;
                        Console.WriteLine("Obrigado pela preferência");
                        break;
                    }
                }
                Console.WriteLine("Pressione Enter para prosseguir");
                CR();
                Console.Clear();
            }

        }
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CR(int j)
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double CalculaParcela(double valor)
        {
            Console.WriteLine("Valor das parcelas {0}", (valor * 1.1674) / 12);
            Console.WriteLine("Valor final {0:c}", (valor * 1.1674));
            return (valor * 1664) / 12;
        }
        public static void MostraObjeto(Novo n)
        {
            Console.WriteLine(n.Endereco);
            Console.WriteLine("{0:c}", n.Preco);
            Console.WriteLine("-------------------------");
        }
        public static void MostraObjeto(Velho v)
        {
            Console.WriteLine(v.Endereco);
            Console.WriteLine("{0:c}", v.Preco);
            Console.WriteLine("-------------------------");
        }
    }
}
