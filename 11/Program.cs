using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sumar(1995,30);
        }

        static void sumar(int a,int b)
        {
            int suma = a + b;
            Console.WriteLine("el resultado es: "+suma);
        }
    }
}
