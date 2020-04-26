namespace CapturaAlumnos
{
    partial class frmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NControl,
            this.NomAlumno,
            this.Carrera,
            this.Domicilio,
            this.Edad});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NControl
            // 
            this.NControl.HeaderText = "N° Control";
            this.NControl.MaxInputLength = 8;
            this.NControl.Name = "NControl";
            this.NControl.ReadOnly = true;
            this.NControl.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NControl.Width = 70;
            // 
            // NomAlumno
            // 
            this.NomAlumno.HeaderText = "Nombre de alumno";
            this.NomAlumno.Name = "NomAlumno";
            this.NomAlumno.ReadOnly = true;
            this.NomAlumno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomAlumno.Width = 200;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Carrera.Width = 70;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Domicilio.Width = 200;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MaxInputLength = 2;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edad.Width = 50;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 293);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsulta";
            this.Text = "Consulta Alumnos";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
    }
}