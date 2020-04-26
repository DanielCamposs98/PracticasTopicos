using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaCSharp
{
    public partial class frmMenuNomina : Form
    {
        public frmMenuNomina()
        {
            InitializeComponent();
        }

        private void btnConsultaNomina_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Consulta de Nómina";
            UsoFormulario.AbrirFormulario<frmConsultaNomina>(frmPrincipal.panelFormularios);
        }

        private void btnReiniciaNomina_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea reiniciar la nomina","Reiniciar Nomina",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        }

        private void btnBorraEmpleado_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Eliminar Empleado";
            UsoFormulario.AbrirFormulario<frmBtnBorrarEmpleado>(frmPrincipal.panelFormularios);
        }
    }
}
