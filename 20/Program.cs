using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = " programacion";
        }

        static int ContarLetras(string texto)
        { 
            int cont = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                cont++;
            }
            return cont;
        }
    }
}
