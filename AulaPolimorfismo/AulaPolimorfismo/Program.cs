using System;

namespace AulaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Administrativo adm = new Administrativo();
            Tecnico tec = new Tecnico();
            adm.Nome = "Kali";
            adm.Salario = 1438.48;
            adm.NumeroMatricula = 155248;
            adm.Bonus = 562.12;
            adm.Turno = false;
            tec.Nome = "Pedro";
            tec.Salario = 1978.25;
            tec.NumeroMatricula = 125466;
            tec.Bonus = 897.15;
            //Assistente assis = Preenche();

            while (true)
            {
                Console.WriteLine("O que deseja Fazer?");
                Console.WriteLine("1- Editar");
                Console.WriteLine("2- Excluir");
                Console.WriteLine("3- Sair");
                int escolha = CR(0);

                if (escolha == 1)
                {
                    Console.WriteLine("Qual deseja editar?");
                    Console.WriteLine("1");
                    adm.ExibeDados();
                    Console.WriteLine("-----------//-----------®");
                    Console.WriteLine("2");
                    tec.ExibeDados();
                    escolha = CR(0);
                    if (escolha == 1)
                    {
                        adm = Preenche(0);
                    }
                    else
                    {
                        tec = Preenche();
                    }
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Qual deseja excluir?");
                    Console.WriteLine("1");
                    adm.ExibeDados();
                    Console.WriteLine("-----------//-----------®");
                    Console.WriteLine("2");
                    tec.ExibeDados();
                    escolha = CR(0);
                    if (escolha == 1)
                    {
                        adm = new Administrativo();
                    }
                    else
                    {
                        tec = new Tecnico();
                    }
                }
                else
                {
                    Console.WriteLine("Obrigado por usar nossos Serviços");
                    break;
                }
            }

        }
        public static Tecnico Preenche()
        {
            Console.WriteLine("Preencha os Dados");
            Tecnico tec = new Tecnico();
            tec.Nome = CR();
            tec.Salario = CR(0d);
            tec.NumeroMatricula = CR(0);
            tec.Bonus = CR(0d);
            return tec;
        }
        public static Administrativo Preenche(int administrativo)
        {
            Console.WriteLine("Preencha os dados novos");
            Administrativo adm = new Administrativo();
            adm.Nome = CR();
            adm.Salario = CR(0d);
            adm.NumeroMatricula = CR(0);
            adm.Bonus = CR(0d);
            Console.WriteLine("Qual o turno?\ndia\nnoite");
            string turno = CR();
            if (turno == "dia")
            {
                adm.Turno = true;
            }
            else
            {
                adm.Turno = false;
            }
            return adm;
        }

        /// <summary>
        /// Esta função é um resumo de Console.ReadLine()
        /// </summary>
        /// <returns></returns>
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static double CR(double j)
        {
            return double.Parse(Console.ReadLine());
        }
        public static int CR(int j)
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double CRD()
        {
            return double.Parse(Console.ReadLine());
        }

    }
}
