using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImprimirRepetido(" programacion",8 );
        }

        static void ImprimirRepetido(string texto, int veces)
        {
            for (int i = 0; i < veces ; i++)
            {
                Console.WriteLine(texto);
            }
        }
    }
}
