using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3___Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            char Producto, Tipo, TamanoVaso;
            double Precio = 0, Descuento = 0, MontoCompra, MontoDescuento, TotalPagar;
            int Cantidad;

            //PROCEDIMIENTO
            Console.WriteLine("==============");
            Console.WriteLine("[J] - Jugo");
            Console.WriteLine("[C] - Café");
            Console.WriteLine("[H] - Helados");
            Console.WriteLine("[P] - Postres");
            Console.WriteLine("==============");
            Console.Write("Ingrese la letra correspondiente del producto a comprar: ");
            Producto = Convert.ToChar(Console.ReadLine());

            //ECM
            switch (Producto)
            {
                //CASO JUGO
                case 'J':
                case 'j':
                    Console.WriteLine("=============");
                    Console.WriteLine("[N] - Naranja");
                    Console.WriteLine("[P] - Papaya");
                    Console.WriteLine("[F] - Fresa");
                    Console.WriteLine("[S] - Surtido");
                    Console.WriteLine("=============");
                    Console.Write("Ingrese la letra correspondiente al tipo de producto a comprar: ");
                    Tipo = Convert.ToChar(Console.ReadLine());
                    switch (Tipo)
                    {
                        //JUGO DE NARANJA
                        case 'N':
                        case 'n':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 10.00;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 8.50;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        //JUGO DE PAPAYA
                        case 'P':
                        case 'p':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 11.50;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 9.00;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        //JUGO DE FRESA
                        case 'F':
                        case 'f':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 12.00;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 10.50;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        //JUGO DE SURTIDO
                        case 'S':
                        case 's':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 13.00;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 11.00;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        default:
                            Console.WriteLine("Ingrese un tipo de producto válido.");
                            Precio = 0;
                            break;
                    }
                    break;

                //CASO CAFÉ
                case 'C':
                case 'c':
                    Console.WriteLine("=============");
                    Console.WriteLine("[A] - Americano");
                    Console.WriteLine("[P] - Pasado");
                    Console.WriteLine("[C] - Capuchino");
                    Console.WriteLine("=============");
                    Console.Write("Ingrese la letra correspondiente al tipo de producto a comprar: ");
                    Tipo = Convert.ToChar(Console.ReadLine());
                    switch (Tipo)
                    {
                        //CAFÉ AMERICANO
                        case 'A':
                        case 'a':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 8.70;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 7.00;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        //CAFÉ PASADO
                        case 'P':
                        case 'p':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 9.80;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 7.50;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        //CAFÉ CAPUCHINO
                        case 'C':
                        case 'c':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 12.50;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 10.50;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        default:
                            Console.WriteLine("Ingrese un tipo de producto válido.");
                            Precio = 0;
                            break;
                    }
                    break;

                //CASO HELADOS
                case 'H':
                case 'h':
                    Console.WriteLine("=============");
                    Console.WriteLine("[A] - Artesanal");
                    Console.WriteLine("[D] - Donofrio");
                    Console.WriteLine("[Y] - Yamboly");
                    Console.WriteLine("=============");
                    Console.Write("Ingrese la letra correspondiente al tipo de producto a comprar: ");
                    Tipo = Convert.ToChar(Console.ReadLine());
                    switch (Tipo)
                    {
                        //HELADO ARTESANAL
                        case 'A':
                        case 'a':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 19.50;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 15.00;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        //HELADO DONOFRIO
                        case 'D':
                        case 'd':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 24.50;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 20.00;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        //HELADO YAMBOLY
                        case 'Y':
                        case 'y':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del vaso que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 15.30;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 12.50;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        default:
                            Console.WriteLine("Ingrese un tipo de producto válido.");
                            Precio = 0;
                            break;
                    }
                    break;

                //CASO POSTRES
                case 'P':
                case 'p':
                    Console.WriteLine("=============");
                    Console.WriteLine("[G] - Galletas");
                    Console.WriteLine("[Q] - Queques");
                    Console.WriteLine("=============");
                    Console.Write("Ingrese la letra correspondiente al tipo de producto a comprar: ");
                    Tipo = Convert.ToChar(Console.ReadLine());
                    switch (Tipo)
                    {
                        //POSTRE - GALLETAS
                        case 'G':
                        case 'g':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del postre que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 4.50;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 7.00;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        //POSTRES - QUEQUES
                        case 'Q':
                        case 'q':
                            Console.WriteLine("=============");
                            Console.WriteLine("[G] - Grande");
                            Console.WriteLine("[M] - Mediano");
                            Console.WriteLine("=============");
                            Console.Write("Ingrese la letra correspondiente al tamaño del postre que desea comprar: ");
                            TamanoVaso = Convert.ToChar(Console.ReadLine());
                            if (TamanoVaso.ToString().ToUpper() == "G")
                            {
                                Precio = 3.50;
                            }
                            else
                            {
                                if (TamanoVaso.ToString().ToUpper() == "M")
                                {
                                    Precio = 5.20;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una letra válida.");
                                }
                            }
                            break;

                        default:
                            Console.WriteLine("Ingrese un tipo de producto válido.");
                            Precio = 0;
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Se eligió un producto inexistente.");
                    break;
            }

            if (Precio != 0)
            {
                Console.Write("Ingrese la cantidad de productos que comprará: ");
                Cantidad = Convert.ToInt32(Console.ReadLine());

                if (Cantidad > 15)
                {
                    Descuento = 0.10;
                }
                else
                {
                    if (Cantidad > 10)
                    {
                        Descuento = 0.07;
                    }
                    else
                    {
                        if (Cantidad > 5)
                        {
                            Descuento = 0.04;
                        }
                        else
                        {
                            Descuento = 0;
                        }
                    }
                }

                Console.WriteLine("Precio unitario del producto: S/" + Precio);
                Console.WriteLine("Monto de compra: S/" + (MontoCompra = Cantidad * Precio));
                Console.WriteLine("Monto del descuento: S/" + (MontoDescuento = MontoCompra * Descuento));
                Console.WriteLine("Total a pagar: S/" + (TotalPagar = MontoCompra - MontoDescuento));
            }
            else
            {
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
