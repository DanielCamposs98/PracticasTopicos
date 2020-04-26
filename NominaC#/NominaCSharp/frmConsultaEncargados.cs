using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBD;

namespace NominaCSharp
{
    public partial class frmConsultaEncargados : Form
    {
        public frmConsultaEncargados()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewNomina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaEncargados_Load(object sender, EventArgs e)
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
                string strCommando = "SELECT dep_id, dep_nombre FROM DEPARTAMENTOS";
                SqlDataReader lector = null;
                try
                {
                    lector = UsoBD.Consulta(strCommando, conn);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al realizar consulta");
                    foreach (SqlError err in ex.Errors)
                    {
                        MessageBox.Show(err.Message);
                    }
                    conn.Close();
                    return;
                }
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridViewNomina);
                        fila.Cells[0].Value = lector.GetValue(0).ToString();
                        fila.Cells[1].Value = lector.GetValue(1).ToString();
                        fila.Cells[2].Value = lector.GetValue(2).ToString();
   
                        dataGridViewNomina.Rows.Add(fila);
                    }
                }
                conn.Close();
            }
        }
    }
}
