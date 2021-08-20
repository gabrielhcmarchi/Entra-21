using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt0402
{
    class Calculadora
    {
        public int Soma(int x, int y)
        {
            int resultado = x + y;
            return resultado;
        }
        public int Subtração(int x, int y)
        {
            int resultado = x - y;
            return resultado;
        }
        public double Multiplicação(double x, double y)
        {
            double resultado = x * y;
            return resultado;
        }
        public double Divisão(double x, double y)
        {
            double resultado = x / y;
            return resultado;
        }
    }
    class CalculadoraCientifica : Calculadora
    {
        public double Potenciação(double x, double y)
        {
            double resultado = Math.Pow(x, y);
            return resultado;
        }
        public double Raiz(double x)
        {
            double resultado = Math.Sqrt(x);
            return resultado;
        }
    }
}
