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
                string vueloOrigen1 = "Córdoba";
                string vueloDestino1 = "Buenos Aires (Ezeiza)";
                string horaSalida1 = "21:50";
                string HoraLlegada1 = "23:10";
                double vueloPrecio1 = 43700.00;

                string vueloNumero2 = "2";
                string vueloOrigen2 = "Buenos Aires(Ezeiza)";
                string vueloDestino2 = "Córdoba";
                double vueloPrecio2 = 43700.00;

                string vueloNumero3 = "3";
                string vueloOrigen3 = "Córdoba";
                string vueloDestino3 = "Mendoza";
                string horaSalida3 = "16:45";
                string HoraLlegada3 = "17:55";
                double vueloPrecio3 = 52000.00;

                string vueloNumero4 = "4";
                string vuelorigen4 = "Mendoza";
                string vueloDestino4 = "Córdoba";
                string horaSalida4 = "21:50";
                string HoraLlegada4 = "23:10";
                double vueloPrecio4 = 52000.00;

                string vueloNumero5 = "5";
                string vueloOrigen5 = "Córdoba";
                string vueloDestino5 = "Bariloche";
                string horaSalida5 = "21:50";
                string horaLlegada5 = "7:35";
                double vueloPrecio5 = 183000.00;

                string vueloNumero6 = "6";
                string vueloOrigen6 = "Bariloche";
                string vueloDestino6 = "Córdoba"; 
                string horaSalida6 = "13:00";
                string horaLlegada6 = "15:00";
                double vueloPrecio6 = 183000.00;



                bool salir = false;

                while (!salir)
                {
                    switch (opcionUsuario)
                    {
                        case 0:
                            Console.WriteLine("Saliendo del sistema...");
                            salir = true;
                            break;
                        case 1:
                        Console.WriteLine("Vuelos Disponibles:" +
                            "Nro de vuelo:1. Origen: Córdoba. Destino: Buenos Aires (Ezeiza). Salida: 21:50. Llegada: 23:10. Precio: $43700,00"+
                            "Nro de vuelo:2. Origen: Buenos Aires (Ezeiza). Destino: Córdoba. Salida: 19:50. Llegada: 21:10. Precio: $43700,00"+
                            "Nro de vuelo:3. Origen: Córdoba. Destino: Mendoza. Salida: 21:50. Llegada: 23:10. Precio: $43700,00" +
                            "Nro de vuelo:4. Origen: Córdoba. Destino: Buenos Aires (Ezeiza). Salida: 21:50. Llegada: 23:10. Precio: $43700,00" +



                            break;
                        case 2:
                        Console.WriteLine("ingrese numero de vuelo");
                        int numeroDeVuelo = int.Parse(Console.ReadLine()); 

                            while (numeroDeVuelo > 0 && numeroDeVuelo < 6)
                            {
                               
                                Console.WriteLine("ingresar la fecha del vuelo");
                                int fechaViaje = int.Parse(Console.ReadLine());
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
            static void mostrarVuelos()
            {

            }


        }

    }
    }
}
