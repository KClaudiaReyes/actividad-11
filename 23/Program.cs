using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int resultado = SumarDel1HastaElN(n);
            Console.WriteLine("la suma de 1 hasta "+ n +" es: "  +resultado);
            
        }
        static int SumarDel1HastaElN(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma +=i;
            }
            return suma;
        }
    }
}
