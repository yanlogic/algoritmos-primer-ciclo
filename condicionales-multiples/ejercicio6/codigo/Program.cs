using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6___Capital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int Tiempo;
            double Interes, CapitalInicial, CapitalFinal;
            char Profesion;

            //PROCESO
            Console.WriteLine("=======================");
            Console.WriteLine("[M] - Médico");
            Console.WriteLine("[I] - Ingeniero");
            Console.WriteLine("[D] - Docente");
            Console.WriteLine("[E] - Enfermero");
            Console.WriteLine("[P] - Militar o Policía");
            Console.WriteLine("[X] - Cualquier otro");
            Console.WriteLine("=======================");
            Console.Write("Escriba la letra correspondiente al tipo de profesión que ejerce: ");
            Profesion = Convert.ToChar(Console.ReadLine());
            Console.Write("Ingrese la cantidad de la capital inicial: ");
            CapitalInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indique el número de años que mantendrá el capital invertido: ");
            Tiempo = Convert.ToInt32(Console.ReadLine());

            //ECM
            switch (Profesion)
            {
                case 'M':
                case 'm':
                    Interes = 0.06;
                    break;

                case 'I':
                case 'i':
                    Interes = 0.08;
                    break;

                case 'D':
                case 'd':
                    Interes = 0.12;
                    break;

                case 'E':
                case 'e':
                    Interes = 0.07;
                    break;

                case 'P':
                case 'p':
                    Interes = 0.15;
                    break;

                case 'X':
                case 'x':
                    Interes = 0.10;
                    break;

                default:
                    Interes = 0;
                    break;
            }

            if (Interes == 0)
            {
                Console.WriteLine("Ingrese una letra válida.");
            }
            else
            {
                CapitalFinal = CapitalInicial * Math.Pow(1 + Interes, Tiempo);
                Console.WriteLine("Capital final: S/" + CapitalFinal);
            }

            Console.ReadKey();
        }
    }
}
