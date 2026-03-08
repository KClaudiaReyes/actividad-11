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

            Console.WriteLine("es multiplo?" + EsMultiplo(15,4));
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
