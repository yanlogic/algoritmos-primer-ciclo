using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3___Operaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int Num1, Num2;
            double Resultado;
            char Operacion;

            //PROCESO
            Console.Write("Ingrese su primer número: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su segundo número: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("====================");
            Console.WriteLine("[S] - Suma");
            Console.WriteLine("[R] - Resta");
            Console.WriteLine("[M] - Multiplicación");
            Console.WriteLine("[D] - División");
            Console.WriteLine("====================");
            Console.Write("Seleccione la operación que desee realizar: ");
            Operacion = Convert.ToChar(Console.ReadLine());

            //ECM
            if (Num1 != 0 && Num2 != 0)
            {
                switch (Operacion)
                {
                    case 'S':
                    case 's':
                        Resultado = Num1 + Num2;
                        Console.Write("El resultado de la suma es: " + Resultado);
                        break;
                    case 'R':
                    case 'r':
                        Resultado = Num1 - Num2;
                        Console.Write("El resultado de la resta es: " + Resultado);
                        break;
                    case 'M':
                    case 'm':
                        Resultado = Num1 * Num2;
                        Console.Write("El resultado de la multiplicación es: " + Resultado);
                        break;
                    case 'D':
                    case 'd':
                        Resultado = Num1 / Num2;
                        Console.Write("El resultado de la división es: " + Resultado);
                        break;
                    default:
                        Console.Write("Ingrese una letra válida.");
                        break;
                }
            }
            else
            {
                Console.Write("Error. Ambos números deben ser diferentes a 0.");
            }

            Console.ReadKey();
        }
    }
}
