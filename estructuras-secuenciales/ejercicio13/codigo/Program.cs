using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13___Promedio_de_notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEFINIR
            double ExamenM, TareaM1, TareaM2, TareaM3;
            double ExamenF, TareaF1, TareaF2;
            double ExamenQ, TareaQ1, TareaQ2, TareaQ3;
            double PromedioTareaM, NotaExamenM, NotaTareaM, NotaFinalM;
            double PromedioTareaF, NotaExamenF, NotaTareaF, NotaFinalF;
            double PromedioTareaQ, NotaExamenQ, NotaTareaQ, NotaFinalQ;
            double PromedioGeneral;

            //PROCESO
            Console.Write("Ingrese la nota de su examen de Matemáticas: ");
            ExamenM = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota obtenida de su primera tarea de Matemáticas: ");
            TareaM1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota obtenida de su segunda tarea de Matemáticas: ");
            TareaM2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota obtenida de su tercera tarea de Matemáticas: ");
            TareaM3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota de su examen de Física: ");
            ExamenF = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota obtenida de su primera tarea de Física: ");
            TareaF1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota obtenida de su segunda tarea de Física: ");
            TareaF2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota de su examen de Química: ");
            ExamenQ = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota obtenida de su primera tarea de Química: ");
            TareaQ1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota obtenida de su segunda tarea de Química: ");
            TareaQ2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la nota obtenida de su tercera tarea de Química: ");
            TareaQ3 = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            PromedioTareaM = (TareaM1 + TareaM2 + TareaM3) / 3;
            NotaExamenM = ExamenM * 0.90;
            NotaTareaM = PromedioTareaM * 0.10;
            NotaFinalM = NotaExamenM + NotaTareaM;
            PromedioTareaF = (TareaF1 + TareaF2) / 2;
            NotaExamenF = ExamenF * 0.80;
            NotaTareaF = PromedioTareaF * 0.20;
            NotaFinalF = NotaExamenF + NotaTareaF;
            PromedioTareaQ = (TareaQ1 + TareaQ2 + TareaQ3) / 3;
            NotaExamenQ = ExamenQ * 0.85;
            NotaTareaQ = PromedioTareaQ * 0.15;
            NotaFinalQ = NotaExamenQ + NotaTareaQ;
            PromedioGeneral = (NotaFinalM + NotaFinalF + NotaFinalQ) / 3;

            //SALIDA
            Console.WriteLine("Su promedio general de las 3 materias es de: " + PromedioGeneral);
            Console.WriteLine("La nota final que obtuvo en el curso de Matemáticas es de: " + NotaFinalM);
            Console.WriteLine("La nota final que obtuvo en el curso de Física es de: " + NotaFinalF);
            Console.WriteLine("La nota final que obtuvo en el curso de Química es de: " + NotaFinalQ);
        }
    }
}
