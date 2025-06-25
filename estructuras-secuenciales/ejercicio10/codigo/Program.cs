using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10___ciclista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR
            int HH, MM, SS, Tiempo, TiempoSalida, TiempoLlegada, HHLlegada, MMLlegada, SSLlegada, SegundosRestantes;

            //PROCESO
            Console.WriteLine("Ingrese la hora de salida: ");
            HH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el minuto de salida: ");
            MM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo de salida: ");
            SS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo de viaje en segundos: ");
            Tiempo = Convert.ToInt32(Console.ReadLine());

            //CALCULAR
            TiempoSalida = (HH * 3600) + (MM * 60) + SS;
            TiempoLlegada = TiempoSalida + Tiempo;
            HHLlegada = (TiempoLlegada / 3600) % 24;
            SegundosRestantes = TiempoLlegada % 3600;
            MMLlegada = SegundosRestantes / 60;
            SSLlegada = TiempoLlegada % 60;

            //SALIDA
            Console.WriteLine("La hora de llegada a la ciudad B es: " + HHLlegada + " horas, " + MMLlegada + " minutos, " + SSLlegada + " segundos.");
        }
    }
}
