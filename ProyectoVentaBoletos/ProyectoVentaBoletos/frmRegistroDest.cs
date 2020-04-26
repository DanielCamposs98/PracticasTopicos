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
    public partial class frmRegistroDest : Form
    {
        private admDestinos admDest;

        //Constructor.
        public frmRegistroDest(admDestinos add)
        {
            InitializeComponent();
            admDest = add;
            
        }

        //Evento para cuando se presione el botón "Limpiar".
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        //Limpia los TextBox y el CheckBox.
        public void limpiar()
        {
            this.txtClave.Text = "";
            this.txtCosto.Text = "";
            this.txtNombre.Text = "";
            this.chkHabilitado.Checked = false;
        }

        //Evento para cuando se presione el botón "Guardar".
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("¿Desea guardar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {

                if (validaDatos())
                {
                    int clave = Convert.ToInt32(txtClave.Text);
                    
                    if (!validaClaveDuplicada())
                    {
                        if (validaCosto())
                        {
                            string nombre = txtNombre.Text;
                            double costo = Convert.ToDouble(txtCosto.Text);
                            byte duracion = Convert.ToByte(numUpDuracion.Text);
                            bool status = this.chkHabilitado.Checked;
                            admDest.agregarDestino(clave, nombre, costo, duracion, status);
                        }
                    }
                }

            }
            limpiar();
        }

        //Valida TextBoxVacios
        public bool validaTextBoxVacio(string texto)
        {
            bool ret = true;
            if(string.IsNullOrWhiteSpace(texto)|| string.IsNullOrEmpty(texto))
            {
                return false;
            }
            return ret;
        }
        

        //Imprime MessageBox avisando que el destino está habiltado.
        private void chkHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            bool status = this.chkHabilitado.Checked;
            if (status == true)
            {
                DialogResult re = MessageBox.Show("Destino Habilitado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Valida que los TextBox no estén vacíos.
        private bool validaDatos()
        {
            if ((this.txtClave.Text == "") || (this.txtCosto.Text == "") || (this.txtNombre.Text == ""))
            {
                MessageBox.Show("No dejar espacios en blanco.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //Valida que el costo sea convertible a Double.
        public bool validaCosto()
        {

            try
            {
                double costo = Convert.ToDouble(txtCosto.Text);
            }
            catch (FormatException)
            {
                return false;
            }

            if (Convert.ToDouble(txtCosto.Text) <= 0)
            {
                return false;
            }

            return true;
        }

        //Cierra la ventana
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //Valida la clave con solo numeros.
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                txtClave.Focus();
            }

        }

        private bool validaClaveDuplicada()
        {
            int clave = Convert.ToInt32(txtClave.Text);
            try
            {
                if (admDest.DicDestinos.ContainsKey(clave))
                {
                    MessageBox.Show("Clave Duplicada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en conversion de Clave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        //Valida que el nombre sea solo Letras y espacios.
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {

                e.Handled = true;
                txtNombre.Focus();
            }

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Contains('.'))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
        }

        private void txtClave_Validated(object sender, EventArgs e)
        {
            string cadena = txtClave.Text;

            if (!validaTextBoxVacio(cadena))
            {
                errRegDest.SetError(txtClave, "Clave Vacía");
            }

        }
        private void txtNombre_Validated(object sender, EventArgs e)
        {

            string cadena = txtNombre.Text;

            if (!validaTextBoxVacio(cadena))
            {
                errRegDest.SetError(txtNombre, "Nombre Vacío");
            }
        }

        private void txtCosto_Validated(object sender, EventArgs e)
        {
            string cadena = txtCosto.Text;
            if (!validaTextBoxVacio(cadena))
            {
                errRegDest.SetError(txtCosto, "Costo vacío");
            }
        }
    }
}
