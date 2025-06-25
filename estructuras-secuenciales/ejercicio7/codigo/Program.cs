using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7___Notas_Evaluación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR
            int T1, T2, T3, EF;
            double PuntajeT1, PuntajeT2, PuntajeT3, PuntajeEF, NotaFinal;

            //PROCESO
            Console.WriteLine("Ingrese su nota de la T1: ");
            T1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su nota de la T2: ");
            T2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su nota de la T3: ");
            T3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su nota de la EF: ");
            EF = Convert.ToInt32(Console.ReadLine());

            //CALCULAR
            PuntajeT1 = T1 * 0.10;
            PuntajeT2 = T2 * 0.20;
            PuntajeT3 = T3 * 0.30;
            PuntajeEF = EF * 0.40;
            NotaFinal = PuntajeT1 + PuntajeT2 + PuntajeT3 + PuntajeEF;

            //SALIDA
            Console.WriteLine("Puntos obtenidos para la T1: " + PuntajeT1);
            Console.WriteLine("Puntos obtenidos para la T2: " + PuntajeT2);
            Console.WriteLine("Puntos obtenidos para la T3: " + PuntajeT3);
            Console.WriteLine("Puntos obtenidos para la EF: " + PuntajeEF);
            Console.WriteLine("Nota final obtenida: " + NotaFinal);
        }
    }
}
