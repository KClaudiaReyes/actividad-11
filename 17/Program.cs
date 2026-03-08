using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1= 30;
            int num2 = 25;

            int ElMay = Mayor(num1, num2);
            Console.WriteLine("cual es el numero mayor: "+ElMay);

        }

        static int Mayor(int a ,int b)
        {
            
            if (a > b)
            {
                return a;
            }
            else 
            {
                return b;
            }
        }
    }
}
