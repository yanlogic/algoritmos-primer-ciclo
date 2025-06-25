using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8___número_invertido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR
            int Numero, N1, N2;

            //PROCESO
            Console.WriteLine("Inserte un número de 2 cifras del 10 al 99: ");
            Numero = Convert.ToInt32(Console.ReadLine());

            //CALCULAR
            N1 = Numero % 10;
            N2 = Numero / 10;

            //SALIDA
            Console.WriteLine("El número invertido es el siguiente: " + N1 + N2);
        }
    }
}
