using AulaOOPt0601;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOPt0503
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, extra;
            Console.WriteLine("insira o valor do ingresso e o extra do vip");
            valor = CRD();
            extra = CRD();
            Normal norm = new Normal();
            norm.Valor = valor;
            CamaroteInferior camI = new CamaroteInferior();
            camI.Valor = valor;
            camI.ValorAdicional = extra;
            Console.WriteLine("qual a localização do camarote inferior");
            camI.Localizacao = CR();
            CamaroteSuperior camS = new CamaroteSuperior();
            camS.Valor = valor * 3;
            camS.ValorAdicional = extra * 3;
            Console.WriteLine("qual a localização do camarote superior?");
            camS.Localizacao = CR();
            Console.WriteLine("qual quer comprar?");
            Console.WriteLine("Ingresso normal");
            norm.ImprimeValor();
            Console.WriteLine("Camarote Inferior");
            camI.ImprimeValor();
            Console.WriteLine("Camarote superior");
            camS.ImprimeValor();
            CR();
            Console.WriteLine("danke");

        }
       
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static double CRD()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
