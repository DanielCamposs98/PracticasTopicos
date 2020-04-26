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
    public partial class ConsultaBoletosInd : Form
    {
        public ConsultaBoletosInd()
        {
            InitializeComponent();
        }
        public void llenaCmbDestinos()
        {
            SqlConnection con = new SqlConnection(ConexionBD.strCon);
            SqlDataReader lector;
            string strComando = "SELECT NumBoleto FROM BOLETOS";
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
                this.comboBox1.Items.Clear();
                while (lector.Read())
                {
                    comboBox1.Items.Add(lector.GetValue(0).ToString());

                }
            }
            con.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConexionBD.strCon);
            SqlDataReader lector = null;
            string clave = comboBox1.SelectedItem.ToString();
            string srtComando = "SELECT NumBoleto,ClaveDestino,NombrePasajero,NumAsiento,TipoBoleto,Costo FROM BOLETOS WHERE NumBoleto=" + clave;
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
                    txtClaveDestino.Text = lector.GetValue(1).ToString();
                    txtNomPasajero.Text = lector.GetValue(2).ToString();
                    txtAsiento.Text = lector.GetValue(3).ToString();
                    txtCosto.Text = lector.GetValue(4).ToString();
                    txtTipo.Text = lector.GetValue(5).ToString();

                }
            }
            con.Close();
        }

        private void ConsultaBoletosInd_Load(object sender, EventArgs e)
        {
            llenaCmbDestinos();
        }
    }
}
