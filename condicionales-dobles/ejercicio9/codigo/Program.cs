using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6___Aprobar_o_desaprobar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int C1, C2, C3;
            double Promedio;
            string Condicion;

            //PROCESO
            Console.Write("Ingrese la nota de su primera calificación: ");
            C1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la nota de su segunda calificación: ");
            C2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la nota de su tercera calificación: ");
            C3 = Convert.ToInt32(Console.ReadLine());

            //CALCULAR
            Promedio = (C1 + C2 + C3) / 3;

            //CONDICIÓN
            if (Promedio >= 11.5)
            {
                Condicion = "El alumno aprueba.";
            }
            else
            {
                Condicion = "El alumno reprueba.";
            }

            //SALIDA
            Console.WriteLine("Promedio: " + Promedio);
            Console.WriteLine(Condicion);

            Console.ReadKey();
        }
    }
}
