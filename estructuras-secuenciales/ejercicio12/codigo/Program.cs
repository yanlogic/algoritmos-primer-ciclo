using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12___Aporte_empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR
            string Nombre1, Nombre2, Nombre3;
            double Aporte1, Aporte2, Aporte3, Suma, Porcentaje1, Porcentaje2, Porcentaje3;

            //PROCESO
            Console.Write("Ingrese el nombre del primer aportante: ");
            Nombre1 = Console.ReadLine();
            Console.Write("Ingrese el monto que aporta dicha persona: ");
            Aporte1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el nombre del segundo aportante: ");
            Nombre2 = Console.ReadLine();
            Console.Write("Ingrese el monto que aporta dicha persona: ");
            Aporte2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el nombre del tercer aportante: ");
            Nombre3 = Console.ReadLine();
            Console.Write("Ingrese el monto que aporta dicha persona: ");
            Aporte3 = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            Suma = Aporte1 + Aporte2 + Aporte3;
            Porcentaje1 = (Aporte1 * 100) / Suma;
            Porcentaje2 = (Aporte2 * 100) / Suma;
            Porcentaje3 = (Aporte3 * 100) / Suma;

            //SALIDA
            Console.WriteLine("Buen día, " + Nombre1 + ". El porcentaje de participación que tiene en la empresa es de: " + Porcentaje1 + "%.");
            Console.WriteLine("Buen día, " + Nombre2 + ". El porcentaje de participación que tiene en la empresa es de: " + Porcentaje2 + "%.");
            Console.WriteLine("Buen día, " + Nombre3 + ". El porcentaje de participación que tiene en la empresa es de: " + Porcentaje3 + "%.");
        }
    }
}
