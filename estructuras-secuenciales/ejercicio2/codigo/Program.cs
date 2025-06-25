using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2___grados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DECLARAR VARIABLES
            double GF, GC;

            //PROCESO
            Console.Write("Ingresar los Grados Fahrenheit que desee convertir a Grados Celsius: ");
            GF = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            GC = (GF - 32) * 5 / 9;

            //SALIDA
            Console.Write("Los Grados Celsius son: " + GC);
        }
    }
}
