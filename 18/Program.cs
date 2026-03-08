using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 27;
        }
        static int MenorDeTRes(int a,int b,int c)
        {
            if (a < b || a < c)
            {
                return a;
            }
            else if (b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
