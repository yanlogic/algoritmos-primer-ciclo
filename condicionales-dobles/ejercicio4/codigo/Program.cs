using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___Obrero_o_administrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            string TipoCargo, Condicion;
            double Sueldo = 0, MontoHorasRegulares = 0, MontoHorasExtra = 0;
            int HorasObrero, HorasRegulares = 0, HorasExtra = 0;

            //PROCESO
            Console.Write("Ingrese el cargo que tiene (obrero o administrador): ");
            TipoCargo = Console.ReadLine();

            //CONDICIÓN
            if (TipoCargo.ToLower() == "administrador")
            {
                Sueldo = 2500;
                Condicion = "Buen día. Su sueldo mensual es de: S/" + Sueldo;
            }
            else
            {
                Console.Write("Ingrese las horas que trabaja a la semana: ");
                HorasObrero = Convert.ToInt32(Console.ReadLine());

                if (HorasObrero > 40)
                {
                    HorasRegulares = 40;
                    HorasExtra = HorasObrero - HorasRegulares;
                    MontoHorasRegulares = HorasRegulares * 40;
                    MontoHorasExtra = HorasExtra * (40 * 2);
                }
                else
                {
                    HorasRegulares = HorasObrero;
                    HorasExtra = 0;
                    MontoHorasRegulares = HorasObrero * 40;
                    MontoHorasExtra = 0;
                }

                Sueldo = MontoHorasRegulares + MontoHorasExtra;
                Condicion = "Cantidad de horas regulares trabajadas: " + HorasRegulares + " horas \n" +
                            "Cantidad de horas extras: " + HorasExtra + " horas \n" +
                            "Monto a pagar por horas regulares: S/" + MontoHorasRegulares + "\n" +
                            "Monto a pagar por horas extras: S/" + MontoHorasExtra + "\n" +
                            "Total a recibir: S/" + Sueldo;
            }

            //SALIDA
            Console.Write(Condicion);

            Console.ReadKey();
        }
    }
}
