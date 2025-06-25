using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_8___Vehiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int Km;
            double Costo, MontoTotal;
            char TipoCarro;

            //PROCESO
            Console.Write("Ingrese la cantidad de km que recorrerá: ");
            Km = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===============");
            Console.WriteLine("[A] - Automóvil");
            Console.WriteLine("[C] - Camioneta");
            Console.WriteLine("[L] - Limusina");
            Console.WriteLine("[V] - VIP");
            Console.WriteLine("===============");
            Console.Write("Escriba la letra correspondiente al tipo de vehículo que desea utilizar: ");
            TipoCarro = Convert.ToChar(Console.ReadLine());

            //ECM
            switch (TipoCarro)
            {
                case 'A':
                case 'a':
                    Costo = 3.50;
                    break;

                case 'C':
                case 'c':
                    Costo = 6.00;
                    break;

                case 'L':
                case 'l':
                    Costo = 15.50;
                    break;

                case 'V':
                case 'v':
                    Costo = 12.50;
                    break;

                default:
                    Costo = 0;
                    break;
            }

            if (Costo == 0)
            {
                Console.WriteLine("Ingrese  una letra válida.");
            }
            else
            {
                MontoTotal = Km * Costo;
                Console.WriteLine("El monto total a cobrar será de: S /" + MontoTotal);
            }

            Console.ReadKey();
        }
    }
}
