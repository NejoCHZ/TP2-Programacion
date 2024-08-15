using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {//requisitos del menu
         //1Ver vuelos disponibles.
         // 2Agregar al carrito
         //3Pagar pasajes
         //4Registrarse.
         //5Iniciar Sesión.
         //6cerrar Sesión.
         //7Salir del sistema(ingreso opcion 0)
         //1
            string vueloNumero1 = "1";
            double vueloPrecio1 = 43700.00;

            string vueloNumero2 = "2";
            double vueloPrecio2 = 43700.00;

            string vueloNumero3 = "3";
            double vueloPrecio3 = 52000.00;

            string vueloNumero4 = "4";
            double vueloPrecio4 = 52000.00;

            string vueloNumero5 = "5";
            double vueloPrecio5 = 183000.00;

            string vueloNumero6 = "6";
            double vueloPrecio6 = 183000.00;
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Bienvenido al menú de opciones, ingrese el numero correspondiente a lo que necesita");
                Console.WriteLine("1.Ver vuelos disponibles.");
                Console.WriteLine("2.Agregar al carrito");
                Console.WriteLine("3.Pagar pasajes");
                Console.WriteLine("4.Registrarse");
                Console.WriteLine("5.Iniciar Sesión");
                Console.WriteLine("6.Cerrar Sesión");
                Console.WriteLine("0.Salir del sistema");
                int opcionUsuario = int.Parse(Console.ReadLine());
                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        salir = true;
                        break;
                    case 1:
                        Console.WriteLine("Vuelos Disponibles:");
                        Console.WriteLine("Nro de vuelo:1. Origen: Córdoba. Destino: Buenos Aires (Ezeiza). Salida: 21:50. Llegada: 23:10. Precio: $43700,00");
                        Console.WriteLine("Nro de vuelo:2. Origen: Buenos Aires (Ezeiza). Destino: Córdoba. Salida: 19:50. Llegada: 21:10. Precio: $43700,00");
                        Console.WriteLine("Nro de vuelo:3. Origen: Córdoba. Destino: Mendoza. Salida: 16:45. Llegada: 17:55. Precio: $52000,00");
                        Console.WriteLine("Nro de vuelo:4. Origen: Mendoza. Destino: Córdoba. Salida: 21:50. Llegada: 23:10. Precio: $52000,00");
                        Console.WriteLine("Nro de vuelo:5. Origen: Córdoba. Destino: Bariloche. Salida: 21:50. Llegada: 7:35. Precio: $183000,00");
                        Console.WriteLine("Nro de vuelo:6. Origen: Bariloche. Destino: Córdoba. Salida: 13:00. Llegada: 15:00. Precio: $183000,00");

                        continue;
                    case 2:
                        Console.WriteLine("ingrese numero de vuelo que desea agregar al carrito, si desea cancelar el proceso presione '0'");
                        int numeroDeVuelo = int.Parse(Console.ReadLine());
                        //para verificar que el vuelo sea valido, porque solo existen los vuelos del 1 al 6
                        while (numeroDeVuelo > 0 && numeroDeVuelo < 7)
                        {
                            Console.Write("Ingresa la fecha de vuelo en el formato dd/mm/YYYY: ");
                            string fecha = Console.ReadLine();
                            DateTime fechaIngresada = DateTime.Parse(fecha);
                            DateTime fechaActual = DateTime.Now;
                            if (fechaIngresada >= fechaActual)
                            {
                                Console.WriteLine("La fecha ingresada es correcta");
                            }
                            else
                            {
                                Console.WriteLine("La fecha ingresada es invalida");
                            }
                            Console.WriteLine("ingresar cantidad de pasajes");
                            int cantidadPasajes = int.Parse(Console.ReadLine());


                            
                        }
                        break;
                }

            }
        }
    }
}