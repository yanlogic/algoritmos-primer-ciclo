using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___Pasaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            char TipoServicio;
            int Pasaje;
            double Precio, MontoTotal;
            string Texto;

            //PROCESO
            Console.WriteLine("===============");
            Console.WriteLine("[E] - Económico");
            Console.WriteLine("[T] - Turista");
            Console.WriteLine("[J] - Ejecutivo");
            Console.WriteLine("[V] - VIP");
            Console.WriteLine("===============");
            Console.Write("Escriba la letra correspondiente del tipo de servicio que desee adquirir: ");
            TipoServicio = Convert.ToChar(Console.ReadLine());
            Console.Write("Ingrese la cantidad de pasajes que desea comprar: ");
            Pasaje = Convert.ToInt32(Console.ReadLine());

            //ECM
            switch (TipoServicio)
            {
                case 'E':
                case 'e':
                    Precio = 55.50;
                    break;
                case 'T':
                case 't':
                    Precio = 62.75;
                    break;
                case 'J':
                case 'j':
                    Precio = 70.00;
                    break;
                case 'V':
                case 'v':
                    Precio = 100.00;
                    break;
                default:
                    Precio = 0;
                    break;
            }

            MontoTotal = Pasaje * Precio;

            if (Precio > 0)
            {
                Texto = "Precio unitario del pasaje: S/" + Precio +
                        "\nMonto total a pagar: S/" + MontoTotal;
            }
            else
            {
                Texto = "Ingrese un servicio válido.";
            }

            //SALIDA
            Console.WriteLine(Texto);

            Console.ReadKey();
        }
    }
}
