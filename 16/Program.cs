using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" El numero es positivo ? "+EsPositivo(-5));
        }

        static bool EsPositivo(int n)
        {
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
