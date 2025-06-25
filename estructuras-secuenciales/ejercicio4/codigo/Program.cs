using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3___minutos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DECLARAR
            int Minutos, Horas, MinutosRestantes;

            //PROCESO
            Console.Write("Ingrese la cantidad de minutos: ");
            Minutos = Convert.ToInt32(Console.ReadLine());

            //CALCULAR
            Horas = Minutos / 60;
            MinutosRestantes = Minutos % 60;

            //SALIDA
            Console.Write("Horas y minutos correspondientes: " + Horas + " horas y " + MinutosRestantes + " minutos.");
        }
    }
}
