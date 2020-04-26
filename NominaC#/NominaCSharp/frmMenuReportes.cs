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
    public partial class frmMenuReportes : Form
    {
        public frmMenuReportes()
        {
            InitializeComponent();
        }

        private void btnReporteEmpDepto_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Reporte de Empleados por Departamento";
            UsoFormulario.AbrirFormulario<frmReporteEmpDepto>(frmPrincipal.panelFormularios);
        }

        private void btnRepEmpleados_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Reporte de Empleados";
            UsoFormulario.AbrirFormulario<frmReporteEmpleados>(frmPrincipal.panelFormularios);
        }
    }
}
