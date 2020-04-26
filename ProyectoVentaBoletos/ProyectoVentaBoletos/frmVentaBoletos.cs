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
    public partial class Form1 : Form
    {
        private admDestinos adminDest;
        private admBoletos adminBol;
        public Form1(admDestinos add,admBoletos adminB)
        {
            adminDest = add;
            adminBol = adminB;
            InitializeComponent();
           
            txtNumBoleto.Text = adminDest.generarNumBoleto();
            llenaComboBoxDestinos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNomPasajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {

                e.Handled = true;
                txtNomPasajero.Focus();
            }
        }
        

        private void rdNormal_CheckedChanged(object sender, EventArgs e)
        {
            rdEstudiante.Checked = false;
        }

        public bool tieneDestinos()
        {
            return adminDest.tieneDestinos();   
        }
        private void rdEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            rdNormal.Checked = false;
        }

        public void llenaComboBoxDestinos()
        {
            foreach (Destino item in adminDest.DicDestinos.Values)
            {
                Destino dest = item;
                {

                    if (item.pStatus == true)
                    {
                        cmbDestinos.Items.Add(item);
                    }

                }
            }
        }

       

        public bool validaTextBoxVacio(string texto)
        {
            bool ret = true;
            if (string.IsNullOrWhiteSpace(texto) || string.IsNullOrEmpty(texto))
            {
                return false;
            }
            return ret;
        }
        
        private void cmbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Destino i = (Destino)cmbDestinos.SelectedItem;
            try
            {

                lblClaveDest.Text = Convert.ToString(i.pClave);
                txtCosto.Text = Convert.ToString(i.pCosto);
                txtDuracion.Text = Convert.ToString(i.pDuracion);
            }
            catch (FormatException) {
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string nombre = txtNomPasajero.Text;
            if (validaTextBoxVacio(nombre))
            {
                byte asiento = Convert.ToByte(numUpAsiento.Value);
                if (validaAsiento(asiento))
                {
                    int clave = Convert.ToInt32(txtNumBoleto.Text);
                    Destino dest = (Destino) cmbDestinos.SelectedItem;
                    string pas = txtNomPasajero.Text;
                    string tip = obtieneTipo();
                    adminBol.registraBoleto(clave, dest, pas, asiento, tip);
                }
                limpiar();   
            }
            else
            {
                MessageBox.Show("No debe quedar el nombre vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            txtNomPasajero.Text = null;
            txtDuracion.Text = null;
            txtCosto.Text = null;
           
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public string obtieneTipo()
        {
            if (rdEstudiante.Checked)
            {
                return "Estudiante";
            }
            else
            {
                return "Normal";
            }
        }
            public bool validaAsiento(byte asiento)
        {
            foreach(Boleto item in adminBol.DicBoletos.Values)
            {
                if (item.pAsiento == asiento)
                {
                    return false;
                }
               
            }
            return true;
        }
    }
    }

