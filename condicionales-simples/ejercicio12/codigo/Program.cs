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
            double Distancia, Velocidad, Tiempo;
            int Conductores = 1;

            //PROCESO
            Console.Write("Ingrese la distancia a recorrer (km): ");
            Distancia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la velocidad promedio a la que recorrerá el vehículo (km/h): ");
            Velocidad = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            Tiempo = Distancia / Velocidad;

            //CONDICION
            if (Tiempo > 8)
            {
                Conductores = 2;
            }

            Console.WriteLine("Tiempo estimado de viaje: " + Tiempo + " horas.");
            Console.WriteLine("Cantidad de conductores requeridos: " + Conductores);

            Console.ReadKey();
        }
    }
}
