using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10___Estado_Civil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //INICIO
            string Nombre, EstadoCivil;
            double Sueldo, MontoBono = 0, Impuesto = 0, Total;

            //PROCESO
            Console.Write("Ingrese el nombre del trabajador: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese el sueldo básico: S/");
            Sueldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el estado civil (casado/soltero): ");
            EstadoCivil = Console.ReadLine();

            //CONDICIÓN
            if (EstadoCivil.ToLower() == "casado")
            {
                MontoBono = Sueldo * 0.15;
            }

            if (Sueldo >= 1000)
            {
                Impuesto = Sueldo * 0.08;
            }

            //CALCULAR
            Total = Sueldo + MontoBono - Impuesto;

            //FIN
            Console.WriteLine("Nombre del trabajador: " + Nombre);
            Console.WriteLine("Sueldo básico: S/" + Sueldo);
            Console.WriteLine("Monto del bono familiar: S/" + MontoBono);
            Console.WriteLine("Monto del impuesto: S/" + Impuesto);
            Console.WriteLine("Total que recibirá el trabajador: S/" + Total);
            
            Console.ReadKey();



        }
    }
}
