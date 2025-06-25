using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9___auto_velocidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR
            double CarroV1, CarroV2, Distancia, Tiempo;

            //PROCESO
            Console.WriteLine("Ingrese la velocidad del primer auto (km/h): ");
            CarroV1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad del segundo auto (tiene que ser mayor al del primero) (km/h): ");
            CarroV2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la distancia entre el carro 1 y el carro 2 (km): ");
            Distancia = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            Tiempo = Distancia / (CarroV2 - CarroV1) * 60;

            //SALIDA
            Console.WriteLine("El tiempo en el que alcanzará el segundo auto al primero será de: " + Tiempo + " minutos."); 
        }
    }
}
