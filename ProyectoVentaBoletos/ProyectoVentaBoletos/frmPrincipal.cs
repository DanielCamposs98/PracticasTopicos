using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVentaBoletos
{
    public partial class frmPrincipal : Form
    {
        private admBoletos adminBoletos;
        private admDestinos adminDestinos;
        public frmPrincipal()
        {
            InitializeComponent();
            adminBoletos = new admBoletos();
            adminDestinos = new admDestinos();
        }

        private void registraDestinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroDest fd = new frmRegistroDest(adminDestinos);
            fd.ShowDialog();
        }

        private void venderBoletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!adminDestinos.tieneDestinos())
            {
                MessageBox.Show("No hay destinos añadidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form1 f1 = new Form1(adminDestinos, adminBoletos);
                f1.ShowDialog();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!adminDestinos.tieneDestinos())
            {
                MessageBox.Show("No hay destinos añadidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmConsultaBoletosDest dd = new frmConsultaBoletosDest(adminBoletos, adminDestinos);
                dd.ShowDialog();
            }
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!adminDestinos.tieneDestinos())
            {
                MessageBox.Show("No hay destinos añadidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmConsultaBoletosDest f = new frmConsultaBoletosDest(adminBoletos, adminDestinos);
                f.ShowDialog();
            }
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDestinos f = new frmConsultaDestinos(adminDestinos);
            f.ShowDialog();
        }
    }
}
