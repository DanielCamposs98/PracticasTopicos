using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturaAlumnos
{
    public partial class Form1 : Form
    {
        ManejaAlumno manejaAlumno = new ManejaAlumno();

        public Form1()
        {
            InitializeComponent();
            cmbCarrera.SelectedIndex = 0;
            string numControl = manejaAlumno.CalculaNC();
            txtNControl.Text = numControl;
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
        }

        public void Limpia()
        {
            cmbCarrera.SelectedIndex = 0;
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtEdad.Text = "";
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("¿Desea guardar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                if (ValidaDatos())
                {
                    string NumControl = txtNControl.Text;
                    string Nombre = txtNombre.Text.Trim();
                    string Domicilio = txtDomicilio.Text;
                    int Edad = Convert.ToInt32(txtEdad.Text);
                    string Carrera = cmbCarrera.SelectedItem.ToString().ToUpper();
                    if (manejaAlumno.existeAlumno(Nombre))
                    {
                        MessageBox.Show("El alumno " + Nombre + " ya fue registrado anteriormente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        manejaAlumno.AgregaAlumnos(Nombre, Domicilio, Carrera, Edad, NumControl);
                        MessageBox.Show("Alumno " + Nombre + " ha sido agregado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpia();
                        string numCont = manejaAlumno.CalculaNC();
                        txtNControl.Text = numCont;
                    }
                }
                else
                {
                    MessageBox.Show("No debe haber campos en blanco.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool ValidaDatos()
        {            
            bool resultado = true;
            string num = txtEdad.Text;
            string nombre = txtNombre.Text.Trim();
            string domicilio = txtDomicilio.Text;
            if (num == "")
            {
                resultado = false;
            }
            if (nombre == "")
            {
                resultado = false;
            }
            if (domicilio == "")
            {
                resultado = false;
            }
            if(cmbCarrera.SelectedItem.ToString()== "---Seleccione Carrera---")
            {
                resultado = false;
            }
            return resultado;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta(manejaAlumno);
            consulta.ShowDialog();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo sea texto lo que se introduzca.
            if(Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo sean números lo que se introduzca.
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {                
                e.Handled = true;
            }
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo sean números lo que se introduzca.
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '#')
            {
                e.Handled = false;
            }
            else
            {                
                e.Handled = true;
            }
        }
    }
}
