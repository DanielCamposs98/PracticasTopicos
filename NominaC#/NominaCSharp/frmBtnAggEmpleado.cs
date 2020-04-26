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
    public partial class frmBtnAggEmpleado : Form
    {
        public frmBtnAggEmpleado()
        {
            InitializeComponent();
        }

        private void TxtEnteros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TxtDouble_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtNombre.Text = null;
            txtClave.Text = null;
            txtApMat.Text = null;
            txtApPat.Text = null;
            txtDomicilio.Text = null;
            txtSueldo.Text = null;
            chkEncargado.Checked = false;
            cmbDepartamentos.SelectedIndex = 1;
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
                string strCommand = "INSERT INTO EMPLEADOS(emp_id,emp_nom,emp_apar,emp_amar,amp_dom,emp_sueldoD,departamento,emp_encargado)";
                strCommand += "VALUES (@id,@nom,@apat,@amat,@dom,@sue,@dep,@enc)";
                SqlCommand cmd = new SqlCommand(strCommand, conn);

                int id = Convert.ToInt32(txtClave.Text);
                string nom = txtNombre.Text;
                string apat = txtApPat.Text;
                string amat = txtApMat.Text;
                string dom = txtDomicilio.Text;
                decimal s = Convert.ToDecimal(txtSueldo.Text);
                decimal sue = Convert.ToDecimal(string.Format("{0:0.00}", s));
                int dep = Convert.ToInt32(cmbDepartamentos.SelectedItem);
                char enc = chkEncargado.Checked ? '1' : '0';
                int encarg = Convert.ToByte(enc);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@apat", apat);
                cmd.Parameters.AddWithValue("@amat", amat);
                cmd.Parameters.AddWithValue("@dom", dom);
                cmd.Parameters.AddWithValue("@sue", sue);
                cmd.Parameters.AddWithValue("@dep", dep);
                cmd.Parameters.AddWithValue("@enc", encarg);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ez)
                {
                    MessageBox.Show(ez.Message);
                    return;
                }
                MessageBox.Show("Empleado Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void llenaCmbDeptos()
        {
            SqlConnection con = new SqlConnection(ConexionBD.strCon);
            SqlDataReader lector;
            string strComando = "SELECT dep_nombre FROM DEPARTAMENTOS";
            SqlCommand cmd = new SqlCommand(strComando, con);

            try
            {
                con.Open();
                lector = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible conectar con la BD.");
                foreach (SqlError err in ex.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                con.Close();
                return;

            }

            if (lector.HasRows)
            {
                this.cmbDepartamentos.Items.Clear();
                while (lector.Read())
                {
                    cmbDepartamentos.Items.Add(lector.GetValue(0).ToString());
                }
            }
            con.Close();
        }

        private void frmBtnAggEmpleado_Load(object sender, EventArgs e)
        {
            llenaCmbDeptos();
        }
    }
    }
