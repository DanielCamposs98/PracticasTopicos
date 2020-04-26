﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturaAlumnos
{
    public partial class frmConsulta : Form
    {
        ManejaAlumno manAlumno;
        public frmConsulta(ManejaAlumno maneja)
        {
            InitializeComponent();
            manAlumno = maneja;
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            Alumno[] a = manAlumno.generaAlumnos();
            string[] nc = manAlumno.generaNC();
            for(int i = 0; i < a.Length; i++)
            {
                this.dataGridView1.Rows.Add(nc[i], a[i].pNombre, a[i].pCarrera, a[i].pDomicilio, a[i].pEdad);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
