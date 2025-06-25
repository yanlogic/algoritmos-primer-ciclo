using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12___Conductores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double Km, VelocidadPromedio, Tiempo;
            string Condicion;

            //PROCESO
            Console.Write("Ingrese la distancia a recorrer (km): ");
            Km = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la velocidad promedio que recorrerá (km/h): ");
            VelocidadPromedio = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            Tiempo = Km / VelocidadPromedio;

            //CONDICIÓN
            if (Tiempo > 8)
            {
                Condicion = "se deberán llevar 2 conductores.";
            }
            else
            {
                Condicion = "se deberá llevar 1 conductor.";
            }

            //SALIDA
            Console.WriteLine("El tiempo a recorrer será de: " + Tiempo + " horas.");
            Console.WriteLine("Por lo tanto, " + Condicion);

            Console.ReadKey();
        }
    }
}
