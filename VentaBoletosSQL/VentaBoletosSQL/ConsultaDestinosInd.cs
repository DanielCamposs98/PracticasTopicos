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

namespace VentaBoletosSQL
{
    public partial class ConsultaDestinosInd : Form
    {
        private string strCon = ConexionBD.strCon;
        public ConsultaDestinosInd()
        {
            InitializeComponent();
        }

        public void llenaCmbDestinos()
        {
            SqlConnection con = new SqlConnection(strCon);
            SqlDataReader lector;
            string strComando = "SELECT ClaveDestino FROM DESTINOS";
            SqlCommand cmd = new SqlCommand(strComando, con);

            try
            {
                con.Open();
                lector = cmd.ExecuteReader();
            }
            catch(SqlException ex)
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
                this.cmbDestinos.Items.Clear();
                while (lector.Read())
                {
                    cmbDestinos.Items.Add(lector.GetValue(0).ToString());

                }
            }
            con.Close();
        }
    
        private void cmbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            SqlDataReader lector = null;
            string clave = cmbDestinos.SelectedItem.ToString();
            string srtComando = "SELECT ClaveDestino,NombreDestino,Costo,Duracion,Habilitado FROM DESTINOS WHERE ClaveDestino="+clave;
            SqlCommand cmd = new SqlCommand(srtComando, con);

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
                while (lector.Read())
                {
                    txtNombre.Text = lector.GetValue(1).ToString();
                    txtCosto.Text = lector.GetValue(2).ToString();
                    txtDuracion.Text = lector.GetValue(3).ToString();
                    if (lector.GetValue(4).ToString().Equals("S"))
                    {
                        chkHabilitado.Checked = true;
                    }
                    else
                    {
                        chkHabilitado.Checked = false;
                    }

                }
            }
            con.Close();
            
        }
    

        private void ConsultaDestinos_Load(object sender, EventArgs e)
        {
            llenaCmbDestinos();
        }
    }
}
