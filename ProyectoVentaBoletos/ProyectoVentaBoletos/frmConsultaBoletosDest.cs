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
    public partial class frmConsultaBoletosDest : Form
    {

        admBoletos adminBoletos;
        admDestinos adminDestinos;
        public frmConsultaBoletosDest(admBoletos add,admDestinos add2)
        {
            adminDestinos = add2;
            adminBoletos=add;
            InitializeComponent();
            llenaComboBoxBoletos();
        }

        public void llenaComboBoxBoletos()
        {
            foreach (Destino item in adminDestinos.DicDestinos.Values)
            {
                if (cmbDestinos.Size.Equals(0)){
                    cmbDestinos.Items.Add(item);
                }
                else
                {
                    if (!cmbDestinos.Items.Contains(item))
                    {
                        cmbDestinos.Items.Add(item);
                    }
                }
                
            }
        }
        public void llenaDataDestinos()
        {
            
            Destino ds = (Destino)cmbDestinos.SelectedItem;
            foreach(Boleto bol in adminBoletos.DicBoletos.Values)
            {

                int key = (adminBoletos.DicBoletos.Where(p => p.Value == bol).FirstOrDefault().Key);
                if (ds== bol.pDestino)
                {
                    dataGdDestinos.Rows.Add(key, bol.pDestino, bol.pPasajero, bol.pAsiento, bol.pTipoBoleto);
                   
                }
            }
        }

        private void cmbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenaDataDestinos();
        }
    }
}
