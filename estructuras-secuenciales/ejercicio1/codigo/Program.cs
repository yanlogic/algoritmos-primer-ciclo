using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio_1___rectángulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            double Perimetro, Altura, Base, Area;

            //SOLICITAR DATOS
            Console.WriteLine("Ingrese la base del rectángulo (metros): ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura del rectángulo (metros): ");
            Altura = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            Perimetro = 2 * (Base + Altura);
            Area = Base * Altura;

            //SALIDA
            Console.Write("El valor del perímetro del rectángulo es: " + Perimetro + (" metros"));
            Console.Write(". El valor del área del rectángulo es: " + Area + (" metros."));
        }
    }
}
