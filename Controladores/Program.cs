using CajeroMenuC.Servicios;
using System.Net.Http.Headers;

namespace CajeroMenuC.Controladores
{
    /// <summary>
    /// Clase principal de la app
    /// 250923 - jzg
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo de entrada de la app
        /// 250923 - jzg
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {

            MenuInterfaz menuInterfaz = new MenuImplementacion();
            menuInterfaz.mostrarMendajeBienvenida();

            bool cerrarMenu = false;
            int opcionSeleccionada;

            //desde la primera iteracion debe cumplirse la condicion
            while (!cerrarMenu)
            {
                opcionSeleccionada = menuInterfaz.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);
                switch ( opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[info] - se ejecuta el caso 0");
                        cerrarMenu=true;
                        break;

                    case 1:
                        Console.WriteLine("[info] - se ejecuta el caso 1");
                        break;
                    
                    case 2:
                        Console.WriteLine("[info] - se ejecuta el caso 2");
                        break;

                    case 3:
                        Console.WriteLine("[info] - se ejecuta el caso 3");
                        break;

                    case 4:
                        Console.WriteLine("[info] - se ejecuta el caso 4");
                        break;

                    case 5:
                        Console.WriteLine("[info] - se ejecuta el caso 5");
                        break;

                    default:Console.WriteLine("[info] - la opcion deseada no existe.");
                        break;
                }

            }

        }

    }

}