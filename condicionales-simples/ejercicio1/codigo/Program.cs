using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___Número_mayor_y_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int Num1, Num2;
            string Condicion = "El primer número es mayor.";

            //PROCESO
            Console.Write("Ingrese su primer número: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su segundo número: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            //CONDICIÓN
            if (Num1 < Num2)
            {
                Condicion = "El segundo número es mayor.";
            }

            //FIN
            Console.Write(Condicion);

            Console.ReadKey();
        }
    }
}
