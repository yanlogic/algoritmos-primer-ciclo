using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajador_Descuento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double Sueldo, Descuento = 0, SueldoNeto, Adicional = 0;

            //PROCESO
            Console.Write("Ingrese su sueldo: S/");
            Sueldo = Convert.ToDouble(Console.ReadLine());

            //CONDICIÓN
            if (Sueldo <= 1000)
            {
                Descuento = Sueldo * 0.10;
            }
            else
            {
                 if (Sueldo > 1000 && Sueldo <= 2000)
                {
                    Adicional = Sueldo - 1000;
                    Descuento = (Adicional * 0.05) + (1000 * 0.10);
                }
                else
                {
                    if (Sueldo > 2000)
                    {
                        Adicional = Sueldo - 2000;
                        Descuento = (Adicional * 0.03) + (1000 * 0.05) + (1000 * 0.10);
                    }
                }
            }

            SueldoNeto = Sueldo - Descuento;

            //SALIDA
            Console.WriteLine("El descuento es de: S/" + Descuento);
            Console.WriteLine("El sueldo neto del trabajador es el siguiente: S/" + SueldoNeto);

            Console.ReadKey();
        }
    }
}
