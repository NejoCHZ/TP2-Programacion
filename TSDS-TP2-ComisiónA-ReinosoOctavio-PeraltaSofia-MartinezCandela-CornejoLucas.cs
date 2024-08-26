using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_programacion
{
    internal class Program
    {//variables del menu de usuario
        static int numeroVuelo;
        static int pasajesComprados;
        static decimal precioPasajes;

        static decimal prVuelo1 = 43700.00m;
        static decimal prVuelo2 = 43700.00m;
        static decimal prVuelo3 = 52000.00m;
        static decimal prVuelo4 = 52000.00m;
        static decimal prVuelo5 = 183000.00m;
        static decimal prVuelo6 = 183000.00m;
        static bool reserva = false;
        //variables registro e inicio de sesion
        static bool contienePunto = false;
        static bool contieneArroba = false;
        static string usuarioRegistrado = null;
        static string contraseñaRegistrada = null;
   
        static void Main(string[] args)
        {
            int opcionUsuario;
            bool salir = false;

            Console.WriteLine("Bienvenido");

            do
            {

                Console.WriteLine("Ingrese la opción que desee elegir: \n" +
                    "1. Ver vuelos disponibles. \n" +
                    "2. Agregar al carrito. \n" +
                    "3. Pagar pasajes \n" +
                    "4. Registrarse. \n" +
                    "5. Iniciar sesión. \n" +
                    "6. Cerrar sesión. \n" +
                    "0. Salir del sistema. \n");
                opcionUsuario = int.Parse(Console.ReadLine());


                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        salir = true;
                        break;
                    case 1:
                        VuelosDisp();
                        break;
                    case 2:
                        AgregarAlCarrito();
                        break;
                    case 3:
                        PagarPasajes();
                        break;
                    case 4:
                        Registro();
                        break;
                    case 5:
                        InicioSesion();
                        break;
                    case 6:
                        CerrarSesion();
                        break;
                    default:
                        Console.WriteLine("El numero que ingreso no es válido");
                        break;
                }

            } while (!salir);
        }
        //1
        static void VuelosDisp()
        {
            Console.WriteLine("Nro de vuelo:1. Origen: Córdoba. Destino: Buenos Aires (Ezeiza). Salida: 21:50. Llegada: 23:10. Precio: $43700,00");
            Console.WriteLine("Nro de vuelo:2. Origen: Buenos Aires (Ezeiza). Destino: Córdoba. Salida: 19:50. Llegada: 21:10. Precio: $43700,00");
            Console.WriteLine("Nro de vuelo:3. Origen: Córdoba. Destino: Mendoza. Salida: 16:45. Llegada: 17:55. Precio: $52000,00");
            Console.WriteLine("Nro de vuelo:4. Origen: Mendoza. Destino: Córdoba. Salida: 21:50. Llegada: 23:10. Precio: $52000,00");
            Console.WriteLine("Nro de vuelo:5. Origen: Córdoba. Destino: Bariloche. Salida: 21:50. Llegada: 07:35. Precio: $183000,00");
            Console.WriteLine("Nro de vuelo:6. Origen: Bariloche. Destino: Córdoba. Salida: 13:00. Llegada: 15:00. Precio: $183000,00");

        }

        //2
        static void AgregarAlCarrito()
        {

            while (true)
            {
                Console.WriteLine("Ingrese el numero de vuelo: (o presione 0 para cancelar)");
                int numVueloUsuario = int.Parse(Console.ReadLine());

                if (numVueloUsuario == 0)
                {
                    Console.WriteLine("Operación cancelada");
                    return;
                }
                if (numVueloUsuario < 1 || numVueloUsuario > 6)
                {
                    Console.WriteLine("El número de vuelo no existe, ingrese nuevamente el numero.");
                    continue;
                }

                Console.WriteLine("Cantidad de pasajes a agregar: (entre 1 y 10)");
                int cantidadPasajes = int.Parse(Console.ReadLine());

                if (cantidadPasajes < 1 || cantidadPasajes > 10)
                {
                    Console.WriteLine("Cantidad invalida. Debe ser entre 1 y 10.");
                    continue;
                }

                Console.WriteLine("Ingrese la fecha que desea viajar: (dd/mm/YYYY)");
                string fecha = Console.ReadLine();

                DateTime fechaViaje = DateTime.Parse(fecha);

                if (fechaViaje < DateTime.Today)
                {
                    Console.WriteLine("Inválido. La fecha del viaje debe ser igual o posterior al día de hoy.");
                    continue;
                }

                numeroVuelo = numVueloUsuario;
                pasajesComprados = cantidadPasajes;

                Console.WriteLine("Pasajes agregados correctamente.");

                precioPasajes = CalcularPrecio(numeroVuelo, pasajesComprados);

                reserva = true;

                break;
            }
        }

//3
        static void PagarPasajes()
        {
            if (reserva == false)
            {
                Console.WriteLine("No ha reservado ningún pasaje. Será dirigido al menú principal.");
                return;
            }

            Console.WriteLine($"Precio por {pasajesComprados} pasajes: ${precioPasajes}");
            decimal iva = precioPasajes * 1.105m;
            Console.WriteLine($"Precio total + IVA: ${iva} ");

            Console.WriteLine("Su compra ha sido realizada con éxito!. Gracias");
            reserva = false;

        }

        static decimal CalcularPrecio(int numeroVuelo, int pasajesComprados)
        {
            decimal precio = 0m;

            switch (numeroVuelo)
            {
                case 1:
                    precio = prVuelo1;
                    break;
                case 2:
                    precio = prVuelo2;
                    break;
                case 3:
                    precio = prVuelo3;
                    break;
                case 4:
                    precio = prVuelo4;
                    break;
                case 5:
                    precio = prVuelo5;
                    break;
                case 6:
                    precio = prVuelo6;
                    break;

            }
            return precio * pasajesComprados;
        }
    //4
        static void Registro()
        {   
            //verificar si contiene @ y .
            Console.WriteLine("Ingrese: correo electrónico:");
            string correo = Console.ReadLine();
            foreach (char caracter in correo)
            {
                if (caracter == '.')
                {
                    contienePunto = true;
                }
                if (caracter == '@')
                {
                    contieneArroba = true;
                }
            }

            if (contieneArroba == false)
            {
              Console.WriteLine("Correo electronico invalido, intente nuevamente");
              return;
            }
            if (contienePunto == false)
            {
              Console.WriteLine("Correo electronico invalido, intente nuevamente");
              return;
            }
            
            Console.WriteLine("Nombre completo:");
            string nombreCompleto = Console.ReadLine();
            Console.WriteLine("Numero de telefono:");
            string numeroTelefono = Console.ReadLine();
            Console.WriteLine("Numero de Documento:");
            string numeroDocumento = Console.ReadLine();
            Console.WriteLine("Nombre de usuario:");
            string nombreUsuario = Console.ReadLine();
            usuarioRegistrado = nombreUsuario;
            Console.WriteLine("Contraseña:");
            string contraseñaUsuario = Console.ReadLine();
            Console.WriteLine("Usuario registrado correctamente");
            contraseñaRegistrada = contraseñaUsuario;
        }


    //5 
        static void InicioSesion()
        {
            if (usuarioRegistrado == null)
            {
                Console.WriteLine("No hay usuarios registrados, registrese e intente nuevamente");
                return;
            }
            int contadorIntentos = 0;
            while (contadorIntentos < 3)
            {
                Console.WriteLine("Ingrese su nombre de usuario");
                string nombreIngreso = Console.ReadLine();
                Console.WriteLine("Ingrese su constraseña");
                string contraseñaIngreso = Console.ReadLine();
                if (nombreIngreso == usuarioRegistrado && contraseñaIngreso == contraseñaRegistrada)
                {
                    Console.WriteLine("Sesión iniciada");
                    return;
                }
                else
                {
                    Console.WriteLine("Usuario o contraseña incorrectos, intente nuevamente");
                    contadorIntentos++;
                }
                if (contadorIntentos == 3)
                {
                    Console.WriteLine("Excedio el numero de intentos, intente nuevamente mas tarde");
                    return;
                }
            }
        }
    //6 
        static void CerrarSesion()
        {
            if (usuarioRegistrado == null)
            {
                Console.WriteLine("No has iniciado sesion");
            }
            else
            {
                Console.WriteLine("Cerrando sesión...");            
                usuarioRegistrado = null;
                Console.Clear();
                Console.WriteLine("Sesión cerrada con exito");
            }
        }
    }
}
