using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Porgramacion
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
                { Console.WriteLine("Bienvenido al menú de opciones, ingrese el numero correspondiente a lo que necesita" +
                    "1.Ver vuelos disponibles." +
                    "2.Agregar al carrito" +
                    "3.Pagar pasajes" +
                    "4.Registrarse" +
                    "5.Iniciar Sesión." +
                    "6.Cerrar Sesión" +
                    "0.Salir del sistema");
               int opcionUsuario = int.Parse (Console.ReadLine());
                    switch (opcionUsuario)
                    {
                        case 0:
                            Console.WriteLine("Saliendo del sistema...");
                            salir = true;
                            break;
                        case 1:
                        Console.WriteLine("Vuelos Disponibles:" +
                            "Nro de vuelo:1. Origen: Córdoba. Destino: Buenos Aires (Ezeiza). Salida: 21:50. Llegada: 23:10. Precio: $43700,00" +
                            "Nro de vuelo:2. Origen: Buenos Aires (Ezeiza). Destino: Córdoba. Salida: 19:50. Llegada: 21:10. Precio: $43700,00" +
                            "Nro de vuelo:3. Origen: Córdoba. Destino: Mendoza. Salida: 16:45. Llegada: 17:55. Precio: $52000,00" +
                            "Nro de vuelo:4. Origen: Mendoza. Destino: Córdoba. Salida: 21:50. Llegada: 23:10. Precio: $52000,00" +
                            "Nro de vuelo:5. Origen: Córdoba. Destino: Bariloche. Salida: 21:50. Llegada: 7:35. Precio: $183000,00" +
                            "Nro de vuelo:6. Origen: Bariloche. Destino: Córdoba. Salida: 13:00. Llegada: 15:00. Precio: $183000,00");

                            continue;
                        case 2:
                        Console.WriteLine("ingrese numero de vuelo que desea");
                        int numeroDeVuelo = int.Parse(Console.ReadLine()); 

                            while (numeroDeVuelo > 0 && numeroDeVuelo < 6)
                            {
                               
                                Console.WriteLine("ingresar la fecha del vuelo");
                                int fechaViaje = int.Parse(Console.ReadLine());
                            Console.Write("Ingresa una fecha en el formato dd/mm/YYYY: ");
                            string fecha = Console.ReadLine();
                            DateTime fechaIngresada = DateTime.Parse(fecha);
                            DateTime fechaActual = DateTime.Now;
                            if (fechaIngresada > fechaActual)
                            {
                                Console.WriteLine("La fecha ingresada es mayor a la actual");
                            }
                            else
                            {
                                Console.WriteLine("La fecha ingresada es menor a la actual");
                            }
                            Console.WriteLine("ingresar cantidad de pasajes");
                                int cantidadPasajes = int.Parse(Console.ReadLine());


                            }


                            break;
                        case 3:
                            Console.WriteLine
                    break;
                        case 4:
                            Console.WriteLine
                    break;
                        case 5:
                            Console.WriteLine
                    break;
                        case 6:
                            Console.WriteLine
                    break;
                        default;
                            Console.WriteLine("Numero incorrecto");
                            break;
                    }
                }

          }
    }
    

    
    

