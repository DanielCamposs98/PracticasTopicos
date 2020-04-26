using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaBoletosSQL
{
   public static class ConexionBD
    {
       /*Esta conexion debe cambiarse a el servidor local en donde está montada la BD.
        * Para esto debe ser ejecutado el Script SQL incluido en la carpeta de proyecto.
        * Despues, en Visual Studio abrir el Explorador de Servidores, seleccionando la opcion de 
        * SQL Server, luego seleccionar el servidor a utilizar, y seleccionar la BD de VentadeBoletos.
        *
        * En el menu que se muestra de Explorador de Servidores, abrir el apartado de Conexiones de Datos y click derecho en la conexion
        * anteriormente creada, seleccionar propiedades y en el menu que se abrio copiar la cadena de conexion. Pegar esta abajo.
        * Si marca error en los slash invertidos añadir otro
        */
        public static string strCon = "Data Source=DESKTOP-ODCAGRJ\\SQLEXPRESS;Initial Catalog=VentadeBoletos;Integrated Security=True";
    }
}
