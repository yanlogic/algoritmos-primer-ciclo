using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2___Tipo_Pago
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int Cantidad;
            double PrecioUnitario, MontoTotal, Porcentaje;
            char TipoPago;

            //PROCESO
            Console.Write("Ingrese la cantidad de productos que se compran: ");
            Cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el precio unitario del producto: S/");
            PrecioUnitario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=================");
            Console.WriteLine("[E] – Efectivo");
            Console.WriteLine("[A] – Yape o Plin");
            Console.WriteLine("[D] – Débito");
            Console.WriteLine("[C] – Crédito");
            Console.WriteLine("=================");
            Console.Write("Escriba la letra correspondiente del tipo de pago que desea utilizar: ");
            TipoPago = Convert.ToChar(Console.ReadLine());

            //ECM
            switch (TipoPago)
            {
                case 'E':
                case 'e':
                    Porcentaje = 0.10;
                    break;
                case 'A':
                case 'a':
                    Porcentaje = 0;
                    break;
                case 'D':
                case 'd':
                    Porcentaje = 0.05;
                    break;
                case 'C':
                case 'c':
                    Porcentaje = -0.07;
                    break;
                default:
                    Porcentaje = -1;
                    break;
            }

            if (Porcentaje == -1)
            {
                Console.WriteLine("Ingrese una letra válida.");
            }
            else
            {
                MontoTotal = (Cantidad * PrecioUnitario) - ((Cantidad * PrecioUnitario) * Porcentaje);
                Console.WriteLine("El monto total a pagar será de: S/" + MontoTotal);
            }
            
            Console.ReadKey();
        }
    }
}
