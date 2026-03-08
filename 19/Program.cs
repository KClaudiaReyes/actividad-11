using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 30;
            int num2 = 4;
            bool multiplo = EsMultiplo(num1,num2);
            Console.WriteLine("es multiplo " + num1+ " de  "+num2+"  " + multiplo);
        }

        static bool EsMultiplo(int n , int m)
        {
            if( n % m == 0)
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
