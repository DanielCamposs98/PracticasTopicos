using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaBoletosSQL
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void venderBoletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroBoletos rr = new RegistroBoletos();
            rr.ShowDialog();
    
        }

        private void todosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaBoletosTodos cc = new ConsultaBoletosTodos();
            cc.ShowDialog();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDestinosTodos dd = new ConsultaDestinosTodos();
            dd.ShowDialog();

        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDestinosInd dd = new ConsultaDestinosInd();
            dd.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaBoletosInd dd = new ConsultaBoletosInd();
            dd.ShowDialog();
        }
    }
}
