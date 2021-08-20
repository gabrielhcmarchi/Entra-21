using System;
using EnumeradoresLambda;

namespace Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("{0} : {1}",i+1, (Nomes)i);
            //}
            //Console.WriteLine("Qual nome quer escolher? ");
            //int escolha = int.Parse(Console.ReadLine());
            //escolha--;
            //Console.WriteLine("este é o nome escolhido: {0}",(Nomes)escolha);
            //string j = ((Nomes)escolha).ToString();
            ////usar convert ao invés de int.parse
            //int k = Convert.ToInt32((Nomes.Carla));
            //Console.WriteLine(k);

            //2 -- lambda

            //Func<int, int> eleva = x =>
            // {
            //     if (x <= 10)
            //     {
            //         return x * x;
            //     }
            //     else
            //     {
            //         return x;
            //     }
            // };

            //Console.WriteLine("Insira um número: ");
            //int valor = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(eleva(valor));
            //Teste(eleva(valor));

            //3

            //Console.WriteLine("Potencias possíveis: ");
            //for (int i = 1; i < 10; i++)
            //{
            //      Console.WriteLine("{0} : {1}",i+1, (Potenciais)i);
            //}
            /* Console.WriteLine("Insira o número quer quer fazer a potencia")*/

            //int escolha = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 10; i++)
            //{
            //double temp = (Potenciais.i);
            //Console.WriteLine("potencias : {0}", Math.Pow(escolha, Convert.ToInt32((Potenciais)i)));

            //}

            //Console.WriteLine("elevado a dois: {0}", Convert.ToInt32((Potenciais.segunda)));
            //Console.WriteLine("elevado a três:  {0}", Convert.ToInt32((Potenciais.terceira)));
            //Console.WriteLine("elevado a quatro:  {0}", Convert.ToInt32((Potenciais.quarta)));
            //Console.WriteLine("elevado a cinco:  {0}", Convert.ToInt32((Potenciais.quinta)));
            //Console.WriteLine("elevado a seis:  {0}", Convert.ToInt32((Potenciais.sexta)));
            //Console.WriteLine("elevado a sete:  {0}", Convert.ToInt32((Potenciais.sétima)));
            //Console.WriteLine("elevado a oito:  {0}", Convert.ToInt32((Potenciais.oitava)));
            //Console.WriteLine("elevado a nove:  {0}", Convert.ToInt32((Potenciais.nona)));
            //Console.WriteLine("elevado a dez:  {0}", Convert.ToInt32((Potenciais.décima)));

            //4

            //Type Jobs = typeof(Cargos);
            //foreach (string item in Enum.GetNames(Jobs))
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in Enum.GetValues(Jobs))
            //{
            //    Console.WriteLine(Convert.ToInt32(item));
            //}

            //-----------------------------------------------------------

            //Console.WriteLine("Escolha um cargo: ");
            //Console.WriteLine("para o cargo de {0} recebendo {1:c}, tecle 1", (Cargos.Engenheiro), Convert.ToInt32(Cargos.Engenheiro));
            //Console.WriteLine("para o cargo de {0} recebendo {1:c}, tecle 2", (Cargos.Auxiliar), Convert.ToInt32(Cargos.Auxiliar));
            //Console.WriteLine("para o cargo de {0} recebendo {1:c}, tecle 3", (Cargos.DevOps), Convert.ToInt32(Cargos.DevOps));
            //Console.WriteLine("para o cargo de {0} recebendo {1:c}, tecle 4", (Cargos.Técnico), Convert.ToInt32(Cargos.Técnico));
            //int escolha = int.Parse(Console.ReadLine());
            //if (escolha == 1)
            //{
            //    Console.WriteLine("Cargo escolhido: {0} recebendo {1:c}", (Cargos.Engenheiro), Convert.ToInt32(Cargos.Engenheiro));
            //}
            //else if (escolha == 2)
            //{
            //    Console.WriteLine("Cargo escolhido: {0} recebendo {1:c}", (Cargos.Auxiliar), Convert.ToInt32(Cargos.Auxiliar));
            //}
            //else if (escolha == 3)
            //{
            //    Console.WriteLine("Cargo escolhido: {0} recebendo {1:c}", (Cargos.DevOps), Convert.ToInt32(Cargos.DevOps));
            //}
            //else if (escolha == 4)
            //{
            //    Console.WriteLine("Cargo escolhido: {0} recebendo {1:c}", (Cargos.Técnico), Convert.ToInt32(Cargos.Técnico));
            //}
            //else
            //{
            //    Console.WriteLine("Valor não reconhecido");
            //}

        }
        public static void Teste(int x)
        {
            Console.WriteLine(x * x);
        }

    }
}
