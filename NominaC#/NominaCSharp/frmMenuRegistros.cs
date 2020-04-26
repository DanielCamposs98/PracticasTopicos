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
    public partial class frmMenuRegistros : Form
    {

       
        public frmMenuRegistros()
        {
            InitializeComponent();
        }

        private void btnRegEmpleados_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Registro de Empleados";
            UsoFormulario.AbrirFormulario<frmBtnAggEmpleado>(frmPrincipal.panelFormularios);
        }

        private void btnRegDepto_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Registro de Departamentos";
            UsoFormulario.AbrirFormulario<frmBtnRegistrarDepto>(frmPrincipal.panelFormularios);
        }

        private void btnCapturaDias_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Captura de Días";
            UsoFormulario.AbrirFormulario<frmBtnCapturarDias>(frmPrincipal.panelFormularios);
        }

        private void btnRegBonos_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Registro de Bonos";
            UsoFormulario.AbrirFormulario<frmBtnRegBono>(frmPrincipal.panelFormularios);
        }

        private void btnRegDatos_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Registro de Datos a Empleado";
            UsoFormulario.AbrirFormulario<frmBtnAggDatos>(frmPrincipal.panelFormularios);
        }
    }
}
