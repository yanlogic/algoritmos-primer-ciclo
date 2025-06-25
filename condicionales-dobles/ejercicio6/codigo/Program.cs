using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3___AFP_ONP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double SueldoPagar, Descuento, Total;
            string Nombre, SistemaPension;
            int CantidadHijos, Bonificacion = 0;

            //PROCESO
            Console.Write("Ingrese el nombre del trabajador: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese el tipo de sistema de pensión (AFP/ONP): ");
            SistemaPension = Console.ReadLine();
            Console.Write("Ingrese el sueldo a pagar: S/");
            SueldoPagar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la cantidad de hijos: ");
            CantidadHijos = Convert.ToInt32(Console.ReadLine());


            //CONDICIÓN
            if (SistemaPension.ToUpper() == "AFP")
            {
                Descuento = SueldoPagar * 0.12;
            }
            else
            {
                Descuento = SueldoPagar * 0.08;
            }

            if (CantidadHijos > 0)
            {
                Bonificacion = 200;
            }
            else
            {
                Bonificacion = 0;
            }

            //CALCULAR
            Total = (SueldoPagar - Descuento) + Bonificacion;

            //SALIDA
            Console.WriteLine("El sistema de pensión al que pertenece: " + SistemaPension);
            Console.WriteLine("El descuento que le pertenece: S/" + Descuento);
            Console.WriteLine("Su bonificación es la siguiente: S/" + Bonificacion);
            Console.WriteLine("El total que recibirá será de: S/" + Total);

            Console.ReadKey();
        }
    }
}
