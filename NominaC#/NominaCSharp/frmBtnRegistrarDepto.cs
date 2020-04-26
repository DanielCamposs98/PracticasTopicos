using LibreriaBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaCSharp
{
    public partial class frmBtnRegistrarDepto : Form
    {
        public frmBtnRegistrarDepto()
        {
            InitializeComponent();
        }

        private void TxtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                {
                e.Handled = true;
            }
        }
        private void TxtEnteros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtClave.Text = null;
            txtNombre.Text = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = UsoBD.ConectaBD(ConexionBD.strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible conectar con la BD");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return;

            }
            else
            {
                string strCommand = "INSERT INTO DEPARTAMENTOS(dep_id,dep_nombre)";
                strCommand += "VALUES (@id,@nom)";
                SqlCommand cmd = new SqlCommand(strCommand, conn);

                int id = Convert.ToInt32(txtClave.Text);
                string nom = txtNombre.Text;
   
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nom", nom);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ez)
                {
                    MessageBox.Show(ez.Message);
                    return;
                }
                MessageBox.Show("Departamento Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }
    }

}

