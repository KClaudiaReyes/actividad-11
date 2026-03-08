using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dividir(90,3);
        }

        static void Dividir(double a, double b)
        {
            double result = a / b;
            Console.WriteLine(" el resultado es: "+result);
        }
    }
}
