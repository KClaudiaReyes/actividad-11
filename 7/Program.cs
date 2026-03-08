using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarDoble(10);
        }
        static void MostrarDoble(int n )
        {
            int total = n * 2;
            Console.WriteLine( "El doble de "+ n +" es igual a "+total);
        }

    }
}
