using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Par_e_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INCIO
            int Numero;
            string Condicion = "El número es impar.";

            //PROCESO
            Console.Write("Ingrese su número: ");
            Numero = Convert.ToInt32(Console.ReadLine());

            //CONDICIÓN
            if (Numero % 2 == 0)
            {
                Condicion = "El número es par.";
            }

            //SALIDA
            Console.Write(Condicion);

            Console.ReadKey();
        }
    }
}
