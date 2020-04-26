namespace NominaCSharp
{
    partial class frmMenuReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuReportes));
            this.btnRepEmpleados = new System.Windows.Forms.Button();
            this.btnReporteEmpDepto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRepEmpleados
            // 
            this.btnRepEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRepEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepEmpleados.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnRepEmpleados.Image")));
            this.btnRepEmpleados.Location = new System.Drawing.Point(365, 49);
            this.btnRepEmpleados.Name = "btnRepEmpleados";
            this.btnRepEmpleados.Size = new System.Drawing.Size(194, 193);
            this.btnRepEmpleados.TabIndex = 10;
            this.btnRepEmpleados.Text = "Reporte de Empleados";
            this.btnRepEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRepEmpleados.UseVisualStyleBackColor = true;
            this.btnRepEmpleados.Click += new System.EventHandler(this.btnRepEmpleados_Click);
            // 
            // btnReporteEmpDepto
            // 
            this.btnReporteEmpDepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteEmpDepto.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnReporteEmpDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteEmpDepto.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteEmpDepto.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteEmpDepto.Image")));
            this.btnReporteEmpDepto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporteEmpDepto.Location = new System.Drawing.Point(103, 49);
            this.btnReporteEmpDepto.Name = "btnReporteEmpDepto";
            this.btnReporteEmpDepto.Size = new System.Drawing.Size(194, 193);
            this.btnReporteEmpDepto.TabIndex = 9;
            this.btnReporteEmpDepto.Text = "Reporte de Empledos por Depto";
            this.btnReporteEmpDepto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporteEmpDepto.UseVisualStyleBackColor = true;
            this.btnReporteEmpDepto.Click += new System.EventHandler(this.btnReporteEmpDepto_Click);
            // 
            // frmMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.btnRepEmpleados);
            this.Controls.Add(this.btnReporteEmpDepto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuReportes";
            this.Text = "frmMenuReportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRepEmpleados;
        private System.Windows.Forms.Button btnReporteEmpDepto;
    }
}