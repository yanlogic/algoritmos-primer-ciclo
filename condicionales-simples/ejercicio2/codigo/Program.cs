using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2___Contraseña
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            string PasswordGuardada, PasswordUsuario, Condicion = "La contraseña es incorrecta.";

            //PROCESO
            Console.Write("Introduzca la contraseña: ");
            PasswordGuardada = Console.ReadLine();
            Console.Write("Introduzca nuevamente la contraseña: ");
            PasswordUsuario = Console.ReadLine();

            //CONDICIÓN
            if (PasswordUsuario == PasswordGuardada)
            {
                Condicion = "La contraseña es correcta.";
            }

            //SALIDA
            Console.Write(Condicion); 

            Console.ReadKey();
        }
    }
}
