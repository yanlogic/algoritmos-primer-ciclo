using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2___Femenino_y_masculino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double Monto, MontoDescuento, TotalPagar;
            string Sexo;

            //PROCESO
            Console.Write("Ingrese su sexo (femenino o masculino): ");
            Sexo = Console.ReadLine();
            Console.Write("Ingrese el monto a pagar: S/");
            Monto = Convert.ToDouble(Console.ReadLine());

            //CONDICIÓN
            if (Sexo.ToLower() == "femenino")
            {
                MontoDescuento = Monto * 0.10;
            }
            else
            {
                MontoDescuento = Monto * 0.06;
            }

            //CALCULAR
            TotalPagar = Monto - MontoDescuento;

            //SALIDA
            Console.WriteLine("El monto del descuento es: S/" + MontoDescuento);
            Console.WriteLine("El total a pagar es de: S/" + TotalPagar);

            Console.ReadKey();
        }
    }
}
