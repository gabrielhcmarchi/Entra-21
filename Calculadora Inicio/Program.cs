using System;

namespace Calculadora01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)                
            {
                double num1, num2;
                string operacao;
                double valor;
                Console.WriteLine("Digite o primeiro valor");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("|Soma --------- digite +");
                Console.WriteLine("|Subtração ---- digite -");
                Console.WriteLine("|Divisão ------ digite /");
                Console.WriteLine("|Multiplicação  digite x");
                Console.WriteLine("|Potenciação -- digite ^");
                Console.WriteLine("Para sair digite exit");
                operacao = (Console.ReadLine());
                Console.Clear();
                double resultado = 0;
                if (num1 == 0 || num2 == 0 && operacao == "/")
                {
                    Console.WriteLine("404");
                }
                else
                {
                    resultado = Conta(operacao, num1, num2);
                    if (resultado != 935439)
                    {
                        Console.WriteLine("{0}{1}{2}={3}", num1, operacao, num2, resultado);
                        do
                        {
                            string condicao;
                            Console.WriteLine("para continuar a conta digite s. para resetar, c");
                            condicao = Console.ReadLine();
                            if (condicao == "s")
                            {
                                Console.WriteLine("Insira o próximo valor");
                                valor = Convert.ToDouble(Console.ReadLine());
                                resultado = Conta(operacao, resultado, valor);
                                Console.WriteLine(resultado);
                            }
                            else if (condicao == "c")
                            {
                                Console.Clear();
                                break;
                            }

                        } while (true);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public static double Conta(string operacao, double num1, double num2)
        {
            switch (operacao)
            {
                case "+":
                    return num1 + num2;

                case "-":
                    return num1 - num2;

                case "/":
                    return num1 / num2;

                case "*":
                    return num1 * num2;

                case "^":
                    return Math.Pow(num1, num2);

                case "exit":
                    Console.WriteLine("Operação cancelada. Pressione qualquer botão para sair");
                    Console.ReadLine();
                    break;
            }
            return 935439;
        }
    }
} 

    

