using System;
using System.Collections.Generic;

namespace AulaOOpt0402
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec03 b lista 02
            Empresa corp = new Empresa();
            List<Funcionario> temp = new List<Funcionario>();
            //List<Funcionario> temp2 = new List<Funcionario>();
            //temp2.Add(new Funcionario { Nome = "jona", Cargo = "peao", Salario = 1350.25, Conta = "15557854", Saldo = -345.33, Senha = 1337 });
            //temp2.Add(new Funcionario { Nome = "tanso", Cargo = "entregador", Salario = 1650.25, Conta = "14457854", Saldo = 480, Senha = 7331 });
            //temp2.Add(new Funcionario { Nome = "tongo", Cargo = "gerente", Salario = 3200.25, Conta = "17864889", Saldo = 1480, Senha = 8673 });
            //corp.Funcionarios = temp2;
            for (int i = 0; i < 5; i++)
            {
                PreencheFuncionario(temp);
            }
            corp.Funcionarios = temp;

            while (true)
            {
                Console.WriteLine("menu");
                Console.WriteLine("1 - aumento");
                Console.WriteLine("2 - demitir");
                Console.WriteLine("3 - fechamento");
                Console.WriteLine("4 - sair");
                int escolha = int.Parse(CR());
                if(escolha == 1)
                {
                    Console.WriteLine("escolha funcionario p aumentar");
                    for (int i = 0; i < corp.Funcionarios.Count; i++)
                    {
                        Console.WriteLine("{0} - {1}",i+1, corp.Funcionarios[i].Nome);
                    }
                    escolha = int.Parse(CR())-1;
                    Console.WriteLine("% aumento");
                    double aumento = Convert.ToDouble(CR());
                    corp.Funcionarios[escolha].Salario += (corp.Funcionarios[escolha].Salario  * (aumento / 100));
                    Console.WriteLine(corp.Funcionarios[escolha].Salario);
                    CR();
                    Console.Clear();
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("escolha funcionario demitir");
                    for (int i = 0; i < corp.Funcionarios.Count; i++)
                    {
                        Console.WriteLine("{0} - {1}", i + 1, corp.Funcionarios[i].Nome);
                    }
                    escolha = int.Parse(CR()) - 1;
                    corp.Funcionarios.RemoveAt(escolha);
                    Console.Clear();
                }
                else if (escolha == 3)
                {
                    double faturamento = 0;
                    foreach (var item in corp.Funcionarios)
                    {
                        if(item.Cargo == "peao")
                        {
                            faturamento +=4785.26; 
                        }
                        else if(item.Cargo == "entregador")
                        {
                            faturamento += 5324.82;
                        }
                        else
                        {
                            foreach (var item2 in corp.Funcionarios)
                            {
                                if (item2.Cargo != "gerente")
                                {
                                    faturamento += 2485.64;
                                }

                            }
                        }
                    }
                    corp.Saldo += faturamento;
                    for (int i = 0; i < corp.Funcionarios.Count; i++)
                    {
                        corp.Funcionarios[i].Saldo += corp.Funcionarios[i].Salario;
                        corp.Saldo -= corp.Funcionarios[i].Salario;
                        faturamento -= corp.Funcionarios[i].Salario;
                    }
                    if (faturamento < 0)
                    {
                        Console.WriteLine("zerou");
                        Console.WriteLine(faturamento);
                    }
                    else
                    {
                        Console.WriteLine("lucro");
                        Console.WriteLine(faturamento);
                    }
                    CR();
                    Console.Clear();
                }
                else if (escolha == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid operation");
                }
            }
        }
        public static void PreencheFuncionario(List<Funcionario> funcionarios)
        {
            while (true)
            {
                try
                {
                    Funcionario estagiario = new Funcionario();
                    Console.WriteLine("Informações pessoais");
                    estagiario.Nome = CR();
                    estagiario.Cargo = CR();
                    estagiario.Salario = Convert.ToDouble(CR());
                    Console.WriteLine("dados bancarios");
                    estagiario.Conta = CR();
                    estagiario.Saldo = Convert.ToDouble(CR());
                    estagiario.Senha = int.Parse(CR());
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
    }
}
