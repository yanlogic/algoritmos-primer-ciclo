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
            int Dias, DiasRegulares = 6, DiasExtra = 0;
            double MontoDiario, MontoDiasRegulares, MontoDiasExtra = 0, Impuesto, Total;

            //PROCESO
            Console.Write("Ingrese la cantidad de días que el paciente estuvo internado: ");
            Dias = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el monto que cobra la clínica por día: S/");
            MontoDiario = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            DiasRegulares = Dias;
            MontoDiasRegulares = Dias * MontoDiario;

            //CONDICION
            if (Dias > 6)
            {
                DiasRegulares = 6;
                DiasExtra = Dias - DiasRegulares;
                MontoDiasExtra = DiasExtra * (MontoDiario * 0.90);
                MontoDiasRegulares = DiasRegulares * MontoDiario;
            }

            //CALCULAR
            Impuesto = (MontoDiasRegulares + MontoDiasExtra) * 0.18;
            Total = MontoDiasRegulares + MontoDiasExtra + Impuesto;

            //SALIDA
            Console.WriteLine("Cantidad de días regulares internos: " + DiasRegulares);
            Console.WriteLine("Cantidad de días extra: " + DiasExtra);
            Console.WriteLine("Monto por los días regulares: S/" + MontoDiasRegulares);
            Console.WriteLine("Monto por los días extra: S/" + MontoDiasExtra);
            Console.WriteLine("Impuesto a pagar (18%): S/" + Impuesto);
            Console.WriteLine("Monto total: S/" + Total);

            Console.ReadKey();
        }
    }
}
