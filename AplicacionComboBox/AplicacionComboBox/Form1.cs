using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDespColor.Text = ""+cmbColores.SelectedItem;
            lblDespPos.Text = ""+cmbColores.SelectedIndex;
        }
    }
}
