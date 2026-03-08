using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "ingenieria ";
            int TotalVoacal= ContarVocales(text);

            Console.WriteLine("la palabra: "+text+" tiene " +TotalVoacal+" vocales en total ");

        }

        static int ContarVocales(string texto) 
        {
         int cont = 0;
            string vocal = texto.ToLower();
            for (int i = 0; i < vocal.Length; i++)
            {
                char letra= vocal[i];

                if (letra == 'a' || letra == 'e' || letra == 'i' || letra== 'o'|| letra == 'u')
                {
                    cont++;
                }

            }
            return cont;
        }

    }
}
