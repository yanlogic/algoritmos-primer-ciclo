using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9___Mensualidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int Ciclo;
            double Mensualidad = 0, MontoDescuento = 0, TotalPagar;
            char Carrera;

            //PROCESO
            Console.WriteLine("=======================");
            Console.WriteLine("[I] - Ingeniería");
            Console.WriteLine("[P] - Psicología");
            Console.WriteLine("[M] - Medicina");
            Console.WriteLine("=======================");
            Console.Write("Escriba la letra correspondiente de la carrera que cursa: ");
            Carrera = Convert.ToChar(Console.ReadLine());
            Console.Write("Ingrese el ciclo en el que se encuentra: ");
            Ciclo = Convert.ToInt32(Console.ReadLine());

            //ECM
            if (Ciclo > 10 || Ciclo < 1)
            {
                Console.Write("Ingrese un ciclo válido del 1 al 10");
            }
            else
            {
                switch (Carrera)
                {
                    case 'I':
                    case 'i':
                        Mensualidad = 800.00;
                        if (Ciclo >= 1 && Ciclo <= 5)
                        {
                            MontoDescuento = Mensualidad * 0.20;
                        }
                        else
                        {
                            if (Ciclo >= 6 && Ciclo <= 10)
                                MontoDescuento = Mensualidad * 0.10;
                        }
                        break;

                    case 'P':
                    case 'p':
                        Mensualidad = 950.00;
                        if (Ciclo >= 1 && Ciclo <= 5)
                        {
                            MontoDescuento = Mensualidad * 0.17;
                        }
                        else
                        {
                            if (Ciclo >= 6 && Ciclo <= 10)
                                MontoDescuento = Mensualidad * 0.08;
                        }
                        break;

                    case 'M':
                    case 'm':
                        Mensualidad = 1500.00;
                        if (Ciclo >= 1 && Ciclo <= 5)
                        {
                            MontoDescuento = Mensualidad * 0.15;
                        }
                        else
                        {
                            if (Ciclo >= 6 && Ciclo <= 10)
                                MontoDescuento = Mensualidad * 0.05;
                        }
                        break;

                    default:
                        Mensualidad = 0;
                        break;
                }
            }

            if (Mensualidad == 0)
            {
                Console.Write("Ingrese una letra válida.");
            }
            else
            {
                TotalPagar = Mensualidad - MontoDescuento;
                Console.WriteLine("Monto mensualidad: S/" + Mensualidad);
                Console.WriteLine("Monto del descuento: S/" + MontoDescuento);
                Console.WriteLine("Total a pagar: S/" + TotalPagar);
            }

            Console.ReadKey();
        }
    }
}
