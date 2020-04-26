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
    public partial class frmReporteEmpleados : Form
    {
        public frmReporteEmpleados()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporteEmpleados_Load(object sender, EventArgs e)
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
                string strCommando = "SELECT emp_id, emp_nom, emp_apar, emp_amar, emp_dom, departamento, emp_sueldoD, bon_total FROM EMPLEADOS" +
                    " inner join BONOS on EMPLEADOS.emp_id=BONOS.empleado";
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
                        fila.CreateCells(dataGridViewRepEmp);
                        fila.Cells[0].Value = lector.GetValue(0).ToString();
                        fila.Cells[1].Value = lector.GetValue(1).ToString();
                        fila.Cells[2].Value = lector.GetValue(2).ToString();
                        fila.Cells[3].Value = lector.GetValue(3).ToString();
                        fila.Cells[4].Value = lector.GetValue(4).ToString();
                        fila.Cells[5].Value = lector.GetValue(5).ToString();
                        fila.Cells[6].Value = lector.GetValue(6).ToString();
                        fila.Cells[7].Value = lector.GetValue(7).ToString();

                        dataGridViewRepEmp.Rows.Add(fila);
                    }
                }
                conn.Close();
            }
        }
    }
}
