using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVentaBoletos
{
    public class admDestinos
    {

        private Dictionary<int, Destino> dicDestinos = new Dictionary<int, Destino>();

        private static int cont = 0;

        //Agrega Destinos a la coleccion dicDestinos;
        public void agregarDestino(int clave, string nombre, double costo, byte duracion, bool status)
        {
            Destino d = new Destino(clave,nombre, costo, duracion, status);
            DicDestinos.Add(clave, d);
            MessageBox.Show("Destino Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

      public bool tieneDestinos()
        {
            if (dicDestinos.Count == 0)
            {
                return false;
            }
            return true;
        }
        public string generarNumBoleto()
        {
            try
            {
                cont++;
            }
            catch (FormatException)
            {
                MessageBox.Show("Limite de Boletos alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string num = Convert.ToString(cont);
            return num;
        }

        internal Dictionary<int, Destino> DicDestinos { get => dicDestinos;}
    }
}
