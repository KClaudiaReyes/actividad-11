using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostarCuadrado(4);
        }
        static void MostarCuadrado(int n)
        {
            int cuadrado= n * n;
            Console.WriteLine(" El cuadrado de "+ n+" es: " +cuadrado);

        }
    }
}
