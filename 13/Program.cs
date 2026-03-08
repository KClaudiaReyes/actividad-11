using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiplicar(5,6);
        }

        static void Multiplicar(int a, int b)
        {
            int result = a * b;
           Console.WriteLine("el resultado es:"+result);      
        }
    }
}
