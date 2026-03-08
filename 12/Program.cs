using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Restar(2025,30);
        }
        static void Restar(int a, int b)
        {
            int resta= a-b;
            Console.WriteLine("el resultado de la resta es: "+resta);
        }
    }
}
