namespace NominaCSharp
{
    partial class frmAcercaDe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessNomina = new System.Windows.Forms.Label();
            this.imagenNomina = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.lblMessNomina);
            this.panel1.Controls.Add(this.imagenNomina);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 271);
            this.panel1.TabIndex = 0;
            // 
            // lblMessNomina
            // 
            this.lblMessNomina.AutoSize = true;
            this.lblMessNomina.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessNomina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblMessNomina.Location = new System.Drawing.Point(356, 173);
            this.lblMessNomina.Name = "lblMessNomina";
            this.lblMessNomina.Size = new System.Drawing.Size(188, 30);
            this.lblMessNomina.TabIndex = 1;
            this.lblMessNomina.Text = "Nomina App V. 2.0";
            // 
            // imagenNomina
            // 
            this.imagenNomina.Image = global::NominaCSharp.Properties.Resources.people;
            this.imagenNomina.Location = new System.Drawing.Point(401, 67);
            this.imagenNomina.Name = "imagenNomina";
            this.imagenNomina.Size = new System.Drawing.Size(100, 103);
            this.imagenNomina.TabIndex = 0;
            this.imagenNomina.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyecto Nomina en C#.\r\nUnidad 4. Acceso a Datos.\r\n\r\nTópicos Avanzados de Program" +
    "ación\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 120);
            this.label2.TabIndex = 2;
            this.label2.Text = "Integrantes:\r\n\r\n - Campos Medina Francisco Daniel\r\n - Manjarrez Chaparro Alma Say" +
    "ed\r\n - Pacheco García Miguel Antonio\r\n\r\n";
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcercaDe";
            this.Text = "frmAcercaDe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenNomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imagenNomina;
        private System.Windows.Forms.Label lblMessNomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}