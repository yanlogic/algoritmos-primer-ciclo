using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5___promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR
            double Num1, Num2, Num3, Promedio;

            //PROCESO
            Console.WriteLine("Ingresar número 1: ");
            Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar número 2: ");
            Num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar número 3: ");
            Num3 = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            Promedio = (Num1 + Num2 + Num3) / 3;

            //SALIDA
            Console.WriteLine("El promedio es: " + Promedio);
        }
    }
}
