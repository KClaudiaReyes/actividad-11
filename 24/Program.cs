using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int result = Factorial(num);
            Console.WriteLine(" El factorial de "+num+ " es: " +result);

        }

        static int Factorial(int n)
        {
            int cont = 1;

            for (int i = 1; i <= n; i++)
            {
                cont *= i;
            }
            return cont;
        }

    }
}
