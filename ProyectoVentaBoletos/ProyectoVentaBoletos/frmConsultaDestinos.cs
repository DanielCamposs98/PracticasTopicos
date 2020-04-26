using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVentaBoletos
{
    public partial class frmConsultaDestinos : Form
    {
        admDestinos adminDestinos;
        public frmConsultaDestinos(admDestinos adda)
        {

            InitializeComponent();
            adminDestinos = adda;

        }


        public void llenaDataDestinos()
        {


            foreach (Destino d in adminDestinos.DicDestinos.Values)
            {

                int key = (adminDestinos.DicDestinos.Where(p => p.Value == d).FirstOrDefault().Key);
                string est = validaEstado(d.pStatus);
                dataGdDestinos.Rows.Add(d.pClave, d.pNombre, d.pCosto, d.pDuracion, est);


            }
        }

        public string validaEstado(bool est)
        {
            return "Activo";

        }

        private void frmConsultaDestinos_Load(object sender, EventArgs e)
        {
            llenaDataDestinos();
        }
    }
}

