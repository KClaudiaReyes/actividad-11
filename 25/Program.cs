using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            bool result = EsPrimo(num);
            Console.WriteLine(result);
        }

        static bool EsPrimo(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n%i ==0)
                {
                    return false;
                }
                else
                {
                    return true;        
                }
            }
           return true;

        }
    }
}
