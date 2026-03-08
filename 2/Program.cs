using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saludar();
            MostrarNombre();
            MostrarMensaje();
            Linea();
            MostrarMenu();
            MostrarNombre(" Karol");
        }

        static void Saludar ()
        {
            Console.WriteLine(" HOLA , BIENVENIDO ");
        }
        static void MostrarNombre()
        {
            string NAME = " ALEJANDRA";
            Console.WriteLine(" HOLA, " + NAME );
            
        }

        static void MostrarMensaje()
        {
            Console.WriteLine(" Programacion en C# ");
        }

        static void Linea() 
        {

            Console.WriteLine("-------------------------");
        }

        static void MostrarMenu() 
        {

            Console.WriteLine(" ____MENU______");
            Console.WriteLine(" 1. ingresar  ");
            Console.WriteLine(" 2. Mostrar ");
            Console.WriteLine(" 3. Salir ");
        }
        static void MostrarNombre(string nombre)
        {
            Console.WriteLine(" HOLA "+nombre);
        }
    }
}
