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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMenuRegistro_Click(object sender, EventArgs e)
        {
            lblMenuTitulo.Text = "Menú Registros";
            UsoFormulario.AbrirFormulario<frmMenuRegistros>(panelFormularios);

        }

        private void btnMenuNomina_Click(object sender, EventArgs e)
        {
            lblMenuTitulo.Text = "Menú Nómina";
            UsoFormulario.AbrirFormulario<frmMenuNomina>(panelFormularios);
        }

        private void btnMenuReportes_Click(object sender, EventArgs e)
        {
            lblMenuTitulo.Text = "Menú Reportes";
            UsoFormulario.AbrirFormulario<frmMenuReportes>(panelFormularios);
        }

        private void btnMenuConsultas_Click(object sender, EventArgs e)
        {
            lblMenuTitulo.Text = "Menú Consultas";
            UsoFormulario.AbrirFormulario<frmMenuConsultas>(panelFormularios);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            lblMenuTitulo.Text = "Acerca De";
            UsoFormulario.AbrirFormulario<frmAcercaDe>(panelFormularios);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }


}
