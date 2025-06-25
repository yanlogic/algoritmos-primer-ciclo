using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7___Tipo_Llamada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int Cantidad;
            double Monto, MontoTotal;
            char TipoLlamada;

            //PROCESO
            Console.Write("Ingrese la cantidad de minutos que se ha hablado por teléfono: ");
            Cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===================");
            Console.WriteLine("[L] - Local");
            Console.WriteLine("[N] - Nacional");
            Console.WriteLine("[I] - Internacional");
            Console.WriteLine("===================");
            Console.Write("Escriba la letra correspondiente al tipo de llamada que desea utilizar: ");
            TipoLlamada = Convert.ToChar(Console.ReadLine());
            
            //ECM
            switch (TipoLlamada)
            {
                case 'L':
                case 'l':
                    Monto = 0.75;
                    break;

                case 'N':
                case 'n':
                    Monto = 1.50;
                    break;

                case 'I':
                case 'i':
                    Monto = 4.50;
                    break;

                default:
                    Monto = 0;
                    break;
            }

            if (Monto == 0)
            {
                Console.WriteLine("Ingrese una letra válida.");
            }
            else
            {
                MontoTotal = Cantidad * Monto;
                Console.WriteLine("El monto total que debe pagar será de: S/" + MontoTotal);
            }

            Console.ReadKey();
        }
    }
}
