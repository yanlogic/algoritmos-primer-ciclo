using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3___División
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int Num1, Num2;
            double Division;
            string Condicion = "Error.";

            //PROCESO
            Console.Write("Ingrese su primer número: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su segundo número: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            //CONDICIÓN
            if (Num2 != 0)
            {
                Division = (double)Num1 / Num2;
                Condicion = "El cociente es: " + Division.ToString();
            }

            //SALIDA
            Console.Write(Condicion);

            Console.ReadKey();
        }
    }
}
