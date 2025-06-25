using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8___Clínica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double MontoDiario, Impuesto, MontoDiasExtra = 0, MontoDiasRegulares, Total;
            int DiasExtra = 0, DiasRegulares = 6, Dias;

            //PROCESO
            Console.Write("Ingrese la cantidad de días que el paciente ha estado interno: ");
            Dias = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el monto que la clínica cobra por día: S/");
            MontoDiario = Convert.ToInt32(Console.ReadLine());

            //CONDICIÓN
            if (Dias > 6)
            {
                DiasExtra = Dias - DiasRegulares;
                DiasRegulares = 6;
                MontoDiasExtra = DiasExtra * (MontoDiario * 0.90);
                MontoDiasRegulares = DiasRegulares * MontoDiario;
            }
            else
            {
                DiasExtra = 0;
                DiasRegulares = Dias;
                MontoDiasExtra = 0;
                MontoDiasRegulares = Dias * MontoDiario;
            }

            //CALCULAR
            Impuesto = (MontoDiasRegulares + MontoDiasExtra) * 0.18;
            Total = MontoDiasRegulares + MontoDiasExtra + Impuesto;

            //SALIDA
            Console.WriteLine("Cantidad de dísa regulares internos: " + DiasRegulares);
            Console.WriteLine("Cantidad de días extra: " + DiasExtra);
            Console.WriteLine("Monto por los días regulares: S/" + MontoDiasRegulares);
            Console.WriteLine("Monto por los días extra: S/" + MontoDiasExtra);
            Console.WriteLine("Impuesto a pagar (18%): S/" + Impuesto);
            Console.WriteLine("Monto total: S/" + Total);

            Console.ReadKey();
        }
    }
}
