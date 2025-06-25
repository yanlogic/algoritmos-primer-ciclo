using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6___Calificación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double C1, C2, C3, Promedio;
            string Condicion = "El alumno reprueba.";

            //PROCESO
            Console.Write("Ingrese su primera calificación: ");
            C1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su segunda calificación: ");
            C2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su tercera calificación: ");
            C3 = Convert.ToInt32(Console.ReadLine());

            //CALCULAR
            Promedio = (C1 + C2 + C3) / 3;

            //CONDICIÓN
            if (Promedio >= 11.5)
            {
                Condicion = "El alumno aprueba.";
            }

            //SALIDA
            Console.Write(Condicion);

            Console.ReadKey();
        }
    }
}
