using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVentaBoletos
{
    public class admBoletos
    {
        private Dictionary<int, Boleto> dicBoletos = new Dictionary<int, Boleto>();

       

       public void registraBoleto(int clave, Destino dest, string nomPas, byte asiento, string tipoB)
        {
            Boleto b = new Boleto(dest, nomPas, asiento, tipoB);
            DicBoletos.Add(clave, b);
            MessageBox.Show("Boleto Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        internal Dictionary<int, Boleto> DicBoletos { get => dicBoletos;  }
    }

}
