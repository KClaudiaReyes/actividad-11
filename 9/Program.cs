using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumarMostrar(5,25);
        }

        static void SumarMostrar(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine("el resultado de sumar A:"+a+ " + " +"B:"+ b+" es: " +resultado);
        }
    }
}
