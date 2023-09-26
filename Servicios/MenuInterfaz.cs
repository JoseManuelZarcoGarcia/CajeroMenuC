using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CajeroMenuC.Servicios
{

    /// <summary>
    /// Interfaz con la relacion de metodos e la funcionalidad del menu.
    /// 250923 - jzg
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra mensaje de bienvenida al cajero.
        /// </summary>
        public void mostrarMendajeBienvenida();

        public int mostrarMenuYSeleccion();

    }
}
