using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Letra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            char Letra;
            string Respuesta;

            //PROCESO
            Console.Write("Ingrese una letra: ");
            Letra = Convert.ToChar(Console.ReadLine());

            //ECM
            switch (Letra)
            {
                case 'A':
                case 'a':
                    Respuesta = "Es una vocal.";
                    break;
                case 'E':
                case 'e':
                    Respuesta = "Es una vocal.";
                    break;
                case 'I':
                case 'i':
                    Respuesta = "Es una vocal.";
                    break;
                case 'O':
                case 'o':
                    Respuesta = "Es una vocal.";
                    break;
                case 'U':
                case 'u':
                    Respuesta = "Es una vocal.";
                    break;
                default:
                    Respuesta = "Es una consonante.";
                    break;
            }

            Console.Write(Respuesta);

            Console.ReadKey();
        }
    }
}
