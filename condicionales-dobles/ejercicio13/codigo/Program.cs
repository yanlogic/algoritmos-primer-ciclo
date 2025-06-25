using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10___Planilla_empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double SueldoBasico, BonoFamiliar = 0, Impuesto = 0, TotalPagar;
            string Nombre, EstadoCivil;

            //PROCESO
            Console.Write("Ingrese el nombre del trabajador: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese el sueldo básico: S/");
            SueldoBasico = Convert.ToDouble(Console.ReadLine());
            Console.Write("Estado civil: ");
            EstadoCivil = Console.ReadLine();

            //CONDICIÓN
            if (EstadoCivil.ToLower() == "casado")
            {
                BonoFamiliar = SueldoBasico * 0.15;
            }
            else
            {
                BonoFamiliar = 0;
            }

            if (SueldoBasico >= 1000)
            {
                Impuesto = SueldoBasico * 0.08;
            }
            else
            {
                Impuesto = 0;
            }

            //CALCULAR
            TotalPagar = SueldoBasico + BonoFamiliar - Impuesto;

            //SALIDA
            Console.WriteLine("Nombre del trabajador: " + Nombre);
            Console.WriteLine("Sueldo básico es: S/" + SueldoBasico);
            Console.WriteLine("Monto del bono familiar: S/" + BonoFamiliar);
            Console.WriteLine("Total que recibirá el trabajador: S/" + TotalPagar);

            Console.ReadKey();
        }
    }
}
