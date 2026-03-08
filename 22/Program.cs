using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultado = Repetir("ingenieria",5);
            Console.WriteLine(resultado);
        }
        static string Repetir(string texto,int veces)
        {
            string cont = " ";

            for (int i=0; i < veces; i++)
            {
                cont += texto + " ";
            }
            return cont;
        }
    }
}
