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
    public partial class ConsultaBoletosTodos : Form
    {
        public ConsultaBoletosTodos()
        {
            InitializeComponent();
        }

        public void llenaGrid()
        {
            SqlConnection con = new SqlConnection(ConexionBD.strCon);
            SqlDataReader lector;
            string strComando = "SELECT * FROM BOLETOS";
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
                while (lector.Read())
                {

                    dtaGridBoletos.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(),
                        lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString());

                }

            }
            con.Close();
        }

        private void ConsultaBoletosTodos_Load(object sender, EventArgs e)
        {
            llenaGrid();
        }
    }
}
