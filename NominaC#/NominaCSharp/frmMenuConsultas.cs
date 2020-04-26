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
    public partial class frmMenuConsultas : Form
    {
        public frmMenuConsultas()
        {
            InitializeComponent();
        }

        private void btnConsultaDepto_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Consulta por Departamentos";
            UsoFormulario.AbrirFormulario<frmConsultaDepto>(frmPrincipal.panelFormularios);
        }

        private void btnConsultaEncDepto_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Reporte de Encargados por Departamento";
            UsoFormulario.AbrirFormulario<frmConsultaEncargados>(frmPrincipal.panelFormularios);
        }

        private void btnConsultaDias_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Reporte de Días Laborados";
            UsoFormulario.AbrirFormulario<frmConsultaDias>(frmPrincipal.panelFormularios);
        }

        private void btnConsultaBonos_Click(object sender, EventArgs e)
        {
            frmPrincipal.lblMenuTitulo.Text = "Reporte de Bonos Extra";
            UsoFormulario.AbrirFormulario<frmConsultaBono>(frmPrincipal.panelFormularios);
        }
    }
}
