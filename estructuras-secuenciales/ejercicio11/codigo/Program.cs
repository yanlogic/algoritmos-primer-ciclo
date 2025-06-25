using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11___hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR
            double Presupuesto, GinecologíaP, PediatriaP, TraumatologiaP;

            //PROCESO
            Console.WriteLine("Ingrese el presupuesto que se asignará de forma anual al hospital: ");
            Presupuesto = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            GinecologíaP = Presupuesto * 0.40;
            PediatriaP = Presupuesto * 0.30;
            TraumatologiaP = Presupuesto * 0.30;

            //SALIDA
            Console.WriteLine("El área de Ginecología recibirá: S/" + GinecologíaP);
            Console.WriteLine("El área de Pediatría recibirá: S/" + PediatriaP);
            Console.WriteLine("El área de Traumatología recibirá: S/" + TraumatologiaP);       }
    }
}
