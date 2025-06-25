using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5___Pago
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int Cantidad;
            double PagoHora, MontoPagar;
            char Cargo;

            //PROCESO
            Console.WriteLine("================");
            Console.WriteLine("[G] - Gerente");
            Console.WriteLine("[A] - Asistente");
            Console.WriteLine("[S] - Supervisor");
            Console.WriteLine("[J] - Jefe");
            Console.WriteLine("[E] - Empleado");
            Console.WriteLine("================");
            Console.Write("Escriba la letra correspondiente del tipo de cargo que tiene: ");
            Cargo = Convert.ToChar(Console.ReadLine());
            Console.Write("Ingrese la cantidad de horas que trabaja: ");
            Cantidad = Convert.ToInt32(Console.ReadLine());

            //ECM
            switch (Cargo)
            {
                case 'G':
                case 'g':
                    PagoHora = 125.50;
                    break;

                case 'A':
                case 'a':
                    PagoHora = 95.75;
                    break;

                case 'S':
                case 's':
                    PagoHora = 70.25;
                    break;

                case 'J':
                case 'j':
                    PagoHora = 50.00;
                    break;

                case 'E':
                case 'e':
                    PagoHora = 40.00;
                    break;

                default:
                    PagoHora = 0;
                    break;
            }

            if (PagoHora == 0)
            {
                Console.WriteLine("Ingrese una letra válida primero.");
            }
            else
            {
                MontoPagar = Cantidad * PagoHora;
                Console.WriteLine("El monto total a pagar será de: S/" + MontoPagar);
            }

            Console.ReadKey();
        }
    }
}
